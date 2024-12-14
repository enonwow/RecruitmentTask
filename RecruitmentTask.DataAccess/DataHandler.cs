using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.DataAccess.Abstractions;
using RecruitmentTask.Utility.Abstractions;

namespace RecruitmentTask.DataAccess
{
    public class DataHandler : IDataHandler
    {
        private readonly IParserCSV _parserCSV;
        private readonly IFilterCalculator _filterCalculator;
        private readonly IDataCache _dataCache;

        public DataHandler(
            IParserCSV parserCSV,
            IFilterCalculator filterCalculator,
            IDataCache dataCache)
        {
            _parserCSV = parserCSV;
            _filterCalculator = filterCalculator;
            _dataCache = dataCache;
        }

        public async Task<List<EmployeeDTO>> GetEmployeesAsync(Stream stream)
        {
            var employees = await _parserCSV.ReadEmployeesAsync(stream);
            _dataCache.SetFullData(employees);

            var employeesDTO = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                employeesDTO.Add(
                    new EmployeeDTO(employee)
                );
            }

            return employeesDTO;
        }

        public List<EmployeeDTO> GetHighestSalaryByCity()
        {
            if (_dataCache.TryGetValueHighestSalaryByCity(out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData();

            var newData = _filterCalculator
                .GetHighestSalaryByCity(employees)
                .ToList();

            _dataCache.SetHighestSalaryByCity(newData);

            return newData;
        }

        public List<EmployeeDTO> GetHighestSalaryByJobLevel()
        {
            if (_dataCache.TryGetValueHighestSalaryByJobLevel(out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData();

            var newData = _filterCalculator
                .GetHighestSalaryByJobLevel(employees)
                .ToList();

            _dataCache.SetHighestSalaryByJobLevel(newData);

            return newData;
        }

        public List<EmployeeDTO> GetTaxSalaryByCity()
        {
            if (_dataCache.TryGetValueTaxSalaryByCity(out var data))
            {
                return data;
            }

            var employees = _dataCache.GetFullData();

            var newData = _filterCalculator
                .GetTaxSalaryByCity(employees)
                .ToList();

            _dataCache.SetTaxSalaryByCity(newData);

            return newData;
        }
    }
}
