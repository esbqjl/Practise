USE AdventureWorks2019
GO
--Question 1
	SELECT ProductID, Name, Color,ListPrice
	FROM Production.Product

--Question 2
	SELECT ProductID, Name, Color,ListPrice
	FROM Production.Product
	WHERE ListPrice !=0

--Quesiton 3
	SELECT ProductID, Name, Color,ListPrice
	FROM Production.Product
	WHERE color is NULL

--Question 4
	SELECT ProductID, Name, Color,ListPrice
	FROM Production.Product
	WHERE color is NOT NULL

--Question 5
	SELECT ProductID, Name, Color,ListPrice
	FROM Production.Product
	WHERE color is NOT NULL AND ListPrice >0

--Question 6
	SELECT Name + ' ' +color AS [Name and Color]
	FROM Production.Product
	WHERE color is NOT NULL

--Question 7
	SELECT 'NAME: '+ Name + ' -- COLOR: ' +color AS [Name and Color]
	FROM Production.Product
	WHERE color is NOT NULL

--Question 8
	SELECT ProductID, Name
	FROM Production.Product
	WHERE ProductID BETWEEN 400 and 500

--QUESTION 9
	SELECT ProductID,Name, Color
	FROM Production.Product
	WHERE Color in ('black','blue')
--Question 10
	SELECT * 
	FROM Production.Product
	WHERE Name LIKE 's%'

--Question 11
	SELECT Name, ListPrice
	FROM Production.Product
	WHERE Name LIKE 's%'
	ORDER BY 1 

--Question 12
	SELECT Name, ListPrice
	FROM Production.Product
	WHERE Name LIKE '[A,S]%'
	ORDER BY 1 

--Question 13
	SELECT Name, ListPrice
	FROM Production.Product
	WHERE Name LIKE 'SPO[^K]%'
	ORDER BY 1 

--Question 14
	SELECT DISTINCT color
	FROM Production.Product
	ORDER BY 1

--Question 15
	SELECT DISTINCT ProductSubcategoryID, Color
	FROM Production.Product
	WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
	ORDER BY ProductSubcategoryID, Color
