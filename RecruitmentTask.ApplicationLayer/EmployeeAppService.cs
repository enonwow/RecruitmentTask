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

        public async Task<List<EmployeeDTO>> GetEmployeesAsync(Stream stream)
        {
            var employees = await _employeeService.GetAllEmployeesAsync(stream);
            _dataCache.SetFullData(employees);

            return employees.ToList();
        }

        public List<EmployeeDTO> GetAllEmployeesFromCache()
        {
            return _dataCache.GetFullData().ToList();
        }

        public List<EmployeeDTO> GetHighestSalaryByCity()
        {
            if (_dataCache.TryGetValueHighestSalaryByCity(out var data))
            {
                return data.ToList();
            }

            var employees = _dataCache.GetFullData();

            var newData = _employeeService
                .GetHighestSalaryByCity(employees);

            _dataCache.SetHighestSalaryByCity(newData);

            return newData.ToList();
        }

        public List<EmployeeDTO> GetHighestSalaryByJobLevel()
        {
            if (_dataCache.TryGetValueHighestSalaryByJobLevel(out var data))
            {
                return data.ToList();
            }

            var employees = _dataCache.GetFullData();

            var newData = _employeeService
                .GetHighestSalaryByJobLevel(employees);

            _dataCache.SetHighestSalaryByJobLevel(newData);

            return newData.ToList();
        }

        public List<EmployeeDTO> GetTaxSalaryByCity()
        {
            if (_dataCache.TryGetValueTaxSalaryByCity(out var data))
            {
                return data.ToList();
            }

            var employees = _dataCache.GetFullData();

            var newData = _employeeService
                .GetTaxSalaryByCity(employees);

            _dataCache.SetTaxSalaryByCity(newData);

            return newData.ToList();
        }
    }
}
