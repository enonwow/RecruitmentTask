using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer.Abstractions
{
    public interface IDataCache
    {
        List<EmployeeDTO> GetFullData(string sessionId);
        void SetFullData(string sessionId, List<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByCity(string sessionId, out List<EmployeeDTO> employees);
        void SetHighestSalaryByCity(string sessionId, List<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByJobLevel(string sessionId, out List<EmployeeDTO> employees);
        void SetHighestSalaryByJobLevel(string sessionId, List<EmployeeDTO> employees);
        bool TryGetValueTaxSalaryByCity(string sessionId, out List<EmployeeDTO> employees);
        void SetTaxSalaryByCity(string sessionId, List<EmployeeDTO> employees);
    }
}
