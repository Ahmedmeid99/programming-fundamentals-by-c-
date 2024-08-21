
Create Procedure SP_DeletePersonById
	@PersonId Int
As 
Begin 
Delete People Where PersonID = @PersonId
End

exec SP_GetPeople

Exec SP_DeletePersonById
	@PersonId = 1

-- You can check if your query worked successfuly 
-- using @@ROWCOUNT