using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;

namespace RecruitmentTask.DataAccess.Abstractions
{
    public interface IDataCache
    {
        List<Employee> GetFullData();
        void SetFullData(List<Employee> employees);
        bool TryGetValueHighestSalaryByCity(out List<EmployeeDTO> employees);
        void SetHighestSalaryByCity(List<EmployeeDTO> employees);
        bool TryGetValueHighestSalaryByJobLevel(out List<EmployeeDTO> employees);
        void SetHighestSalaryByJobLevel(List<EmployeeDTO> employees);
        bool TryGetValueTaxSalaryByCity(out List<EmployeeDTO> employees);
        void SetTaxSalaryByCity(List<EmployeeDTO> employees);
    }
}
