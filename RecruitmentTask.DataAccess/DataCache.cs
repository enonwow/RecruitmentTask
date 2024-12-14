using Microsoft.Extensions.Caching.Memory;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;
using RecruitmentTask.DataAccess.Abstractions;

namespace RecruitmentTask.DataAccess
{
    public class DataCache : IDataCache
    {
        private readonly IMemoryCache _memoryCache;

        private const string FullData = "FullData";
        private const string FullDataDTO = "FullDataDTO";
        private const string HighestSalaryByCity = "HighestSalaryByCity";
        private const string HighestSalaryByJobLevel = "HighestSalaryByJobLevel";
        private const string TaxSalaryByCity = "TaxSalaryByCity";

        public DataCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public List<Employee> GetFullData()
        {
            return _memoryCache.Get<List<Employee>>(FullData);
        }

        public void SetFullData(List<Employee> employees)
        {
            _memoryCache.Set(FullData, employees);

            if(_memoryCache.TryGetValue(HighestSalaryByCity, out _))
            {
                _memoryCache.Remove(HighestSalaryByCity);
            }

            if (_memoryCache.TryGetValue(HighestSalaryByJobLevel, out _))
            {
                _memoryCache.Remove(HighestSalaryByJobLevel);
            }

            if (_memoryCache.TryGetValue(TaxSalaryByCity, out _))
            {
                _memoryCache.Remove(TaxSalaryByCity);
            }
        }
        public List<EmployeeDTO> GetFullDataDTO()
        {
            return _memoryCache.Get<List<EmployeeDTO>>(FullDataDTO);
        }

        public void SetFullDataDTO(List<EmployeeDTO> employees)
        {
            _memoryCache.Set(FullDataDTO, employees);
        }

        public bool TryGetValueHighestSalaryByCity(out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(HighestSalaryByCity, out employees);
        }

        public void SetHighestSalaryByCity(List<EmployeeDTO> employees)
        {
            _memoryCache.Set(HighestSalaryByCity, employees);
        }

        public bool TryGetValueHighestSalaryByJobLevel(out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(HighestSalaryByJobLevel, out employees);
        }

        public void SetHighestSalaryByJobLevel(List<EmployeeDTO> employees)
        {
            _memoryCache.Set(HighestSalaryByJobLevel, employees);
        }

        public bool TryGetValueTaxSalaryByCity(out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(TaxSalaryByCity, out employees);
        }

        public void SetTaxSalaryByCity(List<EmployeeDTO> employees)
        {
            _memoryCache.Set(TaxSalaryByCity, employees);
        }
    }
}
