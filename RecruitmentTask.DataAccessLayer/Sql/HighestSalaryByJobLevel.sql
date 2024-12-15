CREATE PROCEDURE employee_highestsalarybyjoblevel
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM Employee
		INNER JOIN (
		SELECT 
			MAX(Salary) as maxSalary,
			JobLevel
		FROM Employee
		Group by JobLevel) as empl
		ON empl.JobLevel = Employee.JobLevel and empl.maxSalary = Employee.Salary
		ORDER BY ID;
END
GO
