CREATE DATABASE Accounting_Software;

USE Accounting_Software;

CREATE TABLE Users
(
	User_Id INT IDENTITY(1, 1),
    User_Name VARCHAR(256) UNIQUE,
    User_Password VARCHAR(50),
    CONSTRAINT PK_Users PRIMARY KEY (User_Id)
);
INSERT INTO Users VALUES ('minahil', '01234');

CREATE TABLE Customers
(
	Customer_Id INT IDENTITY(1, 1),
	Customer_Name VARCHAR(256) UNIQUE,
	Customer_Phone VARCHAR(20) UNIQUE,
	Customer_Address VARCHAR(256),
	CONSTRAINT PK_Customers PRIMARY KEY (Customer_Id)
);

CREATE TABLE Vendors
(
	Vendor_Id INT IDENTITY(1, 1),
	Vendor_Name VARCHAR(256) UNIQUE,
	Vendor_Phone VARCHAR(20) UNIQUE,
	Vendor_Address VARCHAR(255),
	CONSTRAINT PK_Vendors PRIMARY KEY (Vendor_Id)
);

CREATE TABLE Products
(
	Product_Id INT IDENTITY(1, 1),
	Product_Name VARCHAR(256) UNIQUE,
	Product_Quantity VARCHAR(100),
	Product_Rate VARCHAR(100),
	Product_Description VARCHAR(256),
	CONSTRAINT PK_Products PRIMARY KEY (Product_Id)
);

CREATE TABLE Purchases
(
	Purchase_Id INT IDENTITY(1, 1),
	Purchase_Vendor_Id INT,
	Purchase_Date DATE,
	Purchase_Total_Product VARCHAR(100),
	Purchase_Grand_Total VARCHAR(100),
	Purchase_Status VARCHAR(20),
	CONSTRAINT PK_Purchases PRIMARY KEY (Purchase_Id),
	CONSTRAINT FK_Purchases FOREIGN KEY (Purchase_Vendor_Id) REFERENCES Vendors(Vendor_Id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Purchase_Products
(
	Purchase_Product_Id INT IDENTITY(1, 1),
	Purchase_Product_Purchase_Id INT,
	Purchase_Product_Product_Id INT,
	Purchase_Product_Quantity VARCHAR(100),
	Purchase_Product_Rate VARCHAR(100),
	CONSTRAINT PK_Purchase_Products PRIMARY KEY (Purchase_Product_Id),
	CONSTRAINT FK_1_Purchase_Products FOREIGN KEY (Purchase_Product_Purchase_Id) REFERENCES Purchases(Purchase_Id) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_2_Purchase_Products FOREIGN KEY (Purchase_Product_Product_Id) REFERENCES Products(Product_Id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Sales
(
	Sale_Id INT IDENTITY(1, 1),
	Sale_Customer_Id INT,
	Sale_Date DATE,
	Sale_Total_Product VARCHAR(100),
	Sale_Grand_Total VARCHAR(100),
	Sale_Status VARCHAR(20),
	CONSTRAINT PK_Sales PRIMARY KEY (Sale_Id),
	CONSTRAINT FK_Sales FOREIGN KEY (Sale_Customer_Id) REFERENCES Customers(Customer_Id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Sale_Products
(
	Sale_Product_Id INT IDENTITY(1, 1),
	Sale_Product_Sale_Id INT,
	Sale_Product_Product_Id INT,
	Sale_Product_Quantity VARCHAR(100),
	Sale_Product_Rate VARCHAR(100),
	CONSTRAINT PK_Sale_Products PRIMARY KEY (Sale_Product_Id),
	CONSTRAINT FK_1_Sale_Products FOREIGN KEY (Sale_Product_Sale_Id) REFERENCES Sales(Sale_Id) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_2_Sale_Products FOREIGN KEY (Sale_Product_Product_Id) REFERENCES Products(Product_Id) ON UPDATE CASCADE ON DELETE CASCADE
);

SELECT Purchase_Id, Purchase_Date, Vendor_Name, Vendor_Phone, Purchase_Total_Product, Purchase_Grand_Total FROM Vendors INNER JOIN Purchases ON Vendor_Id = Purchase_Vendor_Id;
SELECT Sale_Id, Sale_Date, Customer_Name, Customer_Phone, Sale_Total_Product, Sale_Grand_Total FROM Customers INNER JOIN Sales ON Customer_Id = Sale_Customer_Id;
SELECT Product_Name, Purchase_Product_Quantity, Purchase_Product_Rate FROM Products INNER JOIN Purchase_Products ON Product_Id = Purchase_Product_Product_Id WHERE Purchase_Product_Purchase_Id = 1;
SELECT Product_Name, Sale_Product_Quantity, Sale_Product_Rate FROM Products INNER JOIN Sale_Products ON Product_Id = Sale_Product_Product_Id WHERE Sale_Product_Sale_Id = 1;
SELECT Purchase_Id, Purchase_Date, Vendor_Name, Vendor_Phone FROM Vendors INNER JOIN Purchases ON Vendor_Id = Purchase_Vendor_Id WHERE Vendor_Name LIKE '%Ahmar%' OR Purchase_Id LIKE '%4%' OR Purchase_Date LIKE '%2022/01/25%' OR Vendor_Phone LIKE '%+92 300 6652714%';
SELECT Sale_Id, Sale_Date, Customer_Name, Customer_Phone FROM Customers INNER JOIN Sales ON Customer_Id = Sale_Customer_Id WHERE Customer_Name LIKE '%Ahmar%' OR Customer_Id LIKE '%4%' OR Sale_Date LIKE '%2022/01/25%' OR Customer_Phone LIKE '%+92 300 6652714%';

SELECT * FROM Users;
SELECT * FROM Customers;
SELECT * FROM Vendors;
SELECT * FROM Products;
SELECT * FROM Purchase_Products;
SELECT * FROM Purchases;
SELECT * FROM Sale_Products;
SELECT * FROM Sales;

DROP TABLE Users;
DROP TABLE Customers;
DROP TABLE Purchase_Products;
DROP TABLE Sale_Products;
DROP TABLE Products;
DROP TABLE Purchases;
DROP TABLE Sales;
DROP TABLE Vendors;

DROP DATABASE Accounting_Software;