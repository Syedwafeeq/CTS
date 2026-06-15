USE CTS_Training;

SELECT s.FullName, c.CourseName
FROM Students s
INNER JOIN Enrollments e
ON s.StudentID = e.StudentID
INNER JOIN Courses c
ON e.CourseID = c.CourseID;

SELECT s.FullName, c.CourseName
FROM Students s
LEFT JOIN Enrollments e
ON s.StudentID = e.StudentID
LEFT JOIN Courses c
ON e.CourseID = c.CourseID;

SELECT s.FullName, c.CourseName
FROM Students s
RIGHT JOIN Enrollments e
ON s.StudentID = e.StudentID
RIGHT JOIN Courses c
ON e.CourseID = c.CourseID;
