CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DOB DATE,
    Gender CHAR(1) -- 'M' for Male, 'F' for Female
);

CREATE TABLE Exam (
    ExamID INT PRIMARY KEY,
    Subject VARCHAR(100),
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


INSERT INTO Student (StudentID, FirstName, LastName, DOB, Gender)
VALUES
(1, 'John', 'Doe', '2000-05-14', 'M'),
(2, 'Jane', 'Smith', '1999-07-22', 'F'),
(3, 'Sam', 'Wilson', '2001-01-10', 'M'),
(4, 'Emily', 'Brown', '2000-12-05', 'F');


INSERT INTO Exam (ExamID, Subject, ExamDate)
VALUES
(1, 'Mathematics', '2023-06-10'),
(2, 'Physics', '2023-06-11'),
(3, 'Chemistry', '2023-06-12');


INSERT INTO StudentExam (StudentExamID, StudentID, ExamID, Score)
VALUES
(1, 1, 1, 85.5),
(2, 1, 2, 90.0),
(3, 2, 1, 88.0),
(4, 3, 3, 76.5),
(5, 4, 2, 92.0);


select * from Student;

select * from Exam;

select * from StudentExam;

/* List all students who scored more than 80 in any exam. */

select s.FirstName, se.Score from Student s join StudentExam se on s.StudentID = se.StudentID where se.Score>80;

/*Find the average score for each exam.*/

SELECT E.Subject, AVG(SE.Score) AS AvgScore
FROM Exam E
JOIN StudentExam SE ON E.ExamID = SE.ExamID
GROUP BY E.Subject;

/*  List students who have not taken any exams.  */


select s.FirstName from Student s left join StudentExam sx on s.StudentID=sx.StudentID where sx.StudentID is NULL;

/*  Find the highest score achieved in each exam. */

select e.subject,MAX(se.score) as HighestScore
From Exam e
join StudentExam se on e.ExamID=se.ExamID
group by e.Subject;

/* List students who took the 'Mathematics' exam and their scores.  */

SELECT S.FirstName, S.LastName, SE.Score
FROM Student S
JOIN StudentExam SE ON S.StudentID = SE.StudentID
JOIN Exam E ON SE.ExamID = E.ExamID
WHERE E.Subject = 'Mathematics';

