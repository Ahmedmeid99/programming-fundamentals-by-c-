
use C21_DB1;

Select * from Students
Select * from Teachers

Alter Function GetTopStudentsInEachSubject ()
Returns @Result Table (
	[StudentID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Subject] [nvarchar](50) NULL,
	[Grade] [int] NULL
	)
As
Begin
	Insert into @Result (StudentID,Name,Subject,Grade)  
	SELECT StudentID, Name, Subject, Grade
	FROM (
	    SELECT 
		StudentID,
	        Name,
	        Subject,
	        Grade,
	        ROW_NUMBER() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS rn
	    FROM Students
	) AS RankedGrades
	WHERE rn = 1 
	Return ;
End

select * from  GetTopStudentsInEachSubject()