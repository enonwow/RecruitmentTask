using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer.Abstractions
{
    public interface IDataCache
    {
        IEnumerable<EmployeeDTO> GetFullData(string sessionId);
        void SetFullData(string sessionId, IEnumerable<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByCity(string sessionId, out IEnumerable<EmployeeDTO> employees);
        void SetHighestSalaryByCity(string sessionId, IEnumerable<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByJobLevel(string sessionId, out IEnumerable<EmployeeDTO> employees);
        void SetHighestSalaryByJobLevel(string sessionId, IEnumerable<EmployeeDTO> employees);
        bool TryGetValueTaxSalaryByCity(string sessionId, out IEnumerable<EmployeeDTO> employees);
        void SetTaxSalaryByCity(string sessionId, IEnumerable<EmployeeDTO> employees);
    }
}
