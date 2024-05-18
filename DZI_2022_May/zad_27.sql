
--�������� ���� ����� �� ������ ������� �� �������, ��������� ������� laptops ��� �������� ��������:
--ID � AutoNumber, PK;
--����� � Text;
--����� � Text;
--��������� � Number;
--���� � Currency;
CREATE DATABASE OnlineTechShop

USE OnlineTechShop

--1. ������ �� ��������� �� ��������� laptops.
CREATE TABLE laptops
(
	ID INT PRIMARY KEY IDENTITY
	,����� NVARCHAR(255)
	,����� NVARCHAR(255)
	,��������� INT 
	,���� DECIMAL(18,2)
)

--2. ��� ������, ����� �������� � ��������� �������� �������:
INSERT INTO laptops
VALUES
		('Laptop1', 'L29KAS', 10, 1100)
		,('Laptop2', '15FDR7', 14, 1350)
		,('Laptop1', 'L29GTA', 12, 1500)
		,('Laptop1', 'L29DFT', 8, 1499)
		,('Laptop2', '15FDM5', 11, 1600)

--3. ������, ����� �� ������� ������� �� ����� ������ � 15FDR7.
DELETE FROM laptops
WHERE ����� = '15FDR7'

--4. ������, ����� ������� ������ ���� (���������*����), � �������� ��� --		�������� (20%) ��� ������, �� ������ ������.SELECT 
	��������� * (���� * 1.2) AS [���� ����]
FROM laptops

--5. ������, ����� ������ ����� �� ������ ����������, �� ������� ������� � Laptop1.SELECT 
	COUNT(*) AS [���� ������� �������]
FROM laptops
WHERE ����� = 'Laptop1'

