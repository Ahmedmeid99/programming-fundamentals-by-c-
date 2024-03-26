CREATE DATABASE DVLD

USE DVLD;

-- Create People Table
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

------------------------------
Create Table Users
	(
		UserID int identity(1,1) not null,
		PersonID int not null References People(PersonID),
		UserName nvarchar(250) not null,
		Passwerd nvarchar(250) not null,
		Permission SmallInt not null,
		Active Bit not null Default 1,

		primary key(UserID)
	);
--------------------------------
Create Table ApplicationTypes
	(
		ApplicationTypeID int identity(1,1) not null,
		Title nvarchar(250) not null,
		Description nvarchar(1500) null,
		Fees smallMoney not null

		primary key(ApplicationTypeID)
	);
--------------------------------------
Create Table TestTypes
	(
		TestTypeID int identity(1,1) not null,
		Title nvarchar(250) not null,
		Description nvarchar(1500) null,
		Fees smallMoney not null

		primary key(TestTypeID)
	);

--------------------------------------
Create Table Applications
	(
		ApplicationID int identity(1,1) not null,
		ApplicationPersonID int References People(PersonID) not null,
		ApplicationDate dateTime Not Null,
		ApplicationTypeID int References ApplicationTypes(ApplicationTypeID) not null,
		lastStatusDate dateTime Not Null,
		ApplicationStatus tinyint Not null, -- New , Cancelled , Completed
		PaidFees smallMoney not null,
		CreatedByUserID int References Users(UserID) not null 

		primary key(ApplicationID)
	);
----------------------------------------
Create Table LicenseClasses
	(
		LicenseClasseID int identity(1,1) not null,
		ClassName nvarchar(1500) not null,
		ClassDescription nvarchar(1500) null,
		ApplicationID int References Applications(ApplicationID) not null,
		DefaultValidityLength smallint not null,
		ClassFees smallMoney  not null

		primary key(LicenseClasseID)
	);
-------------------------------------------
Create Table LocalDrivingLicenseApplications
	(
		LocalDrivingLicenseApplicationID int identity(1,1) not null,
		ApplicationID int References Applications(ApplicationID) not null,
		LicenseClassID int References LicenseClasses(LicenseClasseID) not null

		primary key(LocalDrivingLicenseApplicationID)
	);
-------------------------------------------

select * from ApplicationTypes ;
select * from Applications;
select * from LocalDrivingLicenseApplications;
select * from LicenseClasses ;
select * from Users;
select * from people;


-- Update NathionalN to uinque
-- ...
Alter Table Pepole
Alter Column NationalID int unique nvarhar(250) not null;

SELECT PersonID,FirstName,SecondName,ThirdName,LastName,
Gander,DateOfBirth,Phone,Email,Address,NationaltyCountryID,NationalID,ImagePath FROM Pepole;

