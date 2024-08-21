use C21_DB1;

-- Assume we have a table called 'Employees' with a unique constraint on 'EmployeeID'
CREATE TABLE Employees3 (
    EmployeeID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Position NVARCHAR(100)
);

