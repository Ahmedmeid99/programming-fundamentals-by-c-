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
		NationalNo nvarchar(250) unique not null,
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
select * from LicenseClasses
select * from TestTypes
select * from  TestAppointments

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
SELECT Top 1* FROM TestAppointments WHERE LDLApplicationID = 1008 and TestTypeID = 1 ORDER BY AppointmentDate Desc
delete TestAppointments where TestTypeID =1;
Create Table TestAppointments 
	(
		TestAppointmentID int identity(1,1) not null,
		TestTypeID int References TestTypes(TestTypeID) not null,
		LDLApplicationID int References LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID) not null,
		PaidFees smallMoney not null,
		AppointmentDate DateTime not null,
		CreatedByUserID int References Users(UserID) not null,
		IsLocked bit not null

		primary key(TestAppointmentID)
	);

	select * from TestAppointments
-------------------------------------------
Create Table Tests 
	(
		TestID int identity(1,1) not null,
		TestAppointmentID int References TestAppointments(TestAppointmentID) not null,
		TestResult bit not null,
		Notes nvarchar(1500) null,
		CreatedByUserID int References Users(UserID) not null

		primary key(TestID)
	);
-------------------------------------------
Create Table Drivers 
	(
		DriverID int identity(1,1) not null,
		PersonID int References People(PersonID) not null,		
		CreatedByUserID int References Users(UserID) not null,
		CreatedDate DateTime not null

		primary key(DriverID)
	);
-------------------------------------------


Alter table Licenses 
Add constraint  LocalApplicationID
foreign key (LocalDrivingLicenseApplicationID  )
References LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID)
select * from Licenses 
Create Table Licenses 
	(
		LicenseID int identity(1,1) not null,
		ApplicationID int References LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID) not null,
		DriverID int References Drivers(DriverID) not null,
		LicenseClassID int References LicenseClasses(LicenseClasseID) not null,
		IssueDate DateTime not null,
		ExpirationDate DateTime not null,
		Notes nvarchar(1500) null,
		PaidFees smallMoney not null,
		IsActive Bit not null,
		IsDetained Bit null Default 0,
		IssueReason tinyint Not null,
		CreatedByUserID int References Users(UserID) not null

		primary key(LicenseID)
	);
-------------------------------------------
Create Table InternationalLicenses
	(
		InternationalLicenseID int identity(1,1) not null,
		ApplicationID int References Applications(ApplicationID) not null,
		DriverID int References Drivers(DriverID) not null,
		IssuedUsingLocalLicenseID int References Licenses(LicenseID) not null,
		IssueDate DateTime not null,
		ExpirationDate DateTime not null,
		IsActive Bit not null,
		CreatedByUserID int References Users(UserID) not null

		primary key(InternationalLicenseID)
	);

------------------------------------------------------------
--Get constraint_name to remove References then drop table
------------------------------------------------------------
select constraint_name from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where Table_name = 'ReleasedLicenses' ;

alter table ReleasedLicenses
drop constraint  FK__ReleasedL__Relea__178D7CA5 ;

drop table ReleasedLicenses
------------------------------------------------------------

select * from DetainedLicenses
select * from Licenses

Create Table DetainedLicenses -- View DetainedLicensesView use join left
	(
		DetainID int identity(1,1) not null,
		LicenseID int References Licenses(LicenseID) not null,
		DetainedDate DateTime not null,
		IsReleased Bit not null Default 0,
		FineFees smallMoney not null,
		PersonID int References People(PersonID) not null,

		primary key(DetainID)
	);
-------------------------------------------

Create Table ReleasedLicenses -- View DetainedLicensesView
	(
		ReleaseID int identity(1,1) not null,
		DetainID int References DetainedLicenses(DetainID) not null,
		LicenseID int References Licenses(LicenseID) not null,
		PaidFees smallMoney not null,
		ReleasedDate DateTime not null,
		ReleaseApplicationID int References Applications(ApplicationID) null,

		primary key(ReleaseID)
	);
-------------------------------------------
-------------------------------------------
--Alter table Licenses ADD Constraint ... Foreign key () References ON DELETE CASCADE;
--Alter table Licenses ADD Constraint ApplicationID Foreign key (ApplicationID) References Applications(ApplicationID) ON DELETE CASCADE;
SELECT * FROM DetainedLicenses WHERE LicenseID = 1032
select * from People ;
select * from ReleasedLicenses ;
select * from Drivers ;
select * from Licenses ;
SELECT * FROM LocalDLAppFullInfo WHERE LocalDrivingLicenseApplicationID =2009
select * from LocalDrivingLicenseApplications ;
select * from LocalDLAppFullInfo;
select * from ApplicationTypes ;
SELECT * FROM Users WHERE UserName = 'Ali' and Password = '111111'


select * from ApplicationTypes;
select * from LocalDrivingLicenseApplications;
select * from Users;
select * from DetainedLicenses;
select * from  ReleasedLicenses;

select Found = 1 from Licenses where LicenseID = 11 and  ExpirationDate < GETDATE() ;

-- Update NathionalN to uinque
-- ...
Alter Table People
Alter Column NationalNo int unique nvarhar(250) not null;

SELECT PersonID,FirstName,SecondName,ThirdName,LastName,
Gander,DateOfBirth,Phone,Email,Address,CountryID,NationalNo,ImagePath FROM People;

