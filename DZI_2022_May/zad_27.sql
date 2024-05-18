
--Създайте База данни на онлайн магазин за техника, съдържаща таблица laptops със следните атрибути:
--ID – AutoNumber, PK;
--Марка – Text;
--Модел – Text;
--Наличност – Number;
--Цена – Currency;
CREATE DATABASE OnlineTechShop

USE OnlineTechShop

--1. Заявка за създаване на таблицата laptops.
CREATE TABLE laptops
(
	ID INT PRIMARY KEY IDENTITY
	,Марка NVARCHAR(255)
	,Модел NVARCHAR(255)
	,Наличност INT 
	,Цена DECIMAL(18,2)
)

--2. Пет заявки, които зареждат в таблицата следните кортежи:
INSERT INTO laptops
VALUES
		('Laptop1', 'L29KAS', 10, 1100)
		,('Laptop2', '15FDR7', 14, 1350)
		,('Laptop1', 'L29GTA', 12, 1500)
		,('Laptop1', 'L29DFT', 8, 1499)
		,('Laptop2', '15FDM5', 11, 1600)

--3. Заявка, която да изтрива данните за модел лаптоп – 15FDR7.
DELETE FROM laptops
WHERE Модел = '15FDR7'

--4. Заявка, която извежда общата сума (наличност*цена), с добавена ДДС --		стойност (20%) към цената, за всички модели.SELECT 
	Наличност * (Цена * 1.2) AS [Обща сума]
FROM laptops

--5. Заявка, която намира броят на всички наличности, от марката лаптопи – Laptop1.SELECT 
	COUNT(*) AS [Брой налични лаптопи]
FROM laptops
WHERE Марка = 'Laptop1'

