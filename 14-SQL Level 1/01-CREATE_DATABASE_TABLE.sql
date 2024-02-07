------------------------------------
--CREATE DATABASE NAME, Table NAME ()
------------------------------------

--Create DataBase if not exists
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name='Company')
BEGIN
Create DATABASE Company;
END;

-- Select All DataBases
select * from sys.databases;

--Delete database
--DROP DATABASE Company;

USE Company;


Create Table Employees
(
	ID INT NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	MidName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gander char(1)

	PRIMARY KEY(ID)

);

--drop table Employees;