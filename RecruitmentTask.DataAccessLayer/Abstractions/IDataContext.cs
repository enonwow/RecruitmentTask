namespace RecruitmentTask.DataAccessLayer.Abstractions
{
    public interface IDataContext
    {
        IAsyncEnumerable<Employee> ReadEmployeesAsync(Stream stream);
    }
}
