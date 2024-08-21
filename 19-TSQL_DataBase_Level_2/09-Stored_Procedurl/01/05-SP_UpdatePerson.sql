

Create Procedure SP_UpdatePerson
	@PersonId int,
	@FirstName varchar(50),
	@LastName varchar(50),
	@Email varchar(250)
	
as
Begin
	Update People
		Set FirstName = @FirstName, LastName = LastName, Email = @Email
		where PersonID = @PersonId
End

--------------------------
Declare @ID Int;

Exec SP_AddNewPerson
	@FirstName = 'Ali',
	@LastName = 'Hassan',
	@Email = 'Ali@gmail.com',
	@NewPersonId = @ID Output


--------------------------
Print Cast(@ID as varchar)
--------------------------

Exec SP_UpdatePerson
		@PersonId =2,
		@FirstName ='AhmedEID',
		@LastName ='Ali',
		@Email ='Ahmed@gmail.com'

--------------------------
Exec SP_GetPeople;