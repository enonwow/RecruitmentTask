namespace RecruitmentTask.DataAccessLayer.Abstractions
{
    public interface IDataContext
    {
        Task<IEnumerable<Employee>> ReadEmployeesAsync(Stream stream);
    }
}
