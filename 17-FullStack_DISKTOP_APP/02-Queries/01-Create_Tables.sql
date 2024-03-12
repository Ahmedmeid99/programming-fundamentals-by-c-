CREATE DATABASE DVLD

USE DVLD;

-- Create Pepole Table
Create Table Pepole
	(
		PersonID int identity(1,1) not null,
		FirstName nvarchar(250),
		SecondName nvarchar(250),
		ThirdName nvarchar(250),
		LastName nvarchar(250),
		Gander varchar(1),
		DateOfBirth DateTime,
		Phone varchar(250),
		Email nvarchar(250),
		Address nvarchar(250),
		NationaltyCountryID int References Countries(CountrID) ,
		NationalID nvarchar(250),
		ImagePath nvarchar(250),

		primary key(PersonID)
	);

------------------------------
Create Table Countries
(
	CountrID int identity(1,1) not null,
	CountrName nvarchar(250),
	primary key(CountrID)
);

select * from Pepole ;
select * from Countries;



SELECT PersonID,FirstName,SecondName,ThirdName,LastName,
Gander,DateOfBirth,Phone,Email,Address,NationaltyCountryID,NationalID,ImagePath FROM Pepole;

Update Pepole  
                            set FirstName = 'Ali', 
                                SecondName ='Eid', 
                                ThirdName = 'mo', 
                                LastName = 'hassan', 
                                Gander = 'M', 
                                NationalID = '13244252', 
                                Email = 'ali@gmail.com', 
                                Phone ='01022342223', 
                                Address ='str 123 egy', 
                                DateOfBirth = GetDate(),
                                NationaltyCountryID = 1,
                                ImagePath ='E:\Test\images\friend-04.png'

                                where PersonID = 3;