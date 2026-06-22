CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    ManagerID INT
);

INSERT INTO Employees VALUES
(1,'Wafeeq',NULL),
(2,'Syed',1),
(3,'Ravi',1),
(4,'Dhanush',2);

SELECT
    E.EmployeeName AS Employee,
    M.EmployeeName AS Manager
FROM Employees E
LEFT JOIN Employees M
ON E.ManagerID = M.EmployeeID;
