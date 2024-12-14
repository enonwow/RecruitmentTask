using CsvHelper;
using RecruitmentTask.Utility;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class ParserSCVTests
    {
        [Fact]
        public async Task Parser_TrySerialize_HeaderValidationException()
        {
            await Assert.ThrowsAsync<HeaderValidationException>(async () =>
            {
                var parser = new ParserCSV();

                using var stream = new FileStream(@"Files\test_wrong_data.csv", FileMode.Open);
                var nullData = await parser.ReadEmployeesAsync(stream);

                foreach (var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task Parser_ReadEmployeesData_Successful()
        {
            var parser = new ParserCSV();

            using var stream = new FileStream(@"Files\test_data.csv", FileMode.Open);

            var employees = await parser.ReadEmployeesAsync(stream);
            var emplyee = employees.First();

            Assert.Equal(1, emplyee.Id);
            Assert.Equal("Bogumił Pietrzak", emplyee.Name);
            Assert.Equal("Kowalski", emplyee.Surname);
            Assert.Equal(672, emplyee.Salary);
            Assert.Equal("S4", emplyee.JobLevel);
            Assert.Equal("Warszawa", emplyee.City);
        }
    }
}
