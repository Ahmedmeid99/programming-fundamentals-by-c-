-----------------------------
------ [Print 1 : 10] -------
-----------------------------
Declare @Counter int =1;

While @Counter <= 10
Begin
	Print 'counter : ' + Cast(@Counter as varchar)
--increase Counter 
	Set @Counter = @Counter + 1
End


-----------------------------
------ [Print 10 : 1] -------
-----------------------------
Declare @Counter2 int =10;

While @Counter2 >= 1
Begin
	Print 'counter : ' + Cast(@Counter2 as varchar)
--increase Counter 
	Set @Counter2 = @Counter2 - 1
End

-----------------------------
------ [1*1 : 10*10] -------
-----------------------------

Declare @MyCounter int =1 ;
Declare @inCounter int ;
Declare @Result int ;

While  @MyCounter <= 10
Begin
	set @inCounter = 1; -- important step to reset variable (@inCounter)
	While  @inCounter <= 10
	Begin
	Set @Result = @MyCounter*@inCounter
		Print Cast(@MyCounter as nvarchar) + ' * ' + Cast(@inCounter as nvarchar) + ' = ' + Cast(@Result as nvarchar);
		Set @inCounter = @inCounter + 1
	End
	-- Increase 
	Set @MyCounter = @MyCounter + 1
End


--------------------
-- Loop throw Tabel
--------------------
use C21_DB1

select * from Employees

-- Declare
Declare @EmployeeId int;
Declare @MaxId int;
Declare @Name varchar(50);

-- Set
Select @EmployeeId = Min(EmployeeID )From Employees
Select @MaxId = Max(EmployeeID )From Employees

-- Loop trow tabel
While @EmployeeId is Not Null and @EmployeeId <=@MaxId
Begin
	Select @Name=Name from Employees Where EmployeeID = @EmployeeId;
	print @Name;

	--Go To next EmployeeID
	Select @EmployeeId = Min(EmployeeID) from Employees Where EmployeeID > @EmployeeId
End

-- John Smith
-- Jane Doe
-- Emily Davis
-- Michael Brown
-- Sarah Miller

