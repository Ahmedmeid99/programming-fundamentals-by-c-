use C21_DB1;

--Common String Functions...

-- Using the LEN function to get the length of each employee's name
SELECT LEN(Name) AS NameLength FROM dbo.Employees2
GO

-- Converting employee names to uppercase using the UPPER function
SELECT UPPER(Name) AS UpperCaseName FROM dbo.Employees2
GO

-- Converting employee names to lowercase using the LOWER function
SELECT LOWER(Name) AS UpperCaseName FROM dbo.Employees2
GO

-- Extracting the first three characters of each name using SUBSTRING
SELECT SUBSTRING(Name, 1, 3) AS NameSubstring FROM dbo.Employees2
GO

-- Finding the position of '0' in each name using CHARINDEX
SELECT CHARINDEX('o', Name) AS CharPosition FROM dbo.Employees2
GO

-- Replacing 'Sales' with 'Marketing' in department names using REPLACE
SELECT REPLACE(Department, 'Sales', 'Marketing') AS NewDepartment FROM dbo.Employees2
GO

-- Concatenating the name and department with a hyphen in between using CONCAT
SELECT CONCAT(Name, ' - ', Department) AS ConcatenatedString FROM dbo.Employees2
GO

-- Practice Exercise: Format Name and Department in a specific format using CONCAT, UPPER, and LOWER
-- Objective: Format the Name and Department columns as a single string, where names are in uppercase, and department names are in lowercase, separated by a colon (:)
SELECT CONCAT(UPPER(Name), ' : ', LOWER(Department)) AS FormattedOutput FROM dbo.Employees2
GO

-- Extracting the first 3 characters from the left side of the employee's name using LEFT
SELECT LEFT(Name, 3) AS LeftSubstring FROM dbo.Employees2
GO

-- Extracting the last 3 characters from the right side of the employee's name using RIGHT
SELECT RIGHT(Name, 3) AS RightSubstring FROM dbo.Employees2
GO

-- Removing leading spaces from the employee's name using LTRIM
SELECT LTRIM(Name) AS NameWithNoLeadingSpaces FROM dbo.Employees2
GO

-- Removing trailing spaces from the employee's name using RTRIM
SELECT RTRIM(Name) AS NameWithNoTrailingSpaces FROM dbo.Employees2
GO


-- Removing spaces from the start and end of each name using LTRIM and RTRIM
SELECT LTRIM(RTRIM(Name)) AS TrimmedName FROM dbo.Employees2
GO

-- Removing both leading and trailing spaces from the employee's name using TRIM
SELECT TRIM(Name) AS NameWithNoSpaces FROM dbo.Employees2
GO


-------------------------------------------------------------
-- String Functions (Transact-SQL) :
-- https://learn.microsoft.com/en-us/sql/t-sql/functions/string-functions-transact-sql?view=sql-server-ver16