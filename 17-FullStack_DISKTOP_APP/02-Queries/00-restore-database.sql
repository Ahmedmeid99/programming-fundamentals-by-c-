
restore DataBase DVLD 
FROM Disk='E:\Test\Test_DVLD.bak';

backup DataBase DVLD 
to Disk='E:\Test\DVLD.bak';
drop database DVLD;



USE DVLD;
Select * from People;
Select * from Countries;
Select * from Users;

Update People
Set NationalNo = CAST(ABS(CHECKSUM(NEWID())) as varchar(17)) 