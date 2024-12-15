namespace RecruitmentTask.DataAccessLayer.Abstractions
{
    public interface IEmployeeRepository
    {
        IAsyncEnumerable<Employee> GetAllEmployeesAsync(Stream stream);
    }
}
