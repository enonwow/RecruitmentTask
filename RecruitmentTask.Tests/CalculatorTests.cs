using RecruitmentTask.Calculator.Models;
using RecruitmentTask.Core;
using RecruitmentTask.Tests.Comparers;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public async Task Calculator_TryPrepareData_ArgumentNullException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                var calculator = new Calculator.Calculator();
                await calculator.PrepareData(null);
            });
        }
    }

    public class CalculatorTests_GetHighestSalaryByCity
    {
        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_LowerFirst_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetHighestSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_Multiple_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee),
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);
            var result = calculator.GetHighestSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_LowerSecond_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetHighestSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_Successful()
        {
            var calculator = new Calculator.Calculator();

            var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
            var secondEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Olsztyn",
                Salary = 500,
                JobLevel = "S2"
            };
            var thirdEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 750,
                JobLevel = "S1"
            };
            var fourthEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 1750,
                JobLevel = "S1"
            };

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(firstEmployee),
                new EmployeeDTO(secondEmployee),
                new EmployeeDTO(fourthEmployee),
            };

            var employees = new List<Employee>()
            {
                firstEmployee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                secondEmployee,
                thirdEmployee,
                fourthEmployee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetHighestSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }
    }

    public class CalculatorTests_RulerHighestSalaryByJobLevel()
    {
        [Fact]
        public async Task Calculator_RulerHighestSalaryByJobLevel_LowerFirst_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetHighestSalaryByJobLevel();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_RulerHighestSalaryByJobLevel_Multiple_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee),
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);
            var result = calculator.GetHighestSalaryByJobLevel();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_RulerHighestSalaryByJobLevel_LowerSecond_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);
            var result = calculator.GetHighestSalaryByJobLevel();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_Successful()
        {
            var calculator = new Calculator.Calculator();

            var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
            var secondEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Olsztyn",
                Salary = 500,
                JobLevel = "S2"
            };
            var thirdEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 750,
                JobLevel = "S3"
            };
            var fourthEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 1750,
                JobLevel = "S3"
            };

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(firstEmployee),
                new EmployeeDTO(secondEmployee),
                new EmployeeDTO(fourthEmployee),
            };

            var employees = new List<Employee>()
            {
                firstEmployee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                },
                secondEmployee,
                thirdEmployee,
                fourthEmployee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetHighestSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }
    }

    public class CalculatorTests_RulerTaxSalaryByCity
    {
        [Fact]
        public async Task Calculator_GetTaxSalaryByCity_LowerFirst_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                }
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                },
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetTaxSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetTaxSalaryByCity_Multiple_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                },
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                }
            };

            var employees = new List<Employee>()
            {
                employee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);
            var result = calculator.GetTaxSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetTaxSalaryByCity_LowerSecond_Successful()
        {
            var calculator = new Calculator.Calculator();
            var employee = CalculatorTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                }
            };

            var employees = new List<Employee>()
            {
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                },
                employee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetTaxSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public async Task Calculator_GetHighestSalaryByCity_Successful()
        {
            var calculator = new Calculator.Calculator();

            var firstEmployee = CalculatorTestUtility.CreateMockEmployee();
            var secondEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Olsztyn",
                Salary = 1000,
                JobLevel = "S2"
            };
            var thirdEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 2100,
                JobLevel = "S1"
            };
            var fourthEmployee = new Employee
            {
                Id = 1,
                Name = "Łukasz",
                Surname = "Test",
                City = "Wocławek",
                Salary = 1000,
                JobLevel = "S1"
            };

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(firstEmployee)
                {
                    NetSalary = (decimal)1620.0
                },
                new EmployeeDTO(secondEmployee)
                {
                    NetSalary = (decimal)810.0
                },
                new EmployeeDTO(fourthEmployee)
                {
                    NetSalary = (decimal)810.0
                }
            };

            var employees = new List<Employee>()
            {
                firstEmployee,
                new() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                },
                secondEmployee,
                thirdEmployee,
                fourthEmployee
            };

            var testData = CalculatorTestUtility.PrepareTestData(employees);

            await calculator.PrepareData(testData);

            var result = calculator.GetTaxSalaryByCity();

            Assert.Equal(expected, result, new EmployeeComparer());
        }

    }
}
