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
        public async Task<List<Employee>> ReadEmployeesAsync(Stream stream)
        {
            using var reader = new StreamReader(stream);
            using var csv = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";", Encoding = Encoding.UTF8 });

            csv.Context.RegisterClassMap<EmployeeMap>();

            var employees = csv.GetRecordsAsync<Employee>();

            return await employees.ToListAsync();
        }
    }
}
