using RecruitmentTask.Core;

namespace RecruitmentTask.Utility.Abstractions
{
    public interface IParserCSV
    {
        IAsyncEnumerable<Employee> ReadEmployeesAsync(string path);
    }
}
