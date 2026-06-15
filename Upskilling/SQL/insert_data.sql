USE CTS_Training;

INSERT INTO Students
(StudentID, FullName, Email, Department, CGPA)
VALUES
(101, 'Rahul Sharma', 'rahul@example.com', 'Cyber Security', 8.75),
(102, 'Ananya Reddy', 'ananya@example.com', 'Computer Science', 9.10),
(103, 'Vikram Kumar', 'vikram@example.com', 'Information Technology', 8.45),
(104, 'Priya Singh', 'priya@example.com', 'Cyber Security', 9.25);

INSERT INTO Courses
(CourseID, CourseName, DurationWeeks)
VALUES
(1, 'HTML5 and CSS3', 4),
(2, 'JavaScript Fundamentals', 6),
(3, 'C# Programming', 8),
(4, 'SQL and Databases', 5);

INSERT INTO Enrollments
VALUES
(1, 101, 1),
(2, 101, 3),
(3, 102, 2),
(4, 103, 4);
