use C21_DB1;
Go;
Create Procedure SP_GetPersonById
	@PersonID Int
As
Begin
	Select * from People where @PersonId = @PersonID
End


Exec SP_GetPersonById
	@PersonID = 1