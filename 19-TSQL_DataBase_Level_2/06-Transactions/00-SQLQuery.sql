----------------
--Transactions
----------------
use C21_DB1;

select * from Accounts;
select * from Transactions;

-- To Do
--send 70 $ fro AccountId 1 to AccountId 2 And Avoid problems maight be happen 
Declare @Amount decimal(10,2)=70;
Begin Transaction
	Begin Try
		
		if @Amount is Not Null and @Amount > 0 
		Begin 
			-- Move from 
			Update Accounts Set Balance = Balance - @Amount where AccountID = 1;
			-- Move To 
			Update Accounts Set Balance = Balance + @Amount where AccountID = 2;

			-- Log this Transaction in Table 
			Insert Into Transactions Values (1,2,@Amount,GetDate());

			COMMIT;
		End
		Else Begin Print 'An Error in Amount Null or < 0 ' End
	End Try
	Begin Catch
		ROLLBACK;
	End Catch


