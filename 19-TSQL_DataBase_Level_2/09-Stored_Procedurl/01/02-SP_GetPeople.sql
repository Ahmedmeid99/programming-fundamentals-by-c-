use C21_DB1
Go;


Create Procedure SP_GetPeople
As
Begin
	Select * from People;
End


Exec SP_GetPeople