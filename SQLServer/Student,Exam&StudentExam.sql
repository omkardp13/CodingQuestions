
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Gender CHAR(1) -- 'M' or 'F'
);


CREATE TABLE Exam (
    ExamID INT PRIMARY KEY,
    ExamName NVARCHAR(100),
    ExamDate DATE
);



CREATE TABLE StudentExam (
    StudentExamID INT PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    Score DECIMAL(5, 2),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (ExamID) REFERENCES Exam(ExamID)
);



INSERT INTO Student (StudentID, FirstName, LastName, DateOfBirth, Gender) 
VALUES 
(1, 'John', 'Doe', '2001-04-23', 'M'),
(2, 'Jane', 'Smith', '2002-07-19', 'F'),
(3, 'Robert', 'Williams', '2001-11-05', 'M');



INSERT INTO Exam (ExamID, ExamName, ExamDate)
VALUES 
(101, 'Math', '2024-05-15'),
(102, 'Physics', '2024-06-01'),
(103, 'Chemistry', '2024-06-10');


INSERT INTO StudentExam (StudentExamID, StudentID, ExamID, Score)
VALUES 
(1, 1, 101, 85.5),
(2, 2, 101, 90.0),
(3, 1, 102, 78.0),
(4, 3, 101, 67.0),
(5, 3, 103, 72.0);


/* List all students who took a specific exam (e.g., Math)  */

select * from Exam;

SELECT S.FirstName, S.LastName, SE.Score
FROM Student S
JOIN StudentExam SE ON S.StudentID = SE.StudentID
JOIN Exam E ON SE.ExamID = E.ExamID
WHERE E.ExamName  = 'Math';


/* Find the average score of all students in the Physics exam */


SELECT AVG(SE.Score) AS AvgScore
FROM StudentExam SE
JOIN Exam E ON SE.ExamID = E.ExamID
WHERE E.ExamName  = 'Physics';

/* Find the top scorer for each exam */


SELECT E.ExamName, S.FirstName, S.LastName, SE.Score
FROM StudentExam SE
JOIN Student S ON SE.StudentID = S.StudentID
JOIN Exam E ON SE.ExamID = E.ExamID
WHERE SE.Score = (
    SELECT MAX(SE2.Score)
    FROM StudentExam SE2
    WHERE SE2.ExamID = SE.ExamID
);


/* List all students who scored below 70 in any exam */


SELECT S.FirstName, S.LastName, SE.Score
FROM Student S
JOIN StudentExam SE ON S.StudentID = SE.StudentID
WHERE SE.Score < 70;

/* Count the number of students who took each exam */


SELECT E.ExamName, COUNT(SE.StudentID) AS StudentCount
FROM Exam E
LEFT JOIN StudentExam SE ON E.ExamID = SE.ExamID
GROUP BY E.ExamName;


/*
Query: Find students who haven't taken any exam */

SELECT S.FirstName, S.LastName
FROM Student S
LEFT JOIN StudentExam SE ON S.StudentID = SE.StudentID
WHERE SE.StudentID IS NULL;

/*
Query: Find the average score of students by gender  */


SELECT S.Gender, AVG(SE.Score) AS AvgScore
FROM Student S
JOIN StudentExam SE ON S.StudentID = SE.StudentID
GROUP BY S.Gender;


/*
Query: Find all students born after the year 2002  */

SELECT FirstName, LastName, DateOfBirth
FROM Student
WHERE DateOfBirth > '2002-01-01';


