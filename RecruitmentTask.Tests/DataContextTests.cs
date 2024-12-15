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

                using var stream = new FileStream(@"Files\test_wrong_data.csv", FileMode.Open);
                var nullData = await dataContext.ReadEmployeesAsync(stream);

                foreach (var item in nullData)
                {

                }
            });
        }

        [Fact]
        public async Task DataContext_ReadEmployeesData_Successful()
        {
            var dataContext = new DataContext();

            using var stream = new FileStream(@"Files\test_data.csv", FileMode.Open);

            var employees = await dataContext.ReadEmployeesAsync(stream);
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
