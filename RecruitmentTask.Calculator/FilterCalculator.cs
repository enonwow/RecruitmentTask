using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers;
using RecruitmentTask.Calculator.Rulers.Abstractions;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator
{
    public class FilterCalculator : IFilterCalculator
    {
        private readonly RulerHighestSalaryByCity RulerHighestSalaryByCity = new();
        private readonly RulerHighestSalaryByJobLevel RulerHighestSalaryByJobLevel = new();
        private readonly RulerTaxSalaryByCity RulerTaxSalaryByCity = new();

        public IEnumerable<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<Employee> employees)
        {
            return FilterOrCalculate(employees, RulerHighestSalaryByCity);
        }

        public IEnumerable<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<Employee> employees)
        {
            return FilterOrCalculate(employees, RulerHighestSalaryByJobLevel);
        }

        public IEnumerable<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<Employee> employees)
        {
            return FilterOrCalculate(employees, RulerTaxSalaryByCity);
        }

        private IEnumerable<EmployeeDTO> FilterOrCalculate(IEnumerable<Employee> employees, RulerBase ruler)
        {
            foreach (var employee in employees)
            {
                var employeeCopy = employee.ShallowCopy();

                ruler.Validate(employeeCopy);
            }

            return ruler.GetEmployees();
        }
    }
}
