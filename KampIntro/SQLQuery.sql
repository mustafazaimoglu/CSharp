--NORTHWIND

--SELECT ContactName Adi,CompanyName SirketAdi,City Sehir FROM Customers 
-- alias - takma ad (ContactName Adi)

--SELECT * FROM Customers where City = 'Berlin'

-- Case Insensitive
--SELECT * FROM Products WHERE CategoryID = 16 or caTegoryID = 3;

--SELECT * FROM Products WHERE CategoryID = 16 or UnitPrice >= 100;

--SELECT * FROM PRODUCTS ORDER BY UNITPRICE ASC -- Sıralama ASCENDING ARTAN DEFAULT

--SELECT * FROM PRODUCTS ORDER BY UNITPRICE DESC -- Sıralama DESCENDING DUSEN

--SELECT * FROM PRODUCTS WHERE CATEGORYID = 2 ORDER BY UNITPRICE DESC

--SELECT COUNT(*) ADET FROM PRODUCTS WHERE CATEGORYID = 2;

-- HANGİ KATEGORİDE KAÇ FARKLI ÜRÜNÜMÜZ VAR?
--SELECT CATEGORYID KATEGORI,COUNT(*) Urun_sayisi FROM PRODUCTS WHERE UNITPRICE > 20 GROUP BY CATEGORYID HAVING COUNT(*) < 10 
-- Group By larda having kullanılabilir.

-- Inner Join her ikisindede eşleşirse getirir
--SELECT Products.CategoryID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
--FROM PRODUCTS INNER JOIN CATEGORIES ON PRODUCTS.CategoryID = Categories.CategoryID 
--WHERE Products.UnitPrice > 10 ORDER BY Products.UnitPrice; -- Birleştirme Yaptık

-- DTO Data Transformation Object

-- LEFT JOIN SOLDA OLUP SAĞDA OLMAYANLARI DA GETİR
--SELECT * FROM Products p lEFT JOIN [ORDER DETAILS] od on p.ProductID = od.ProductId;
-- Tablo ismini doğru anlaması için köşeli parantez kullanırız

SELECT * FROM Customers c LEFT JOIN Orders o on c.CustomerID = o.CustomerID WHERE o.CustomerID IS NULL;