using CsvHelper;
using CsvHelper.Configuration;
using RecruitmentTask.Core;
using RecruitmentTask.Utility.Abstractions;
using RecruitmentTask.Utility.Mapers;
using System.Globalization;
using System.Text;

namespace RecruitmentTask.Utility
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
