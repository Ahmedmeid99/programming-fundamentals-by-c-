---------------------
-----[Temp Table]----
---------------------

-- Create Local #////// Global ##//////

Create Table #DbEmployees (
	Id Int Identity(1,1),
	Name varchar(50) Not null,
	Department varchar(50) not null,
	primary key(Id)
	)

Insert Into #DbEmployees
	(Name,Department)Values 
	('Ahmed','Devrloper'),
	('Ali','Salles'),
	('Hassan','HR')


Update #DbEmployees Set Department = 'Developer' Where Id = 1;


Delete #DbEmployees Where Id = 3;


Select * from #DbEmployees

Drop Table #DbEmployees	

