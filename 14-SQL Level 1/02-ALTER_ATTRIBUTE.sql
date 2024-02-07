------------------------------------
--ALTER to work on attributes
------------------------------------

use Company;

-- Add New Field/attribute to Employees table
Alter table Employees
add Selary float;

-- Delete Field/attribute
Alter table Employees
drop Column Balance ;

-- Update Attributes name or Table name
exec sp_rename 'Employees.Selary','Salary','COLUMN';
exec sp_rename 'Employees1','Employees';

select * from Employees;















