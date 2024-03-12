
Create View PepoleFullData AS 
		SELECT Pepole.PersonID, Pepole.FirstName, Pepole.SecondName, Pepole.ThirdName, Pepole.LastName,
		Pepole.Gander, Pepole.DateOfBirth, Pepole.Phone, Pepole.Email, Pepole.Address, Countries.CountrName,
		Pepole.NationalID, Pepole.ImagePath
                        
		FROM Countries 
		INNER JOIN Pepole ON Countries.CountrID = Pepole.NationaltyCountryID

---------------------------------------------------------------------------------
select * from PepoleFullData