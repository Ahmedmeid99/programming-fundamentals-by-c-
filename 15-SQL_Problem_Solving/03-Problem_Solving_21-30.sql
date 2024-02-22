---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------ [21-30] ------------------

use VehicleMakesDB;

select * from dbo.Bodies;
select * from dbo.SubModels ;
select * from dbo.MakeModels;
select * from dbo.DriveTypes;
select * from dbo.Makes;
select * from dbo.FuelTypes;
select * from dbo.VehicleDetails;

-- [21] Get total vehicles that number of doors is not specified
select Count(*) from dbo.VehicleDetails Where NumDoors is Null;

-- [22] Get Percentage of vehicles that number of doors is not specified
select 
	Cast(
		Count(*) as float) /
		Cast( 
				(select count(*) from dbo.VehicleDetails) as float
			) 
		AS PercOfNospecifiedDoors
		from dbo.VehicleDetails Where NumDoors is Null;

-- [23] Get MakeID, Make, SubModelName for all vehicles tha have SubModelName 'Elite'
SELECT Distinct VehicleDetails.MakeID, Makes.Make, SubModels.SubModelName
		FROM VehicleDetails 
		INNER JOIN SubModels ON VehicleDetails.SubModelID = SubModels.SubModelID 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		where SubModelName = 'Elite';
 
-- [24] Get all vehicles that have Engines > 3 Liters and have onle 2 dooes
SELECT * from VehicleDetails Where (Engine_Liter_Display > 3) and (NumDoors = 2);

-- [25] Get make and vehicles that engine contains 'OHV' and have cylinders = 4
SELECT Makes.Make,VehicleDetails.*
		from VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Where (Engine like '%OHV%') and (Engine_Cylinders = 4);

-- [26] Get all vehicles that their body is 'Sport Utility' and Year 2020  
SELECT  VehicleDetails.*, Bodies.BodyName
		FROM VehicleDetails 
		INNER JOIN Bodies ON VehicleDetails.BodyID = Bodies.BodyID
		Where Bodies.BodyName = 'Sport Utility' and VehicleDetails.Year =2020

-- [27] Get all vehicles that their Body is 'Coupe' or 'Hatchback' or ' Sedan'
SELECT  VehicleDetails.*, Bodies.BodyName
		FROM VehicleDetails 
		INNER JOIN Bodies ON VehicleDetails.BodyID = Bodies.BodyID
		Where BodyName in ('Coupe', 'Hatchback', 'Sedan');

-- [28] Get all Vehicles their Body is 'Coupe' or 'Hatchback' or ' Sedan' and in Year 2008 2020 2021
SELECT  VehicleDetails.*, Bodies.BodyName
		FROM VehicleDetails 
		INNER JOIN Bodies ON VehicleDetails.BodyID = Bodies.BodyID
		Where BodyName in ('Coupe', 'Hatchback', 'Sedan')
		and Year in (2008, 2020, 2021);

-- [29] Returns Found = 1 if there is any vehices made in year 1950
SELECT Found = 1
	Where exists
	(
		select * from VehicleDetails where Year = 1950
	);

-- [30] Get all Vehicle_Display_Name, NumDoors, Describe Doors and if null -> 'Not Set'
SELECT FROM 
