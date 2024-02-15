USE AdventureWorks2019
GO
--Question 1
SELECT COUNT(ProductID)
FROM Production.Product

--Question 2
SELECT COUNT(ProductSubcategoryID)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--Question 3

SELECT DISTINCT pp.ProductSubcategoryID, COUNT(pp.ProductID) OVER(PARTITION BY pp.ProductSubcategoryID) CountedProducts
FROM Production.Product pp
WHERE pp.ProductSubcategoryID IS NOT NULL

--question 4

SELECT COUNT(pp.ProductID)
FROM Production.Product pp
WHERE pp.ProductSubcategoryID is NULL

--question 5
SELECT SUM(pp.Quantity)
FROM Production.ProductInventory pp

--question 6
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

--question 7

SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;

--question 8

SELECT AVG(Quantity) AS AvgQuantity
FROM Production.ProductInventory
WHERE LocationID=10

--question 9

SELECT pp.ProductID, pp.Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory pp
GROUP BY pp.ProductID, pp.Shelf

--question 10

SELECT pp.ProductID, pp.Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory pp
GROUP BY pp.ProductID, pp.Shelf
HAVING pp.shelf !='N/A'

--question 11
SELECT pp.Color, pp.Class, COUNT(ProductID) AS TheCount, AVG(pp.ListPrice)
FROM Production.Product pp
GROUP BY pp.color, pp.Class
HAVING pp.Color IS NOT NULL AND pp.Class IS NOT NULL
ORDER BY pp.Color

--question 12

SELECT PC.Name AS Country, PS.Name AS Province
FROM Person.CountryRegion PC LEFT JOIN Person.StateProvince PS ON PC.CountryRegionCode = PS.CountryRegionCode

--question 13
SELECT PC.Name AS Country, PS.Name AS Province
FROM Person.CountryRegion PC LEFT JOIN Person.StateProvince PS ON PC.CountryRegionCode = PS.CountryRegionCode
WHERE PC.Name IN('Germany','Canada')

--question 14-27

USE Northwind
GO
--question 14
SELECT DISTINCT p.ProductID, p.ProductName, p.UnitPrice
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID LEFT JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate>=DATEADD(YEAR,-26,GETDATE())


--question 15


SELECT TOP 5 p.ProductName,sum(od.Quantity) as countNum, o.ShipPostalCode
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID LEFT JOIN Orders o ON o.OrderID = od.OrderID
GROUP BY p.ProductName,o.ShipPostalCode
ORDER BY countNum DESC

--question 16
 
	SELECT TOP 5 p.ProductName,sum(od.Quantity) as countNum, o.ShipPostalCode
	FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID LEFT JOIN Orders o ON o.OrderID = od.OrderID
	WHERE o.OrderDate>=DATEADD(YEAR,-26,GETDATE())
	GROUP BY p.ProductName,o.ShipPostalCode
	ORDER BY countNum DESC

--question 17
	SELECT City, count(*) as NumOfCustomers
	FROM Customers
	GROUP BY City 
	ORDER BY NumOfCustomers DESC

--question 18
	SELECT City, count(*) as NumOfCustomers
	FROM Customers
	GROUP BY City 
	HAVING count(*)>2
	ORDER BY NumOfCustomers DESC	

--questino 19
	SELECT c.ContactName, o.OrderDate
	FROM Customers c LEFT JOIN Orders o ON o.CustomerID = c.CustomerID
	WHERE o.OrderDate>'1998-01-01'
	ORDER BY o.OrderDate DESC
--question 20
	SELECT c.ContactName, o.OrderDate
	FROM Customers c LEFT JOIN Orders o ON o.CustomerID = c.CustomerID
	ORDER BY o.OrderDate DESC
--question 21

	SELECT c.ContactName, sum(od.Quantity) as CountOfProducts
	FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] as od ON od.OrderID = o.OrderID
	GROUP BY c.ContactName
	ORDER BY CountOfProducts DESC

--question 22

	SELECT c.ContactName, sum(od.Quantity) as CountOfProducts
	FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] as od ON od.OrderID = o.OrderID
	GROUP BY c.ContactName
	HAVING sum(od.Quantity) >100
	ORDER BY CountOfProducts DESC

--question 23

	SELECT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
	FROM Suppliers su CROSS JOIN Shippers sh
	ORDER BY 1
	
--questino 24
	SELECT o.OrderDate, p.ProductName
	FROM Orders o LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID LEFT JOIN Products p ON p.ProductID = od.ProductID
	ORDER BY o.OrderDate DESC

--question 25
	SELECT e1.FirstName+' '+ e1.LastName AS Employee1, e2.FirstName+' '+ e2.LastName AS Employee1, e1.Title
	FROM Employees as e1 JOIN Employees as e2 ON e1.EmployeeID<e2.EmployeeID AND e1.Title = e2.title
	
--question 26
	SELECT e1.EmployeeID,e1.FirstName,e1.LastName, COUNT(*) AS Subordinate
	FROM Employees as e1 LEFT JOIN Employees as e2 ON e2.ReportsTo = e1.EmployeeID
	GROUP BY e1.EmployeeID,e1.FirstName,e1.LastName
	HAVING COUNT(*) >2
	
--question 27
	SELECT City,CompanyName,ContactName, 'Customer' AS Type
	FROM Customers 
	UNION
	SELECT City,CompanyName,ContactName, 'Suppliers' AS Type
	FROM Suppliers
	ORDER BY City
	
