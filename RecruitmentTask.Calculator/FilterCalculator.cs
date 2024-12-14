using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator
{
    public class FilterCalculator : ICalculator
    {
        private readonly RulerHighestSalaryByCity RulerHighestSalaryByCity = new RulerHighestSalaryByCity();
        private readonly RulerHighestSalaryByJobLevel RulerHighestSalaryByJobLevel = new RulerHighestSalaryByJobLevel();
        private readonly RulerTaxSalaryByCity RulerTaxSalaryByCity = new RulerTaxSalaryByCity();

        public async Task PrepareData(IAsyncEnumerable<Employee> employees)
        {
            await foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                RulerHighestSalaryByCity.Validate(employeeCopy);
                RulerHighestSalaryByJobLevel.Validate(employeeCopy);
                RulerTaxSalaryByCity.Validate(employeeCopy);
            }
        }

        public IEnumerable<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                RulerHighestSalaryByCity.Validate(employeeCopy);
            }

            return RulerHighestSalaryByCity
                .GetEmployees();
        }

        public IEnumerable<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                RulerHighestSalaryByJobLevel.Validate(employeeCopy);
            }

            return RulerHighestSalaryByJobLevel
                .GetEmployees();
        }
        
        public IEnumerable<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                RulerTaxSalaryByCity.Validate(employeeCopy);
            }

            return RulerTaxSalaryByCity
                .GetEmployees();
        }
    }
}
