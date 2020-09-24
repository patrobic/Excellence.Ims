use master
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'LEDExcellence')
BEGIN
	ALTER DATABASE [LEDExcellence] SET single_user WITH ROLLBACK IMMEDIATE
	DROP DATABASE [LEDExcellence]
END
GO

CREATE DATABASE [LEDExcellence]
GO

USE [LEDExcellence]

-- CREATE TABLE PieceReference (
-- 	ID int IDENTITY(1,1) PRIMARY KEY,
-- 	ReferenceName varchar(64),
-- 	ReferencePath varchar(255),
-- );
-- CREATE TABLE Defect (
-- 	ID int PRIMARY KEY,
-- 	DefectName varchar(64) UNIQUE,
-- );
-- CREATE TABLE SubDefect (
-- 	ID int IDENTITY(1,1) PRIMARY KEY,
-- 	DefectID int NOT NULL,
-- 	SubDefectNum int NOT NULL,
-- 	SubDefectName varchar(64)
-- 	CONSTRAINT FK_DefectID FOREIGN KEY (DefectID)
-- 	REFERENCES Defect(ID),
-- );

-- Inventory

CREATE TABLE Item (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	
	);
	
CREATE TABLE Product (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	
	);

CREATE TABLE Item_Product (
	ID int NOT NULL PRIMARY KEY,
	Item_FK int FOREIGN KEY REFERENCES Item(ID),
	Product_FK int FOREIGN KEY REFERENCES Product(ID),
	Quantity int NOT NULL,
	);
	
-- Attributes

CREATE TABLE Attribute_Value (
	ID int NOT NULL PRIMARY KEY,
	
	);
	
CREATE TABLE Attribute_Category (
	ID int NOT NULL PRIMARY KEY,
	
	);
	
CREATE TABLE Product_Attribute (
	ID int NOT NULL PRIMARY KEY,
	
	);

-- Purchasing

CREATE TABLE PurchaseOrder (
	ID int NOT NULL PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	OrderDate datetime NOT NULL,

	);
	
CREATE TABLE Purchase_Line (
	ID int NOT NULL PRIMARY KEY,
	PO_FK int NOT NULL FOREIGN KEY REFERENCES PurchaseOrder(ID),
	Item_FK int NOT NULL FOREIGN KEY REFERENCES Item(ID),
	Quantity int NOT NULL,
	
	);
	
CREATE TABLE Supplier (
	ID int NOT NULL PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	
	);
	
-- Manufacturing

CREATE TABLE ManufactureOrder (
	ID int NOT NULL PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	OrderDate datetime NOT NULL,
	);
	
CREATE TABLE Manufacture_Line (
	ID int NOT NULL PRIMARY KEY,
	MO_FK int NOT NULL FOREIGN KEY REFERENCES ManufactureOrder(ID),
	Product_FK int NOT NULL FOREIGN KEY REFERENCES Product(ID),
	Quantity int NOT NULL,

	);

-- Sales

CREATE TABLE SalesOrder (
	ID int NOT NULL PRIMARY KEY,
	Title varchar(64) NOT NULL,
	Description varchar(255),
	OrderDate datetime NOT NULL,
	
	);
	
CREATE TABLE Sales_Line (
	ID int NOT NULL PRIMARY KEY,
	SO_FK int NOT NULL FOREIGN KEY REFERENCES SalesOrder(ID),
	Product_FK int NOT NULL FOREIGN KEY REFERENCES Product(ID),
	Quantity int NOT NULL,

	);
	
CREATE TABLE Client (
	ID int NOT NULL PRIMARY KEY,
	
	);
	
-- Category

CREATE TABLE Category (
	ID int NOT NULL PRIMARY KEY,
	
	);
	
CREATE TABLE Subcategory (
	ID int NOT NULL PRIMARY KEY,
	
	);
	
CREATE TABLE Item_SubCategory (
	ID int NOT NULL PRIMARY KEY,
	
	);
