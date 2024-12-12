using RecruitmentTask.Console.Parser;

var path = @"Files\zadanie_soft_dev_PxCW.csv";

var parser = new ParserCSV();
var employees = parser.ReadEmployeesAsync(path);

await foreach (var employee in employees)
{
    Console.WriteLine(employee.Name);
}