using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Abstractions
{
    public interface IFilterCalculator
    {
        IEnumerable<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<Employee> employees);
        IEnumerable<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<Employee> employees);
        IEnumerable<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<Employee> employees);
    }
}
