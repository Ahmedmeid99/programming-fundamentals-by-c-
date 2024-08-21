----------------------
-- Nested While Loop 
----------------------

-- tabel of 1*1 : 10*10

-- 1  2  3  4  5  6  7  8  9  10
-- 2  4  6  8  10 12 14 16 18 20
-- 3  .. .. .. .. .. .. .. .. ..
-- 4  .. .. .. .. .. .. .. .. ..
-- 5  .. .. .. .. .. .. .. .. ..
-- 6  .. .. .. .. .. .. .. .. ..
-- 7  .. .. .. .. .. .. .. .. ..
-- 8  .. .. .. .. .. .. .. .. ..
-- 9  .. .. .. .. .. .. .. .. ..
-- 10 .. .. .. .. .. .. .. .. ..

Declare @Col int = 1;
Declare @Row int ;
Declare @Result int ;
Declare @Line varchar(100) = '';
Declare @Space varchar(5) = ' ';

While @Col <= 10
Begin
	Set @Line = '';
	Set @Row = 1;
	While @Row <= 10
	Begin
		Set @Result = @Col * @Row;
		if  @Result < 10 Begin Set @Space = '   ' end else Set @Space =  '  ';
		Set @Line = @Line +@Space + Cast(@Result as varchar);

		Set @Row = @Row + 1;
	End
	print @Line;
	--Go To Next Col
	Set @Col = @Col + 1;
End



-- Break & Continue
Declare @Counter int = 1;

While @Counter <=10
Begin
	if @Counter = 5 Begin Break End;
	Print Cast(@Counter as varchar)
	Set @Counter = @Counter +1
End

Set @Counter = 0;

While @Counter <10
Begin
	Set @Counter = @Counter +1
	if @Counter % 2 = 0 Begin Continue End;
	Print Cast(@Counter as varchar)
End