

use C21_DB1

Select * from Students
Select * from Teachers


-- Create Table Valued Function
Create Function GetStudentsBySubject (@Subject varchar(50))
returns Table
as
Return( Select * from Students where Subject = @Subject )
---------------------------------------------------------


-- use inline Table Valued with From
select * from GetStudentsBySubject('Math')
---------------------------------------------------------


-- use inline Table Valued with Join
Select S.StudentID,S.Name,S.Subject,S.Grade,Teachers.Name as TeacherName
	from Teachers
	Join  GetStudentsBySubject('Math') S ON S.Subject = Teachers.Subject;
---------------------------------------------------------
