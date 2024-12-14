using CsvHelper;
using RecruitmentTask.Utility;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class ParserSCVTests
    {
        [Fact]
        public async Task Parser_TryGetPath_DirectoryNotFoundException()
        {
            await Assert.ThrowsAsync<DirectoryNotFoundException>(async () =>
            {
                var parser = new ParserCSV();

                var nullData = await parser.ReadEmployeesAsync("Wrong path");

                foreach (var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task Parser_TrySerialize_HeaderValidationException()
        {
            await Assert.ThrowsAsync<HeaderValidationException>(async () =>
            {
                var parser = new ParserCSV();

                var nullData = await parser.ReadEmployeesAsync(@"Files\test_wrong_data.csv");

                foreach (var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task Parser_ReadEmployeesData_Successful()
        {
            var parser = new ParserCSV();

            var employees = await parser.ReadEmployeesAsync(@"Files\test_data.csv");
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
