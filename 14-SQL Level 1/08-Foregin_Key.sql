-----------------------------
-- Foreign Key Constraint
-----------------------------

Create Database School;

use School;

-- Realtionship many to many 
-- 3 Tables Enrolleds Table connect between Students & Subjects

Create Table Students(
	Student_ID Int Identity(1,1) NOT NULL,
	Student_Name varchar(50) NOT NULL,
	Age Int NOT NULL,
	Class varchar(50) NOT NULL

	PRIMARY KEY(Student_ID)
);

Create Table Subjects(
	Subject_ID Int Identity(1,1) NOT NULL,
	Subject_Name varchar(50) NOT NULL,
	Subject_Hours Int NOT NULL

	PRIMARY KEY(Subject_ID)
);

Create Table Enrolleds(
	Enrolled_ID Int Identity(1,1) NOT NULL,
	Enrolled_Date Date ,

	StudentID Int REFERENCES Students(Student_ID) NOT NULL,
	SubjectID Int REFERENCES Subjects(Subject_ID) NOT NULL,

	PRIMARY KEY(Enrolled_ID)
);

-- insert data in Tables
Insert INTO Enrolleds(Enrolled_Date , StudentID,SubjectID )
Values
(GetDate(),6,1),
(NULL,6,2),
(NULL,7,3),
(NULL,8,4);


select * from Students;
select * from Subjects;
select * from Enrolleds;




--Alter Table Students
--add Class varchar(50) NOT NULL;