
Create View PeopleFullData AS 
		SELECT People.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName,
		People.Gander, People.DateOfBirth, People.Phone, People.Email, People.Address, Countries.CountryName,
		People.NationalID, People.ImagePath
                        
		FROM Countries 
		INNER JOIN People ON Countries.CountryID = People.CountryID

---------------------------------------------------------------------------------

Create View PeopleImportantData AS 
		SELECT People.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName,
		People.Gander, People.DateOfBirth, People.Phone, People.Email, People.Address, Countries.CountryName,
		People.NationalID
                        
		FROM Countries 
		INNER JOIN People ON Countries.CountryID = People.CountryID;
---------------------------------------------------------------------------------

select * from PeopleImportantData