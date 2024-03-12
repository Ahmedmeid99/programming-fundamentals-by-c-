USE [DVLD]
GO

INSERT INTO [dbo].[Pepole]
           ([FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[Gander]
           ,[DateOfBirth]
           ,[Phone]
           ,[Email]
           ,[Address]
           ,[NationaltyCountryID]
           ,[NationalID]
           ,[ImagePath])
     VALUES
           ('Ahmed','mo','Eid','Ali','M',CAST('1999-3-6' AS datetime),'0100123456','ahmed@gmail.com','123 str egypt',1, '13241332','E:\Test\images\avatar.png'),
		   ('mo','Eid','Ahmed','Ali','M',CAST('2000-4-12' AS datetime),'010013456','ahmed@gmail.com','123 str egypt',2, '23424233','E:\Test\images\friend-01.png'),
           ('Ali','Eid','mo','Ali','M',CAST('2003-9-1' AS datetime),'010233456','ahmed@gmail.com','123 str egypt',1,    '55323435','E:\Test\images\friend-02.png'),
		   ('Ahmed','mo','Eid','Eid','M',CAST('2012-1-13' AS datetime),'0104546656','ahmed@gmail.com','123 str egypt',1,'87624355','E:\Test\images\friend-03.png'),
		   ('Eid','mo','Ahmed','Ali','M',CAST('2007-3-9' AS datetime),'010354356','ahmed@gmail.com','123 str egypt',3,  '23424523','E:\Test\images\friend-04.png');

GO




INSERT INTO [dbo].[Countries]
           (CountrName)
     VALUES
	 ('Egypt'),
	 ('USA'),
	 ('Jordan')
GO

