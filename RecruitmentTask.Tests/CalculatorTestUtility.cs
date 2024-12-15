using RecruitmentTask.DataAccessLayer;

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
    }
}
