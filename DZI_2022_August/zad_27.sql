
--27.Create database
CREATE DATABASE School_DZI_2022_August

USE School_DZI_2022_August

--27.1 Create table Students
CREATE TABLE Students(
	ID INT PRIMARY KEY
	,[Name] NVARCHAR(100)
	,BEL INT
	,English INT
	,Math INT
	,Informatics INT
	,IT INT
)

--27.2 Insert values into table Students
INSERT INTO Students(ID, [Name], BEL, English, Math, Informatics, IT)
	VALUES
					(1, 'Антония Колева', 4, 5, 6, 5, 4)
				    ,(2, 'Асен Ангелов', 5, 5, 6, 4, 5)
				    ,(3, 'Борислав Ганев', 4, 4, 5, 5, 6)
				    ,(4, 'Бояна Тодорова', 5, 6, 6, 6, 6)
					,(5, 'Валери Илиев', 6, 6, 6, 6, 6)

--27.3 Full info about student with ID 4
SELECT * FROM Students
WHERE ID = 4

--27.4 Count of students who have excellent grade in Math, Informatics and IT
SELECT COUNT(*) FROM Students
WHERE Math = 6 AND Informatics = 6 AND IT = 6

--27.5 Average grade(BEL and Math)
SELECT
	AVG(BEL) AS AverageGradeBEL
   ,AVG(Math) AS AverageGradeMath 
FROM Students

--27.6 Name and average grade for every student ordered by the average grade descending then by name alphabetically
SELECT
	[Name]
	,(BEL + English + Math + Informatics + IT) / 5 AS AverageGrade
FROM Students
ORDER BY AverageGrade DESC, [Name] 
