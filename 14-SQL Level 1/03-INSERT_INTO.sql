------------------------------------------
--INSERT INTO -> to Add Record(s) of data
------------------------------------------

-- Insert Employee Recourd in Employees table 
INSERT INTO Employees
VALUES
(1,'Ahmed','mo','eid','M',10000);

-- INSERT MANY RECORDS
INSERT INTO Employees
values
(8,'Omer','mo','Eid','M',290),
(9,'hmza','Mohmed','ali','M',700),
(10,'Soha','Ahmed','elbakry','f',1570);

INSERT INTO Employees (ID,FirstName,LastName,MidName)
values
(12,'heba','ahmed','hassan');

select * from Employees;