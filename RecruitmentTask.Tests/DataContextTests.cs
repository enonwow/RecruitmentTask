using CsvHelper;
using RecruitmentTask.DataAccessLayer;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class DataContextTests
    {
        [Fact]
        public async Task DataContext_TrySerialize_HeaderValidationException()
        {
            await Assert.ThrowsAsync<HeaderValidationException>(async () =>
            {
                var dataContext = new DataContext();

                await using var stream = new FileStream(@"Files\test_wrong_data.csv", FileMode.Open);
                var nullData = dataContext.ReadEmployeesAsync(stream);

                await foreach(var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task DataContext_ReadEmployeesData_Successful()
        {
            var dataContext = new DataContext();

            await using var stream = new FileStream(@"Files\test_data.csv", FileMode.Open);

            var employeesAsync =  dataContext.ReadEmployeesAsync(stream);
            var employees = await employeesAsync.ToListAsync();
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
