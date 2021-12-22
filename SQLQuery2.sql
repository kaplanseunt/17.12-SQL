
--Select		yorum satırı

--Select ContactName, City, CompanyName  from Customers

--Select ContactName Adi, City Sehir, CompanyName SirketAdi  from Customers		--belirttigim şekilde getirir.

--Select * from Customers where City = 'London'

-- case insensitive
--sElEct * from Products where CategoryID = 1 or CategoryID=2

--sElEct * from Products where CategoryID = 1 and UnitPrice<10

-- select * from Products order by ProductName

--select * from Products order by CategoryID,ProductName

--select * from Products order by UnitPrice asc  --ascending, dsc descending de düşen sırada dizer


select count(*) from Products   -- sayar

select count(*) from Products where CategoryID=2	 

select categoryID, count(*) from products group by CategoryID 		---her bir kategoride o kadar ürün var

select categoryID, count(*) from products group by CategoryID  having count(*)<10

select categoryID, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID			--on şart demek

-- DTO data transformation object
															--inner join tabloları birleştirir
select * from Products p left join [Order Details] od		--left join solda olup sağda olmayanları da ekle 
on p.ProductID = od.ProductID			

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID							--siparis vermeyen 2 firmayı bulduk
where o.CustomerID is null

