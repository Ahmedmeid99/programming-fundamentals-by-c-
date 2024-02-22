------------------------------------------------------
-- Identify Field (auto Increment) ID -> primary Key
-- Identify(start , Incress)
------------------------------------------------------

-- When Create Table
Create Table Students(
	ID Int Identity(1,1) Not null,
	FirstNmae varchar(50) Not null ,
	LastName varchar(50) Not null ,
	Age Int

	PRIMARY KEY(ID)
);

-- Start Primary Key From 10 and incress it by 1 => 10 11 12
Create Table Students2(
	ID Int Identity(10,1) Not null,
	FirstNmae varchar(50) Not null ,
	LastName varchar(50) Not null ,
	Age Int

	PRIMARY KEY(ID)
);

-- Start Primary Key From 10 and incress it by 2 => 10 12 14
Create Table Students3(
	ID Int Identity(10,2) Not null,
	FirstNmae varchar(50) Not null ,
	LastName varchar(50) Not null ,
	Age Int

	PRIMARY KEY(ID)
);

INSERT INTO Students3
values
('ahmed','eid',22);

select * from Students;
select * from Students2;
select * from Students3;

----------------------------------
-- Delete and Truncate
-- Delete   => not reset identity 
-- Truncate => reset identity 
-- and have`nt where statement
----------------------------------

delete From Students2; -- after add new records    => 14 15 16

delete From Students3
where age >100;

Truncate Table Students3; -- after add new records => 10 12 14 (start from beginnge)