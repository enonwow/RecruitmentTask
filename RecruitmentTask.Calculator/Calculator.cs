using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator
{
    public class Calculator
    {
        private readonly RulerHighestSalaryByCity RulerHighestSalaryByCity = new RulerHighestSalaryByCity();
        private readonly RulerHighestSalaryByJobLevel RulerHighestSalaryByJobLevel = new RulerHighestSalaryByJobLevel();
        private readonly RulerTaxSalaryByCity RulerTaxSalaryByCity = new RulerTaxSalaryByCity();

        public async Task PrepareData(IAsyncEnumerable<Employee> employees)
        {
            if (employees == null)
            {
                throw new ArgumentNullException(nameof(employees));
            }

            await foreach (var employee in employees)
            {
                RulerHighestSalaryByCity.Validate(employee);
                RulerHighestSalaryByJobLevel.Validate(employee);
                RulerTaxSalaryByCity.Validate(employee);
            }
        }

        public List<EmployeeDTO> GetHighestSalaryByCity()
        {
            return RulerHighestSalaryByCity
                .GetEmployees()
                .ToList();
        }

        public List<EmployeeDTO> GetHighestSalaryByJobLevel()
        {
            return RulerHighestSalaryByJobLevel
                .GetEmployees()
                .ToList();
        }
        
        public List<EmployeeDTO> GetTaxSalaryByCity()
        {
            return RulerTaxSalaryByCity
                .GetEmployees()
                .ToList();
        }
    }
}
