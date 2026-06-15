USE CTS_Training;

SELECT FullName, CGPA
FROM Students
WHERE CGPA > (
    SELECT AVG(CGPA)
    FROM Students
);

SELECT FullName, Department
FROM Students
WHERE StudentID IN (
    SELECT StudentID
    FROM Enrollments
);

SELECT FullName, CGPA
FROM Students
WHERE CGPA = (
    SELECT MAX(CGPA)
    FROM Students
);
