CREATE DATABASE university

USE university

CREATE TABLE students(
	Admission_no INT PRIMARY KEY
	,First_name NVARCHAR(25)
	,Last_name NVARCHAR(25)
	,City NVARCHAR(25)
)

CREATE TABLE fee(
	Admission_no INT FOREIGN KEY REFERENCES students(Admission_no)
	,Course NVARCHAR(25)
	,Amount_paid INT
)

INSERT INTO students
VALUES 
			(3354,'Георги', 'Георгиев', 'Варна')
			,(4321,'Милена', 'Красимирова', 'Стара Загора')
			,(8345,'Михаил', 'Мартинов', 'Пловдив')
			,(7555,'Антонио', 'Тачев', 'Стара Загора')
			,(2135,'Мартин', 'Иванов', 'София')

INSERT INTO fee
VALUES
			(3354, 'Java', 2000)
			,(7555, 'C#', 1800)
			,(4321, 'SQL', 1600)
			,(4321, 'Java', 2000)
			,(8345, 'C++', 1700)

SELECT City FROM students WHERE Admission_no = 8345

SELECT AVG(Amount_paid) AS [Average Amount Paid] FROM fee

UPDATE fee
SET Course = 'Java'
WHERE Amount_paid = 1800

SELECT Course, COUNT(Admission_no) FROM fee GROUP BY Course

SELECT
	First_name
	,Last_name
	,Course
FROM students s
	JOIN fee f ON f.Admission_no = s.Admission_no
