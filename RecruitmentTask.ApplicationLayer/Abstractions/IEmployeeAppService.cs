using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer.Abstractions
{
    public interface IEmployeeAppService
    {
        Task<List<EmployeeDTO>> GetEmployeesAsync(Stream stream);
        List<EmployeeDTO> GetAllEmployeesFromCache();
        List<EmployeeDTO> GetHighestSalaryByCity();
        List<EmployeeDTO> GetHighestSalaryByJobLevel();
        List<EmployeeDTO> GetTaxSalaryByCity();
    }
}
