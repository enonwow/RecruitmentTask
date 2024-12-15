using RecruitmentTask.ApplicationLayer.Abstractions;
using RecruitmentTask.BuisnessLayer.Abstractions;
using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer
{
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDataCache _dataCache;

        public EmployeeAppService(
            IEmployeeService employeeService,
            IDataCache dataCache)
        {
            _employeeService = employeeService;
            _dataCache = dataCache;
        }

        public async Task<List<EmployeeDTO>> GetEmployeesAsync(Stream stream, string sesionId)
        {
            var employeesAsync = _employeeService.GetAllEmployeesAsync(stream);
            var employees = await employeesAsync.ToListAsync();

            _dataCache.SetFullData(sesionId, employees);

            return employees;
        }

        public List<EmployeeDTO> GetAllEmployeesFromCache(string sesionId)
        {
            return _dataCache.GetFullData(sesionId);
        }

        public List<EmployeeDTO> GetHighestSalaryByCity(string sesionId)
        {
            if (_dataCache.TryGetValueHighestSalaryByCity(sesionId, out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData(sesionId);

            var newData = _employeeService
                .GetHighestSalaryByCity(employees);

            _dataCache.SetHighestSalaryByCity(sesionId, newData);

            return newData;
        }

        public List<EmployeeDTO> GetHighestSalaryByJobLevel(string sesionId)
        {
            if (_dataCache.TryGetValueHighestSalaryByJobLevel(sesionId, out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData(sesionId);

            var newData = _employeeService
                .GetHighestSalaryByJobLevel(employees);

            _dataCache.SetHighestSalaryByJobLevel(sesionId, newData);

            return newData;
        }

        public List<EmployeeDTO> GetTaxSalaryByCity(string sesionId)
        {
            if (_dataCache.TryGetValueTaxSalaryByCity(sesionId, out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData(sesionId);

            var newData = _employeeService
                .GetTaxSalaryByCity(employees);

            _dataCache.SetTaxSalaryByCity(sesionId, newData);

            return newData;
        }
    }
}
