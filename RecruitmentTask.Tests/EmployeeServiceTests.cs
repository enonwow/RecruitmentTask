using Moq;
using RecruitmentTask.BuisnessLayer;
using RecruitmentTask.BuisnessLayer.Models;
using RecruitmentTask.DataAccessLayer;
using RecruitmentTask.DataAccessLayer.Abstractions;
using RecruitmentTask.Tests.Comparers;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class EmployeeServiceTests
    {
        [Fact]
        public async Task EmployeeService_GetAll_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();
            employeeRepositoryMock
                .Setup(r => r.GetAllEmployeesAsync(It.IsAny<Stream>()))
                .Returns(EmployeeServiceTestUtility.CreateMockIAsyncEnumerable());

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var resultAsync = employeeService.GetAllEmployeesAsync(null);
            var result = await resultAsync.ToListAsync();
            var firstResult = result.First();

            Assert.NotNull(firstResult);
            Assert.Single(result);
            Assert.Equal(1, firstResult.Id);
            Assert.Equal("Mateusz", firstResult.Name);
            Assert.Equal("Test", firstResult.Surname);
            Assert.Equal("Warszawa", firstResult.City);
            Assert.Equal((decimal)1000, firstResult.Salary);
            Assert.Equal("S1", firstResult.JobLevel);
            Assert.Null(firstResult.NetSalary);
        }
    }

    public class EmployeeServiceTests_GetHighestSalaryByCity
    {
        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_LowerFirst_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(new Employee {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetHighestSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_Multiple_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee),
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetHighestSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_LowerSecond_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                })
            };

            var result = employeeService.GetHighestSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var firstEmployee = EmployeeServiceTestUtility.CreateMockEmployee();

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

            var employees = new List<EmployeeDTO>()
            {
                new(firstEmployee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(secondEmployee),
                new(thirdEmployee),
                new(fourthEmployee)
            };

            var result = employeeService.GetHighestSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }
    }

    public class EmployeeServiceTests_RulerHighestSalaryByJobLevel()
    {
        [Fact]
        public void EmployeeService_RulerHighestSalaryByJobLevel_LowerFirst_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(new Employee() 
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetHighestSalaryByJobLevel(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_RulerHighestSalaryByJobLevel_Multiple_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee),
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee() {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetHighestSalaryByJobLevel(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_RulerHighestSalaryByJobLevel_LowerSecond_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
            };

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                })
            };

            var result = employeeService.GetHighestSalaryByJobLevel(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var firstEmployee = EmployeeServiceTestUtility.CreateMockEmployee();
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

            var employees = new List<EmployeeDTO>()
            {
                new(firstEmployee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 1000,
                    JobLevel = "S1"
                }),
                new(secondEmployee),
                new(thirdEmployee),
                new(fourthEmployee)
            };

            var result = employeeService.GetHighestSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }
    }

    public class EmployeeServiceTests_RulerTaxSalaryByCity
    {
        [Fact]
        public void EmployeeService_GetTaxSalaryByCity_LowerFirst_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                }
            };

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                }),
            };

            var result = employeeService.GetTaxSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetTaxSalaryByCity_Multiple_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

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

            var employees = new List<EmployeeDTO>()
            {
                new(employee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetTaxSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetTaxSalaryByCity_LowerSecond_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var employee = EmployeeServiceTestUtility.CreateMockEmployee();

            var expected = new List<EmployeeDTO>()
            {
                new EmployeeDTO(employee)
                {
                    NetSalary = (decimal)1620.0
                }
            };

            var employees = new List<EmployeeDTO>()
            {
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                }),
                new(employee)
            };

            var result = employeeService.GetTaxSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }

        [Fact]
        public void EmployeeService_GetHighestSalaryByCity_Successful()
        {
            var employeeRepositoryMock = new Mock<IEmployeeRepository>();

            var employeeService = new EmployeeService(employeeRepositoryMock.Object);
            var firstEmployee = EmployeeServiceTestUtility.CreateMockEmployee();
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

            var employees = new List<EmployeeDTO>()
            {
                new(firstEmployee),
                new(new Employee()
                {
                    Id = 1,
                    Name = "Mateusz",
                    Surname = "Test",
                    City = "Warszawa",
                    Salary = 3000,
                    JobLevel = "S1"
                }),
                new(secondEmployee),
                new(thirdEmployee),
                new(fourthEmployee)
            };

            var result = employeeService.GetTaxSalaryByCity(employees);

            Assert.Equal(expected, result, new EmployeeComparer());
        }
    }
}
