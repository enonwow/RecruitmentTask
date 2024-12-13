using RecruitmentTask.Core;

namespace RecruitmentTask.Tests
{
    internal static class CalculatorTestUtility
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

        public static async IAsyncEnumerable<Employee> PrepareTestData(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                yield return employee;
            }
        }
    }
}
