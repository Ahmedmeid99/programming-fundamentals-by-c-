
use C21_DB1; -- Dont forget this Line
go

Create Procedure SP_AddNewPerson
		@FirstName varchar(50),
		@LastName varchar(50),
		@Email varchar(250),
		@NewPersonId int output
	As
	Begin
		Insert into dbo.People (FirstName,LastName,Email)
		Values (@FirstName,@LastName,@Email)

		Set @NewPersonId = SCOPE_IDENTITY()
	End


	--Execute Stored Procedural SP_AddNewPerson

	Declare @Return_Value Int,
			@NewID Int

	Exec @Return_Value = dbo.SP_AddNewPerson
		@FirstName = 'Ahmed',
		@LastName = 'Eid',
		@Email = 'Ahmedalbackrycool@gmail.com',
		@NewPersonId = @NewID Output
		

	Select @NewID as N'@NewPersonId'

	Select  N'Return Value' = @Return_Value


	select * from People



