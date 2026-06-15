USE CTS_Training;

CREATE INDEX idx_department
ON Students(Department);

ALTER TABLE Students
ADD CONSTRAINT chk_cgpa
CHECK (CGPA >= 0 AND CGPA <= 10);

ALTER TABLE Courses
ADD CONSTRAINT unique_course
UNIQUE (CourseName);

SELECT *
FROM Students;

SELECT *
FROM Courses;
