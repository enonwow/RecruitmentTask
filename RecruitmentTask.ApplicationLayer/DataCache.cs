using Microsoft.Extensions.Caching.Memory;
using RecruitmentTask.ApplicationLayer.Abstractions;
using RecruitmentTask.BuisnessLayer.Models;

namespace RecruitmentTask.ApplicationLayer
{
    public class DataCache : IDataCache
    {
        private readonly IMemoryCache _memoryCache;

        private const string FullData = "FullData";
        private const string HighestSalaryByCity = "HighestSalaryByCity";
        private const string HighestSalaryByJobLevel = "HighestSalaryByJobLevel";
        private const string TaxSalaryByCity = "TaxSalaryByCity";

        public DataCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IEnumerable<EmployeeDTO> GetFullData()
        {
            return _memoryCache.Get<IEnumerable<EmployeeDTO>>(FullData);
        }

        public void SetFullData(IEnumerable<EmployeeDTO> employees)
        {
            _memoryCache.Set(FullData, employees);
        }

        public bool TryGetValueHighestSalaryByCity(out IEnumerable<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(HighestSalaryByCity, out employees);
        }

        public void SetHighestSalaryByCity(IEnumerable<EmployeeDTO> employees)
        {
            _memoryCache.Set(HighestSalaryByCity, employees);
        }

        public bool TryGetValueHighestSalaryByJobLevel(out IEnumerable<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(HighestSalaryByJobLevel, out employees);
        }

        public void SetHighestSalaryByJobLevel(IEnumerable<EmployeeDTO> employees)
        {
            _memoryCache.Set(HighestSalaryByJobLevel, employees);
        }

        public bool TryGetValueTaxSalaryByCity(out IEnumerable<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(TaxSalaryByCity, out employees);
        }

        public void SetTaxSalaryByCity(IEnumerable<EmployeeDTO> employees)
        {
            _memoryCache.Set(TaxSalaryByCity, employees);
        }
    }
}
