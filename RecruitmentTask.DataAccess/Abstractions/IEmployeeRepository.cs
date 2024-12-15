namespace RecruitmentTask.DataAccessLayer.Abstractions
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync(Stream stream);
    }
}
