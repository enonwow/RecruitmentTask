using RecruitmentTask.Core;

namespace RecruitmentTask.Utility.Abstractions
{
    public interface IParserCSV
    {
        Task<List<Employee>> ReadEmployeesAsync(Stream stream);
    }
}
