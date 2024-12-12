using RecruitmentTask.Console.Models;
using RecruitmentTask.Console.Parser;

var parser = new ParserCSV();
var employees = parser.ReadEmployeesAsync(@"Files\zadanie_soft_dev_PxCW.csv");

var HighestSalaryByCity = new Dictionary<string, List<Employee>>();
var HighestSalaryByJobLevel = new Dictionary<string, List<Employee>>();

await foreach (var employee in employees)
{
    var city = employee.City;
    var jobLevel = employee.JobLevel;
    var salary = employee.Salary;

    if (!HighestSalaryByCity.TryGetValue(city, out var cityValue) || cityValue.First().Salary < salary)
    {
        HighestSalaryByCity[city] = new List<Employee>
        {
            employee
        };
    }
    else if (cityValue.First().Salary == salary)
    {
        cityValue.Add(employee);
    }

    if (!HighestSalaryByJobLevel.TryGetValue(jobLevel, out var jobLevelValue) || jobLevelValue.First().Salary < salary)
    {
        HighestSalaryByJobLevel[jobLevel] = new List<Employee>
        {
            employee
        };
    }
    else if (jobLevelValue.First().Salary == salary)
    {
        jobLevelValue.Add(employee);
    }
}

DisplayOptions();

void DisplayOptions()
{
    char keyChar;

    do
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("1 - Wyświetl najwyższe wynagrodzenie względem miasta");
        Console.WriteLine("2 - Wyświetl najwyższe wynagrodzenie na danym stanowisku");
        Console.WriteLine("9 - Wyjście z aplikacji");
        Console.WriteLine("");
        Console.Write("Wybierz opcję: ");

        keyChar = Console.ReadKey().KeyChar;

        Console.WriteLine("\n");

        switch (keyChar)
        {
            case '1':
                DisplayData(HighestSalaryByCity);
                break;
            case '2':
                DisplayData(HighestSalaryByJobLevel);
                break;
        }

        Console.WriteLine("");
    }
    while (keyChar != '9');
}

void DisplayData(Dictionary<string, List<Employee>> data)
{
    foreach (var item in data.Values)
    {
        foreach (var e in item)
        {
            Console.WriteLine($"Imię: {e.Name}, Nazwisko: {e.Surname}, Wynagrodzenie: {e.Salary}, " +
                $"Stanowisko: {e.JobLevel}, Miasto: {e.City}");
        }
    }
}