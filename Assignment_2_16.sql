USE Northwind
GO
--question 1
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City IN (

	SELECT e.City
	FROM Employees e

)
--question 2
--a
	SELECT DISTINCT c.City
	FROM Customers c
	WHERE c.City NOT IN (

		SELECT e.City
		FROM Employees e

	)
--b
	SELECT DISTINCT c.City
	FROM Customers c LEFT JOIN Employees e ON c.city = e.City
	WHERE e.city IS NULL
--question 3
	SELECT p.ProductID,p.ProductName,p.UnitPrice,SUM(od.Quantity) AS [Total Order Quantity]
	FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
	GROUP BY p.ProductID,p.ProductName,p.UnitPrice

--question 4
	SELECT c.City, SUM(od.Quantity)
	FROM Customers c LEFT JOIN Orders o On c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID
	GROUP BY c.City
--question 5
	--a.
	SELECT City, COUNT(*)/2 AS NumOfCustomers
	FROM (
		SELECT City FROM Customers
		UNION ALL
		SELECT City FROM Customers
	) AS CombinedCities
	GROUP BY City
	HAVING COUNT(*) >= 4;



	--b.
	SELECT * FROM(
	SELECT City, count(*) AS NumOfCustomers
	FROM Customers
	GROUP BY City) AS CityCounts
	WHERE NumOfCustomers >=2
--question 6
	SELECT dt.city, COUNT(*)
	FROM(
	SELECT DISTINCT c.City,od.ProductID
	FROM Customers c LEFT JOIN Orders o On c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID
	) AS dt
	GROUP BY dt.City
	
--question 7
	SELECT DISTINCT c.ContactName, c.CustomerID, c.City,o.ShipCity
	FROM Customers c LEFT JOIN Orders o On c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID
	WHERE c.City != o.ShipCity

--question 8
	
	WITH ProductTotals AS (
    SELECT od.ProductID, SUM(od.Quantity) AS TotalQuantity
    FROM [Order Details] od
    GROUP BY od.ProductID
	),
	CityQuantities AS (
		SELECT 
			od.ProductID, 
			c.City, 
			SUM(od.Quantity) AS CityQuantity,
			ROW_NUMBER() OVER (PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS rn
		FROM [Order Details] od
		JOIN Orders o ON o.OrderID = od.OrderID
		JOIN Customers c ON c.CustomerID = o.CustomerID
		GROUP BY od.ProductID, c.City
	)
	SELECT TOP 5 
		pt.ProductID, 
		p.ProductName, 
		pt.TotalQuantity, 
		AVG(p.UnitPrice) AS AvgPrice, 
		cq.City, 
		cq.CityQuantity
	FROM ProductTotals pt
	JOIN Products p ON pt.ProductID = p.ProductID
	JOIN CityQuantities cq ON pt.ProductID = cq.ProductID AND cq.rn = 1
	GROUP BY pt.ProductID, p.ProductName, pt.TotalQuantity, cq.City, cq.CityQuantity
	ORDER BY pt.TotalQuantity DESC;
--quesiton 9

	--a
	
	
	
	SELECT City
	FROM Employees
	WHERE City NOT IN(
	
	SELECT DISTINCT c.City
	FROM orders o LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
	)
	
	--b
	SELECT e.City
	FROM Employees e LEFT JOIN Customers c ON e.City= c.City LEFT JOIN Orders o ON o.CustomerID = c.CustomerID
	WHERE c.city IS NULL

--10
	WITH sTheMost AS (
		SELECT TOP 1 c.city,Count(o.OrderID) AS TotalOrders
		FROM Orders o LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
		GROUP BY c.City
		ORDER BY TotalOrders DESC
	),
	oTheMost AS (
		SELECT TOP 1 c.city,SUM(od.Quantity) AS TotalQuantity
		FROM Orders o LEFT JOIN Customers c ON o.CustomerID = c.CustomerID LEFT JOIN [Order Details] od ON od.OrderID=o.OrderID
		GROUP BY c.City
		ORDER BY TotalQuantity DESC
		
	)
	SELECT sTheMost.City, oTheMost.TotalQuantity, sTheMost.TotalOrders
	FROM sTheMost INNER JOIN oTheMost ON sTheMost.City = oTheMost.City
	
	
--11
--DISTINCT will be a good way to solve duplicated records
	
	
	

	
	