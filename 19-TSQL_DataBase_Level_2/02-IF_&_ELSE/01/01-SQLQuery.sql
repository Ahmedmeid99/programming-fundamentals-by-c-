use C21_DB1;
Go

-- select * from Employees;

-- select * from Departments;

Declare @HrId int ;

Select @HrId = DepartmentID from Departments where Name = 'Human Resources'

IF Exists(select * from Employees where DepartmentID  = @HrId)
Begin 
	print  'This Department (HR) is Founded in id =' + ' ' + cast(@HrId as varchar)
End


