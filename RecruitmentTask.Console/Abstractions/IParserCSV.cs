using RecruitmentTask.Console.Models;

namespace RecruitmentTask.Console.Abstractions
{
    public interface IParserCSV
    {
        IAsyncEnumerable<Employee> ReadEmployeesAsync(string path);
    }
}
