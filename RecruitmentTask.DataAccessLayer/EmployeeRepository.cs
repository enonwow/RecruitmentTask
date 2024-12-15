using RecruitmentTask.DataAccessLayer.Abstractions;

namespace RecruitmentTask.DataAccessLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDataContext _dataContext;

        public EmployeeRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async IAsyncEnumerable<Employee> GetAllEmployeesAsync(Stream stream)
        {
            var employees = _dataContext.ReadEmployeesAsync(stream);

            await foreach (var employee in employees)
            {
                yield return employee;
            }
        }
    }
}
