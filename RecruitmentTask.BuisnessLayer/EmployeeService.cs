﻿using RecruitmentTask.BuisnessLayer.Abstractions;
using RecruitmentTask.BuisnessLayer.Models;
using RecruitmentTask.DataAccessLayer.Abstractions;

namespace RecruitmentTask.BuisnessLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async IAsyncEnumerable<EmployeeDTO> GetAllEmployeesAsync(Stream stream)
        {
            var employees = _employeeRepository.GetAllEmployeesAsync(stream);

            await foreach (var employee in employees)
            {
                yield return new EmployeeDTO(employee);
            }
        }

        public List<EmployeeDTO> GetHighestSalaryByCity(IEnumerable<EmployeeDTO> employees)
        {
            return employees
                .GroupBy(e => e.City)
                .SelectMany(g =>
                {
                    var maxSalary = g.Max(e => e.Salary);
                    return g.Where(e => e.Salary == maxSalary);
                })
                .ToList();
        }

        public List<EmployeeDTO> GetHighestSalaryByJobLevel(IEnumerable<EmployeeDTO> employees)
        {
            return employees
                .GroupBy(e => e.JobLevel)
                .SelectMany(g =>
                {
                    var maxSalary = g.Max(e => e.Salary);
                    return g
                        .Where(e => e.Salary == maxSalary);
                })
                .ToList();
        }

        public List<EmployeeDTO> GetTaxSalaryByCity(IEnumerable<EmployeeDTO> employees)
        {
            return employees
                .GroupBy(e => e.City)
                .SelectMany(g =>
                {
                    var minSalary = g.Min(e => e.Salary - e.Salary * (decimal)0.19);
                    return g
                        .Where(e => e.Salary - e.Salary * (decimal)0.19 == minSalary)
                        .Select(e =>
                        {
                            e.NetSalary = minSalary;
                            return e;
                        });
                })
                .ToList();
        }
    }
}
