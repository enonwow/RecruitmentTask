using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers.Abstractions;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Rulers
{
    internal class RulerHighestSalaryByCity : RulerBase
    {
        internal override void Validate(Employee employee)
        {
            var city = employee.City;
            var salary = employee.Salary;

            if (!ReulerCollecetion.TryGetValue(city, out var cityValue) 
                || cityValue.First().Salary < salary)
            {
                ReulerCollecetion[city] = new List<EmployeeDTO>
                {
                    new EmployeeDTO(employee)
                };
            }
            else if (cityValue.First().Salary == salary)
            {
                cityValue.Add(new EmployeeDTO(employee));
            }
        }
    }
}
