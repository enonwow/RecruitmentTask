using CsvHelper.Configuration;

namespace RecruitmentTask.DataAccessLayer.Mapers
{
    internal class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Map(p => p.Id).Name("Lp");
            Map(p => p.Name).Name("Imie");
            Map(p => p.Surname).Name("Nazwisko");
            Map(p => p.Salary).Name("Zarobki");
            Map(p => p.JobLevel).Name("Poziom stanowiska");
            Map(p => p.City).Name("Miejsce zmieszkania");
        }
    }
}
