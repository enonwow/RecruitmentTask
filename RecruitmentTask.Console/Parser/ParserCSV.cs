using CsvHelper;
using CsvHelper.Configuration;
using RecruitmentTask.Console.Abstractions;
using RecruitmentTask.Console.Parser.Mapers;
using RecruitmentTask.Core;
using System.Globalization;
using System.Text;

namespace RecruitmentTask.Console.Parser
{
    public class ParserCSV : IParserCSV
    {
        public async IAsyncEnumerable<Employee> ReadEmployeesAsync(string path)
        {
            var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);

            if (!Path.Exists(fullPath))
            {
                throw new DirectoryNotFoundException($"Could not find path {path}");
            }

            using var reader = new StreamReader(fullPath);
            using var csv = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";", Encoding = Encoding.UTF8 });

            csv.Context.RegisterClassMap<EmployeeMap>();

            var employees = csv.GetRecordsAsync<Employee>();

            await foreach (var employee in employees)
            {
                yield return employee;
            }
        }
    }
}
