using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.BuisnessLayer.Abstractions
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync(Stream stream);
        IEnumerable<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<EmployeeDTO> employees);
        IEnumerable<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<EmployeeDTO> employees);
        IEnumerable<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<EmployeeDTO> employees);
    }
}
