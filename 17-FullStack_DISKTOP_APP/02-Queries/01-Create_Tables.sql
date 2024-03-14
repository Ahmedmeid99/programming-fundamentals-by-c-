CREATE DATABASE DVLD

USE DVLD;

-- Create Pepole Table
Create Table People
	(
		PersonID int identity(1,1) not null,
		FirstName nvarchar(250) not null,
		SecondName nvarchar(250) not null,
		ThirdName nvarchar(250) not null,
		LastName nvarchar(250) not null,
		Gander varchar(1) not null,
		DateOfBirth DateTime not null,
		Phone varchar(250) not null,
		Email nvarchar(250),
		Address nvarchar(500) not null,
		CountryID int References Countries(CountryID) not null,
		NationalID nvarchar(250) unique not null,
		ImagePath nvarchar(500) not null,

		primary key(PersonID)
		
	);


------------------------------
Create Table Countries
(
	CountrID int identity(1,1) not null,
	CountrName nvarchar(250) not null,
	primary key(CountrID)
);

select * from Pepole ;
select * from Countries;


-- Update NathionalN to uinque
-- ...
Alter Table Pepole
Alter Column NationalID int unique nvarhar(250) not null;

SELECT PersonID,FirstName,SecondName,ThirdName,LastName,
Gander,DateOfBirth,Phone,Email,Address,NationaltyCountryID,NationalID,ImagePath FROM Pepole;

