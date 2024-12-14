using RecruitmentTask.Calculator;
using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Utility;

var parser = new ParserCSV();
var employees = await parser.ReadEmployeesAsync(@"Files\zadanie_soft_dev_PxCW.csv");

var calcultor = new FilterCalculator();

DisplayOptions();

void DisplayOptions()
{
    char keyChar;

    do
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("1 - Wyświetl najwyższe wynagrodzenie względem miasta");
        Console.WriteLine("2 - Wyświetl najwyższe wynagrodzenie na danym stanowisku");
        Console.WriteLine("3 - Wyświetl najniżesz wynagrodzenie po podatku dla danego miasta");
        Console.WriteLine("9 - Wyjście z aplikacji");
        Console.WriteLine("");
        Console.Write("Wybierz opcję: ");

        keyChar = Console.ReadKey().KeyChar;

        Console.WriteLine("\n");

        switch (keyChar)
        {
            case '1':
                DisplayData(calcultor.GetHighestSalaryByCity(employees));
                break;
            case '2':
                DisplayData(calcultor.GetHighestSalaryByJobLevel(employees));
                break;
            case '3':
                DisplayData(calcultor.GetTaxSalaryByCity(employees));
                break;
        }

        Console.WriteLine("");
    }
    while (keyChar != '9');
}

void DisplayData(IEnumerable<EmployeeDTO> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Imię: {employee.Name}, Nazwisko: {employee.Surname}, Wynagrodzenie: {employee.Salary}, " +
            $"Stanowisko: {employee.JobLevel}, Miasto: {employee.City}");
    }
}