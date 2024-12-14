using RecruitmentTask.Calculator.Models;

namespace RecruitmentTask.DataAccess.Abstractions
{
    public interface IDataHandler
    {
        Task<List<EmployeeDTO>> GetEmployeesAsync(string csvFile);
        List<EmployeeDTO> GetHighestSalaryByCity();
        List<EmployeeDTO> GetHighestSalaryByJobLevel();
        List<EmployeeDTO> GetTaxSalaryByCity();
    }
}
