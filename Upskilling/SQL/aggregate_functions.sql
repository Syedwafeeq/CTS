USE CTS_Training;

SELECT COUNT(*) AS TotalStudents
FROM Students;

SELECT AVG(CGPA) AS AverageCGPA
FROM Students;

SELECT MAX(CGPA) AS HighestCGPA
FROM Students;

SELECT MIN(CGPA) AS LowestCGPA
FROM Students;

SELECT SUM(CGPA) AS TotalCGPA
FROM Students;

SELECT Department, COUNT(*) AS StudentCount
FROM Students
GROUP BY Department;

SELECT Department, AVG(CGPA) AS AverageCGPA
FROM Students
GROUP BY Department
HAVING AVG(CGPA) > 8.5;
