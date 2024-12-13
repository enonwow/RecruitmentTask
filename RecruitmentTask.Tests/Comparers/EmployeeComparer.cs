using RecruitmentTask.Calculator.Models;
using System.Diagnostics.CodeAnalysis;

namespace RecruitmentTask.Tests.Comparers
{
    public class EmployeeComparer : IEqualityComparer<EmployeeDTO>
    {
        public bool Equals(EmployeeDTO? x, EmployeeDTO? y)
        {
            return x.Id.Equals(y.Id)
                && x.Name.Equals(y.Name)
                && x.Surname.Equals(y.Surname)
                && x.City.Equals(y.City)
                && x.Salary.Equals(y.Salary)
                && x.JobLevel.Equals(y.JobLevel)
                && x.NetSalary.Equals(y.NetSalary);
        }

        public int GetHashCode([DisallowNull] EmployeeDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
