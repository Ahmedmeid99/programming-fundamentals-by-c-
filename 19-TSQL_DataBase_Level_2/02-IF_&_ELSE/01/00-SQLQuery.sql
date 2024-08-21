


---------------------------------
-- if else statement
---------------------------------
Declare @Score Int;
set @Score = 70;

Declare @MS_STR varchar(25) = 'His mark is';

IF @Score >= 90
	Begin
		Print @MS_STR + ' ' + 'A' 
	End; 
ELSE
	Begin
		IF @Score >= 80
			Begin
				Print @MS_STR + ' ' + 'B' 
			End;
		Else
			Begin
				Print @MS_STR + ' ' + 'C' 
			End;
	End; 



