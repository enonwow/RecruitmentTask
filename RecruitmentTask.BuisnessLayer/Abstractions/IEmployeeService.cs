using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.BuisnessLayer.Abstractions
{
    public interface IEmployeeService
    {
        IAsyncEnumerable<EmployeeDTO> GetAllEmployeesAsync(Stream stream);
        List<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<EmployeeDTO> employees);
        List<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<EmployeeDTO> employees);
        List<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<EmployeeDTO> employees);
    }
}
