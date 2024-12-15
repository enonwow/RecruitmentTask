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

        public List<EmployeeDTO> GetFullData(string sessionId)
        {
            return _memoryCache.Get<List<EmployeeDTO>>(GetKey(sessionId, FullData));
        }

        public void SetFullData(string sessionId, List<EmployeeDTO> employees)
        {
            _memoryCache.Set(GetKey(sessionId, FullData), employees);
        }

        public bool TryGetValueHighestSalaryByCity(string sessionId, out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(GetKey(sessionId, HighestSalaryByCity), out employees);
        }

        public void SetHighestSalaryByCity(string sessionId, List<EmployeeDTO> employees)
        {
            _memoryCache.Set(GetKey(sessionId, HighestSalaryByCity), employees);
        }

        public bool TryGetValueHighestSalaryByJobLevel(string sessionId, out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(GetKey(sessionId, HighestSalaryByJobLevel), out employees);
        }

        public void SetHighestSalaryByJobLevel(string sessionId, List<EmployeeDTO> employees)
        {
            _memoryCache.Set(GetKey(sessionId, HighestSalaryByJobLevel), employees);
        }

        public bool TryGetValueTaxSalaryByCity(string sessionId, out List<EmployeeDTO> employees)
        {
            return _memoryCache.TryGetValue(GetKey(sessionId, TaxSalaryByCity), out employees);
        }

        public void SetTaxSalaryByCity(string sessionId, List<EmployeeDTO> employees)
        {
            _memoryCache.Set(GetKey(sessionId, TaxSalaryByCity), employees);
        }

        private string GetKey(string sessionId, string key)
        {
            return $"{sessionId}-{key}";
        }
    }
}
