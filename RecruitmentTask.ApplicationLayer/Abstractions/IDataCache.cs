using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer.Abstractions
{
    public interface IDataCache
    {
        IEnumerable<EmployeeDTO> GetFullData();
        void SetFullData(IEnumerable<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByCity(out IEnumerable<EmployeeDTO> employees);
        void SetHighestSalaryByCity(IEnumerable<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByJobLevel(out IEnumerable<EmployeeDTO> employees);
        void SetHighestSalaryByJobLevel(IEnumerable<EmployeeDTO> employees);
        bool TryGetValueTaxSalaryByCity(out IEnumerable<EmployeeDTO> employees);
        void SetTaxSalaryByCity(IEnumerable<EmployeeDTO> employees);
    }
}
