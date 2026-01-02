CREATE DATABASE IF NOT EXISTS shopdb;
USE shopdb;

-- 1. Inventory Table
CREATE TABLE Colognes (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Brand VARCHAR(50),
    Name VARCHAR(50),
    Price DECIMAL(10, 2),
    ImagePath TEXT,
    Stock INT
);

-- 2. Customers Table
CREATE TABLE Customers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(100),
    Phone VARCHAR(20)
);

-- 3. Orders Tablecolognes
CREATE TABLE Orders (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CustomerName VARCHAR(50),
    ProductName VARCHAR(50),
    Quantity INT,
    TotalPrice DECIMAL(10, 2),
    OrderDate DATETIME
);