using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Abstractions
{
    public interface ICalculator
    {
        Task PrepareData(IAsyncEnumerable<Employee> employees);
        List<EmployeeDTO> GetHighestSalaryByCity();
        List<EmployeeDTO> GetHighestSalaryByJobLevel();
        List<EmployeeDTO> GetTaxSalaryByCity();
    }
}
