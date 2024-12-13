using RecruitmentTask.Core;

namespace RecruitmentTask.Console.Abstractions
{
    public interface IParserCSV
    {
        IAsyncEnumerable<Employee> ReadEmployeesAsync(string path);
    }
}
