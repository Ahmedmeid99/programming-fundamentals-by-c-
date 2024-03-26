
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
			ApplicationStatus = 
						 Case 
						 When Applications.ApplicationStatus = 1 then 'New'
						 When Applications.ApplicationStatus = 2 then 'Cancelled'
						 else 'UnKnow'
						 end
FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                         LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClasseID INNER JOIN
                         People ON Applications.ApplicationPersonID = People.PersonID;
------------------------------------------------------------------------------------
Create View LocalDLAppFullInfo As 
SELECT        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicationPersonID, Applications.ApplicationDate, Applications.ApplicationTypeID, 
                        Applications.ApplicationStatus
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

------------------------------------------------------------------------------------
SELECT * FROM LicenseClasses WHERE LicenseClasseID = 1
select * from UsersImportantInfo;
select * from LocalDLAppFullInfo;
select * from  LocalDLAppImportantInfo;
select * from  LocalDrivingLicenseApplications;
select * from LDLApplivationView;
SELECT * FROM LocalDLAppFullInfo
SELECT * FROM LicenseClasses;
SELECT * FROM LicenseClasses WHERE LicenseClasseID =1
select * from Applications;
select * from dbo.DetainedLicenses;
select * from dbo.Drivers;
select * from dbo.InternationalLicenses;
select * from dbo.LicenseClasses;
select * from dbo.Licenses;
select * from dbo.LocalDrivingLicenseApplications;
select * from dbo.Tests;

