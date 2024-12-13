using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers.Abstractions;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Rulers
{
    internal class RulerTaxSalaryByCity : RulerBase
    {
        internal override void Validate(Employee employee)
        {
            var city = employee.City;
            var netSalary = employee.Salary - (employee.Salary * (decimal)0.19);

            if (!ReulerCollecetion.TryGetValue(city, out var netSalaryValue) 
                || netSalaryValue.First().NetSalary > netSalary)
            {
                ReulerCollecetion[city] = new List<EmployeeDTO>
                {
                    new EmployeeDTO(employee)
                    {
                        NetSalary = netSalary,
                    }
                };
            }
            else if (netSalaryValue.First().NetSalary == netSalary)
            {
                netSalaryValue.Add(new EmployeeDTO(employee)
                {
                    NetSalary = netSalary
                });
            }
        }
    }
}
