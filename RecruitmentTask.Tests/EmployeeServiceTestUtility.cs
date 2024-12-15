using RecruitmentTask.DataAccessLayer;

namespace RecruitmentTask.Tests
{
    internal static class EmployeeServiceTestUtility
    {
        public static Employee CreateMockEmployee()
        {
            return new Employee
            {
                Id = 1,
                Name = "Bartek",
                Surname = "Test",
                City = "Warszawa",
                Salary = 2000,
                JobLevel = "S1"
            };
        }

        public static async IAsyncEnumerable<Employee> CreateMockIAsyncEnumerable(int max = 1)
        {
            for (int i = 1; i <= max; i++)
            {
                await Task.Delay(100);
                yield return new Employee()
                {
                    Id = max,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                };
            }
        }
    }
}
