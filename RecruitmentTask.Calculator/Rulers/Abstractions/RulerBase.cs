using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;

namespace RecruitmentTask.Calculator.Rulers.Abstractions
{
    internal abstract class RulerBase
    {
        protected Dictionary<string, List<EmployeeDTO>> ReulerCollecetion = new Dictionary<string, List<EmployeeDTO>>();

        abstract internal void Validate(Employee employee);

        public IEnumerable<EmployeeDTO> GetEmployees()
        {
            foreach (var employees in ReulerCollecetion.Values)
            {
                foreach(var employee in employees)
                {
                    yield return employee;
                }
            }
        }
    }
}
