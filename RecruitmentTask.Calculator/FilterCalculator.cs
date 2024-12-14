using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator
{
    public class FilterCalculator : IFilterCalculator
    {
        public IEnumerable<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<Employee> employees)
        {
            return employees
                .GroupBy(e => e.City)
                .SelectMany(g =>
                {
                    var maxSalary = g.Max(e => e.Salary);
                    return g
                        .Where(e => e.Salary == maxSalary)
                        .Select(e => new EmployeeDTO(e));
                });
        }

        public IEnumerable<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<Employee> employees)
        {
            return employees
                .GroupBy(e => e.JobLevel)
                .SelectMany(g =>
                {
                    var maxSalary = g.Max(e => e.Salary);
                    return g
                        .Where(e => e.Salary == maxSalary)
                        .Select(e => new EmployeeDTO(e));
                });
        }

        public IEnumerable<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<Employee> employees)
        {
            return employees
                .GroupBy(e => e.City)
                .SelectMany(g =>
                {
                    var minSalary = g.Min(e => e.Salary - e.Salary * (decimal)0.19);
                    return g
                        .Where(e => e.Salary - e.Salary * (decimal)0.19 == minSalary)
                        .Select(e => new EmployeeDTO(e)
                        {
                            NetSalary = minSalary
                        });
                });
        }
    }
}
