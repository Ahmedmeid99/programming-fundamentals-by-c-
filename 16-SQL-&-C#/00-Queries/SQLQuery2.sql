SELECT * from Contacts;

SELECT * from Countries;

SELECT * FROM  Countries Where CountryName = 'Canada';

SELECT FOUND = 1 from Contacts
          where ContactID = 1;

SELECT *
FROM  Countries Where CountryName ='United States'



Alter Table Countries
Add Code nvarchar(3) null;

Alter Table Countries
Add PhoneCode nvarchar(3) null;


USE [ContactsDB2]
GO

UPDATE [dbo].[Contacts]
   SET 
      [CountryID] = 3
 WHERE ContactId = 7;
GO
