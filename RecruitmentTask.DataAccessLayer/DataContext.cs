using CsvHelper;
using CsvHelper.Configuration;
using RecruitmentTask.DataAccessLayer.Abstractions;
using RecruitmentTask.DataAccessLayer.Mapers;
using System.Globalization;
using System.Text;

namespace RecruitmentTask.DataAccessLayer
{
    public class DataContext : IDataContext
    {
        public async IAsyncEnumerable<Employee> ReadEmployeesAsync(Stream stream)
        {
            using var reader = new StreamReader(stream);
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
