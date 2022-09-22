CREATE DATABASE ShopDB
ON
(
	NAME = 'ShopDB',
	FILENAME = 'C:\Julian\UserDatabases\ShopDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogShopDB',
	FILENAME = 'C:\Julian\UserDatabases\ShopDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

USE ShopDB
GO

CREATE TABLE Products
(
	ProdId int NOT NULL PRIMARY KEY,
	ProdName varchar(40) NOT NULL
)
GO

CREATE TABLE Categories
(
	CategId int NOT NULL PRIMARY KEY,
	CategName varchar(40)
)
GO

CREATE TABLE ProductsCategories
(
	ProdId int NOT NULL
		FOREIGN KEY REFERENCES Products(ProdId),
	CategId int NOT NULL
		FOREIGN KEY REFERENCES Categories(CategId),
	PRIMARY KEY(ProdId, CategId)
)
GO

INSERT INTO Products
(ProdId, ProdName)
VALUES
(1, 'Coca Cola'),
(2, 'Сок "Добрый" яблочный'),
(3, 'Сок "Добрый" апельсиновый'),
(4, 'Кефир "Простоквашино" 2,5%'),
(5, 'Молоко "Домик в деревне" 3,2%'),
(6, 'Пиво безалкогольное "Amstel 0.0"'),
(7, 'Пиво тёмное "PAULANER Weissbier Dunkel"');

INSERT INTO Categories
(CategId, CategName)
VALUES
(1, 'Товары по акции'),
(2, 'Алкогольные напитки'),
(3, 'Пиво'),
(4, 'Кисломолочные напитки');

INSERT INTO ProductsCategories
(ProdId, CategId)
VALUES
(1,1),
(4,1),
(4,4),
(5,4),
(6,3),
(7,1),
(7,2),
(7,3);

--SELECT * FROM Products
--SELECT * FROM ProductsCategories
--SELECT * FROM Categories

-----SQL-запрос для выбора всех пар "имя продукта - имя категории"----

SELECT ProdName, CategName FROM Products
	LEFT JOIN ProductsCategories
		ON Products.ProdId = ProductsCategories.ProdId
	LEFT JOIN Categories
		ON ProductsCategories.CategId = Categories.CategId;
GO