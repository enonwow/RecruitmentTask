using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer.Abstractions
{
    public interface IEmployeeAppService
    {
        Task<List<EmployeeDTO>> GetEmployeesAsync(Stream stream, string sessionId);
        List<EmployeeDTO> GetAllEmployeesFromCache(string sessionId);
        List<EmployeeDTO> GetHighestSalaryByCity(string sessionId);
        List<EmployeeDTO> GetHighestSalaryByJobLevel(string sessionId);
        List<EmployeeDTO> GetTaxSalaryByCity(string sessionId);
    }
}
