
Create Database C21_DB1;
Go

Use C21_DB1;


-- Create the Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    Name VARCHAR(50)
);

-- Insert sample data into Departments
INSERT INTO Departments (DepartmentID, Name) VALUES (1, 'Human Resources');
INSERT INTO Departments (DepartmentID, Name) VALUES (2, 'Marketing');
INSERT INTO Departments (DepartmentID, Name) VALUES (3, 'Sales');
INSERT INTO Departments (DepartmentID, Name) VALUES (4, 'IT');

Go

--Create the Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50),
    DepartmentID INT,
    HireDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert sample data into Employees
INSERT INTO Employees (EmployeeID, Name, DepartmentID, HireDate) VALUES (1, 'John Smith', 3, '2023-01-10');
INSERT INTO Employees (EmployeeID, Name, DepartmentID, HireDate) VALUES (2, 'Jane Doe', 3, '2023-02-15');
INSERT INTO Employees (EmployeeID, Name, DepartmentID, HireDate) VALUES (3, 'Emily Davis', 2, '2023-03-20');
INSERT INTO Employees (EmployeeID, Name, DepartmentID, HireDate) VALUES (4, 'Michael Brown', 1, '2022-11-05');
INSERT INTO Employees (EmployeeID, Name, DepartmentID, HireDate) VALUES (5, 'Sarah Miller', 4, '2023-01-05');
