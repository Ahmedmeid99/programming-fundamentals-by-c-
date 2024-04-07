
Create View PeopleImportantData AS 
		SELECT People.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName,
		People.Gendor, People.DateOfBirth, People.Phone, People.Email, People.Address, Countries.CountryName,
		People.NationalNo
                        
		FROM Countries 
		INNER JOIN People ON Countries.CountryID = People.CountryID

---------------------------------------------------------------------------------

Create View UsersFullData AS 
		SELECT  People.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.Gander, People.DateOfBirth, People.Phone, People.Email, People.Address, People.NationalID, Countries.CountryName, 
                Users.UserName, Users.Active
		FROM    Countries INNER JOIN
                         People ON Countries.CountryID = People.CountryID INNER JOIN
                         Users ON People.PersonID = Users.PersonID;
---------------------------------------------------------------------------------

--UsersImportantData
Create View UsersImportantData AS 
select UserID,PersonID,UserName,Permission,Active from Users;

Create View UsersImportantInfo AS 
				SELECT  Users.UserID, Users.PersonID,
				FullName = People.FirstName +' '+ People.SecondName +' '+ People.ThirdName +' '+ People.LastName,
				Users.UserName, Users.Active 
				FROM Users
				INNER JOIN   People ON People.PersonID = Users.PersonID;
------------------------------------------------------------------------------------
Create View AppTypesImportantInfo As 
Select ApplicationTypeID,Title,Fees from ApplicationTypes;

------------------------------------------------------------------------------------
-- you need to add oassed tests 
Create View LocalDLAppImportantInfo As 
SELECT        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LicenseClasses.ClassName, People.NationalNo,FullName = People.FirstName +' '+People.SecondName+' '+People.ThirdName+' '+People.LastName, Applications.ApplicationDate, 
			Applications.PassedTests,
			ApplicationStatus = 
						 Case 
						 When Applications.ApplicationStatus = 1 then 'New'
						 When Applications.ApplicationStatus = 2 then 'Cancelled'
						 When Applications.ApplicationStatus = 3 then 'Completed'
						 else 'Unknow'
						 end
FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                         LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClasseID INNER JOIN
                         People ON Applications.ApplicationPersonID = People.PersonID;
------------------------------------------------------------------------------------
Create View LocalDLAppFullInfo As 
SELECT        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicationPersonID, Applications.ApplicationDate, Applications.ApplicationTypeID, 
                        Applications.ApplicationStatus,Applications.PassedTests
						 , Applications.lastStatusDate, Applications.PaidFees, Applications.CreatedByUserID
FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID

------------------------------------------------------------------------------------
Create View LDLApplivationView As 
SELECT        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicationPersonID, Applications.ApplicationDate, Applications.ApplicationTypeID, 
                         Applications.ApplicationStatus, Applications.lastStatusDate, Applications.PaidFees, Users.UserName
FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                         Users ON Applications.CreatedByUserID = Users.UserID
------------------------------------------------------------------------------------

Create View TestAppointmentsView As 
SELECT        TestAppointmentID, AppointmentDate, PaidFees, IsLocked
FROM            TestAppointments;
------------------------------------------------------------------------------------
Create View DriversView As 
SELECT        Drivers.DriverID, Drivers.PersonID, People.NationalNo,
				FullName = People.FirstName +' '+ People.SecondName +' '+ People.ThirdName +' '+ People.LastName, 
				Drivers.CreatedDate as Date, Count() As 'Active Licenses'
FROM            Drivers INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID
------------------------------------------------------------------------------------
SELECT	Drivers.DriverID, Drivers.PersonID, People.NationalNo,
		FullName = People.FirstName +' '+ People.SecondName +' '+ People.ThirdName +' '+ People.LastName, 
		count(Licenses.LicenseID) As 'Active Licenses'
FROM	Drivers INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         People ON Drivers.PersonID = People.PersonID
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
SELECT * FROM LicenseClasses WHERE LicenseClasseID = 1
select * from UsersImportantInfo;
select * from LocalDLAppFullInfo;
select * from  LocalDLAppImportantInfo;
select * from  LocalDrivingLicenseApplications;
select * from LDLApplivationView;
SELECT * FROM LocalDLAppFullInfo;

SELECT * FROM LicenseClasses;
select * from dbo.Tests;
SELECT * FROM Applications
delete LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = 2; -- 2 5 1007


SELECT * FROM LicenseClasses WHERE LicenseClasseID =1
select * from LocalDLAppFullInfo Where ApplicationID =1008;
select * from Applications Where ApplicationID =1008;
select * from dbo.DetainedLicenses;
select * from dbo.Drivers;
select * from dbo.InternationalLicenses;
select * from dbo.LicenseClasses;
select * from dbo.Licenses;
select * from dbo.LocalDrivingLicenseApplications;
select * from TestTypes;
