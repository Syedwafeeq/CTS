CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    Salary DECIMAL(10,2)
);

INSERT INTO Employees VALUES
(1, 'Amar', 60000),
(2, 'Akbar', 50000),
(3, 'Babar', 70000),
(4, 'Beerbal', 45000);

WITH HighSalaryEmployees AS
(
    SELECT EmployeeID, EmployeeName, Salary
    FROM Employees
    WHERE Salary > 55000
)
SELECT *
FROM HighSalaryEmployees;
