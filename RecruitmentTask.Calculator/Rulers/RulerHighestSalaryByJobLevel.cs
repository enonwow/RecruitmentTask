using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Calculator.Rulers.Abstractions;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Rulers
{
    internal class RulerHighestSalaryByJobLevel : RulerBase
    {
        internal override void Validate(Employee employee)
        {
            var jobLevel = employee.JobLevel;
            var salary = employee.Salary;

            if (!ReulerCollecetion.TryGetValue(jobLevel, out var jobLevelValue) 
                || jobLevelValue.First().Salary < salary)
            {
                ReulerCollecetion[jobLevel] = new List<EmployeeDTO>
                {
                    new EmployeeDTO(employee)
                };
            }
            else if (jobLevelValue.First().Salary == salary)
            {
                jobLevelValue.Add(new EmployeeDTO(employee));
            }
        }
    }
}
