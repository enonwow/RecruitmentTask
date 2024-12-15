CREATE PROCEDURE employee_lowesttaxsalarybycity
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Employee.*, empl.minSalary
	FROM Employee
		INNER JOIN (
		SELECT 
			MIN(Salary - Salary * 0.19) as minSalary,
			City
		FROM Employee
		Group by City) as empl
		ON empl.City = Employee.City and empl.minSalary = Employee.Salary - Employee.Salary * 0.19
		ORDER BY ID
END
GO
