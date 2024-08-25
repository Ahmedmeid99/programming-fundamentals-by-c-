
use C21_DB1;

select * from Teachers;
select * from Students;

-- Scalar Function return simgle value
Create FUNCTION GetAverageGrade (@Subject nvarchar(50))
returns int
as
Begin

	Declare @AverageGrade int;

	Select @AverageGrade = AVG(Grade) from Students where Subject = @Subject;

	return @AverageGrade;-- this is not regulat return it work it work many times to the end of select

End


Select TeacherID,Name,Subject,[dbo].[GetAverageGrade](Subject)as Avg_Grade from Teachers;