using RecruitmentTask.DataAccessLayer;

namespace RecruitmentTask.BuisnessLayer.Models
{
    public class EmployeeDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public decimal Salary { get; private set; }
        public string JobLevel { get; private set; }
        public string City { get; private set; }
        public decimal? NetSalary { get; set; }

        public EmployeeDTO(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Surname = employee.Surname;
            Salary = employee.Salary;
            JobLevel = employee.JobLevel;
            City = employee.City;
        }
    }
}
