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

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(Stream stream)
        {
            return await _dataContext.ReadEmployeesAsync(stream);
        }
    }
}
