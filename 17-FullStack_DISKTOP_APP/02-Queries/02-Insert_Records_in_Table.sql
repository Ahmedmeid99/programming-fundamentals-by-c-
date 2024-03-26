USE [DVLD]
GO

INSERT INTO [dbo].[People]
           ([FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[Gander]
           ,[DateOfBirth]
           ,[Phone]
           ,[Email]
           ,[Address]
           ,[CountryID]
           ,[NationalID]
           ,[ImagePath])
     VALUES
           ('Ahmed','mo','Eid','Ali','M',CAST('1999-3-6' AS datetime),'0100123456','ahmed@gmail.com','123 str egypt',1, '13241332','E:\Test\images\avatar.png'),
		   ('mo','Eid','Ahmed','Ali','M',CAST('2000-4-12' AS datetime),'010013456','ahmed@gmail.com','123 str egypt',2, '23424233','E:\Test\images\friend-01.png'),
           ('Ali','Eid','mo','Ali','M',CAST('2003-9-1' AS datetime),'010233456','ahmed@gmail.com','123 str egypt',1,    '55323435','E:\Test\images\friend-02.png'),
		   ('Ahmed','mo','Eid','Eid','M',CAST('2012-1-13' AS datetime),'0104546656','ahmed@gmail.com','123 str egypt',1,'87624355','E:\Test\images\friend-03.png'),
		   ('Eid','mo','Ahmed','Ali','M',CAST('2007-3-9' AS datetime),'010354356','ahmed@gmail.com','123 str egypt',3,  '23424523','E:\Test\images\friend-04.png');

GO

-------------------------------------------
INSERT INTO [dbo].[Users]
           ([PersonID]
		   ,[UserName]
		   ,[Password]
		   ,[Permission]
		   ,[Active])
     VALUES
	 (2,'Ahmed','123456789',2,0);
	 --(1,'Abu_Eid','123456789',-1,1);

------------------------------------------

INSERT INTO [dbo].[Countries]
           (CountrName)
     VALUES
	 ('Egypt'),
	 ('USA'),
	 ('Jordan')
GO
----------------------------------------- 
INSERT INTO [dbo].[Applications]
           (ApplicationPersonID,ApplicationDate,ApplicationTypeID,lastStatusDate,ApplicationStatus,PaidFees,CreatedByUserID)
     VALUES
	 (2,GETDATE(),1,GETDATE(),1,15,1)
GO
-------------------------------------------
INSERT INTO [dbo].LocalDrivingLicenseApplications
           (ApplicationID,LicenseClassID)
     VALUES
	 (1,1)
GO


---------------------------------------------
INSERT INTO LocalDrivingLicenseApplications 
                            (ApplicationID,LicenseClassID)
							values
							(23,2)
---------------------------------------------
-- Updaet Person
---------------------------------------------
INSERT INTO ApplicationTypes (ApplicationTypes.Title,ApplicationTypes.Description,ApplicationTypes.Fees)
     VALUES
	 ('New Local Driving License Services',null,15),	 
	 ('ReNew Driving License Services',null,7),
	 ('Replacement for a Lost Driving License',null,10),
	 ('Replacement for a Damaged Driving License',null,5),
	  ('Release Detained Driving License',null,15),
	  ('New International License',null,51),
	  ('ReTake Test',null,5)
---------------------------------------------------
INSERT INTO TestTypes (TestTypes.Title,TestTypes.Description,TestTypes.Fees)
     VALUES
	 ('Vision Test',null,10),	 
	 ('Written (Theory) Test',null,20),
	 ('Practical (Street) Test',null,35)
------------------------------------------

INSERT INTO LicenseClasses (ClassName,ClassDescription,MinimumAllowedAge ,DefaultValidityLength ,ClassFees )
	VALUES
	('Class 1 - SmallMotorcycle',null,18,5,15),
	('Class 2 - Heavy Motorcycle License',null,21,5,30),
	('Class 3 - Ordinary diving License',null,18,10,20),
	('Class 4 - Commerical',null,21,10,200),
	('Class 5 - Agricultural',null,21,10,50),
	('Class 6 - Small and medium bus',null,21,10,250),
	('Class 7 - Truck and heavy vehicle',null,21,10,300)



Update Pepole  
                set FirstName = 'Ali', 
                    SecondName ='Eid', 
                    ThirdName = 'mo', 
                    LastName = 'hassan', 
                    Gander = 'M', 
                    NationalID = '13244252', 
                    Email = 'ali@gmail.com', 
                    Phone ='01022342223', 
                    Address ='str 123 egy', 
                    DateOfBirth = GetDate(),
                    NationaltyCountryID = 1,
                    ImagePath ='E:\Test\images\friend-04.png'

                                where PersonID = 3;

--------------------------------------------------------

