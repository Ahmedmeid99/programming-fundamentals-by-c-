------------------------
-- Variable Table
------------------------
--Notes :. This Table will store in Memory
Declare @EmployeeTable Table(
	Id int identity(1,1),
	Name varchar(100) not null,
	DepartmentName varchar(100) not null,
	primary key(Id)
)

Insert into @EmployeeTable (Name,DepartmentName)
values
('Ali','Salles'),
('Hassan','HR')

delete @EmployeeTable where Name = 'Ali' 

Select * from @EmployeeTable