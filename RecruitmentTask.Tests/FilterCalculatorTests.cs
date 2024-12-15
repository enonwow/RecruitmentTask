namespace RecruitmentTask.Tests
{
    public class CalculatorTests_GetHighestSalaryByCity
    {
        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_LowerFirst_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetHighestSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_Multiple_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee),
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetHighestSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_LowerSecond_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        }
        //    };

        //    var result = calculator.GetHighestSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_Successful()
        //{
        //    var calculator = new FilterCalculator();

        //    var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
        //    var secondEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Olsztyn",
        //        Salary = 500,
        //        JobLevel = "S2"
        //    };
        //    var thirdEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 750,
        //        JobLevel = "S1"
        //    };
        //    var fourthEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 1750,
        //        JobLevel = "S1"
        //    };

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(firstEmployee),
        //        new EmployeeDTO(secondEmployee),
        //        new EmployeeDTO(fourthEmployee),
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        firstEmployee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        secondEmployee,
        //        thirdEmployee,
        //        fourthEmployee
        //    };

        //    var result = calculator.GetHighestSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}
    }

    public class CalculatorTests_RulerHighestSalaryByJobLevel()
    {
        //[Fact]
        //public void Calculator_RulerHighestSalaryByJobLevel_LowerFirst_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetHighestSalaryByJobLevel(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_RulerHighestSalaryByJobLevel_Multiple_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee),
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetHighestSalaryByJobLevel(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_RulerHighestSalaryByJobLevel_LowerSecond_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        }
        //    };

        //    var result = calculator.GetHighestSalaryByJobLevel(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_Successful()
        //{
        //    var calculator = new FilterCalculator();

        //    var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
        //    var secondEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Olsztyn",
        //        Salary = 500,
        //        JobLevel = "S2"
        //    };
        //    var thirdEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 750,
        //        JobLevel = "S3"
        //    };
        //    var fourthEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 1750,
        //        JobLevel = "S3"
        //    };

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(firstEmployee),
        //        new EmployeeDTO(secondEmployee),
        //        new EmployeeDTO(fourthEmployee),
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        firstEmployee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 1000,
        //            JobLevel = "S1"
        //        },
        //        secondEmployee,
        //        thirdEmployee,
        //        fourthEmployee
        //    };

        //    var result = calculator.GetHighestSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}
    }

    public class CalculatorTests_RulerTaxSalaryByCity
    {
        //[Fact]
        //public void Calculator_GetTaxSalaryByCity_LowerFirst_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //        {
        //            NetSalary = (decimal)1620.0
        //        }
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 3000,
        //            JobLevel = "S1"
        //        },
        //    };

        //    var result = calculator.GetTaxSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetTaxSalaryByCity_Multiple_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //        {
        //            NetSalary = (decimal)1620.0
        //        },
        //        new EmployeeDTO(employee)
        //        {
        //            NetSalary = (decimal)1620.0
        //        }
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        employee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 3000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetTaxSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetTaxSalaryByCity_LowerSecond_Successful()
        //{
        //    var calculator = new FilterCalculator();
        //    var employee = CalculatorTestUtility.CreateMockEmployee();

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(employee)
        //        {
        //            NetSalary = (decimal)1620.0
        //        }
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 3000,
        //            JobLevel = "S1"
        //        },
        //        employee
        //    };

        //    var result = calculator.GetTaxSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}

        //[Fact]
        //public void Calculator_GetHighestSalaryByCity_Successful()
        //{
        //    var calculator = new FilterCalculator();

        //    var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
        //    var secondEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Olsztyn",
        //        Salary = 1000,
        //        JobLevel = "S2"
        //    };
        //    var thirdEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 2100,
        //        JobLevel = "S1"
        //    };
        //    var fourthEmployee = new Employee
        //    {
        //        Id = 1,
        //        Name = "Łukasz",
        //        Surname = "Test",
        //        City = "Wocławek",
        //        Salary = 1000,
        //        JobLevel = "S1"
        //    };

        //    var expected = new List<EmployeeDTO>()
        //    {
        //        new EmployeeDTO(firstEmployee)
        //        {
        //            NetSalary = (decimal)1620.0
        //        },
        //        new EmployeeDTO(secondEmployee)
        //        {
        //            NetSalary = (decimal)810.0
        //        },
        //        new EmployeeDTO(fourthEmployee)
        //        {
        //            NetSalary = (decimal)810.0
        //        }
        //    };

        //    var employees = new List<Employee>()
        //    {
        //        firstEmployee,
        //        new() {
        //            Id = 1,
        //            Name = "Mateusz",
        //            Surname = "Test",
        //            City = "Warszawa",
        //            Salary = 3000,
        //            JobLevel = "S1"
        //        },
        //        secondEmployee,
        //        thirdEmployee,
        //        fourthEmployee
        //    };

        //    var result = calculator.GetTaxSalaryByCity(employees);

        //    Assert.Equal(expected, result, new EmployeeComparer());
        //}
    }
}
