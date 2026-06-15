USE CTS_Training;

SELECT * FROM Students;

SELECT FullName, Department
FROM Students;

SELECT *
FROM Students
WHERE CGPA > 8.5;

SELECT DISTINCT Department
FROM Students;

SELECT *
FROM Students
ORDER BY CGPA DESC;

SELECT *
FROM Students
ORDER BY CGPA DESC
LIMIT 3;

SELECT *
FROM Students
WHERE Department = 'Cyber Security';

SELECT *
FROM Students
WHERE CGPA >= 9.0;
