using RecruitmentTask.Console.Parser;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class ParserSCVTests
    {
        [Fact]
        public async Task Parser_TryGetPath_ThrowException()
        {
            await Assert.ThrowsAsync<DirectoryNotFoundException>(async () =>
            {
                var parser = new ParserCSV();

                var nullData = parser.ReadEmployeesAsync("Wrong path");

                await foreach (var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task Parser_ReadEmployeesData()
        {
            var parser = new ParserCSV();

            var employees = parser.ReadEmployeesAsync(@"Files\test_data.csv");
            var emplyee = await employees.FirstAsync();

            Assert.Equal(1, emplyee.Id);
            Assert.Equal("Bogumił Pietrzak", emplyee.Name);
            Assert.Equal("Kowalski", emplyee.Surname);
            Assert.Equal(672, emplyee.Salary);
            Assert.Equal("S4", emplyee.JobLevel);
            Assert.Equal("Warszawa", emplyee.City);
        }
    }
}
