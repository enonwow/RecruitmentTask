using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator
{
    public class Calculator : ICalculator
    {
        private readonly RulerHighestSalaryByCity RulerHighestSalaryByCity = new RulerHighestSalaryByCity();
        private readonly RulerHighestSalaryByJobLevel RulerHighestSalaryByJobLevel = new RulerHighestSalaryByJobLevel();
        private readonly RulerTaxSalaryByCity RulerTaxSalaryByCity = new RulerTaxSalaryByCity();

        public async Task PrepareData(IAsyncEnumerable<Employee> employees)
        {
            ArgumentNullException.ThrowIfNull(employees);

            await foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                RulerHighestSalaryByCity.Validate(employeeCopy);
                RulerHighestSalaryByJobLevel.Validate(employeeCopy);
                RulerTaxSalaryByCity.Validate(employeeCopy);
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
