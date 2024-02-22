---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------ [31-40] ------------------

use VehicleMakesDB;

select * from dbo.Bodies;
select * from dbo.SubModels ;
select * from dbo.MakeModels;
select * from dbo.DriveTypes;
select * from dbo.Makes;
select * from dbo.FuelTypes;
select * from dbo.VehicleDetails;

-- [31] Get all vehicle_Display_name, year, age of the vehicle and sort by age desc
SELECT Vehicle_Display_Name,Year,Age = Year(GETDATE()) - VehicleDetails.Year 
		FROM VehicleDetails Order by Age Desc;

-- [32] Get all vehicle_Display_name, year, age of the vehicle that their age >= 15 , age <= 25
SELECT *FROM (SELECT Vehicle_Display_Name,Year,Age = Year(GETDATE()) - VehicleDetails.Year 
		FROM VehicleDetails )R1
		where Age between 15 and 25;

-- [33] Get Minimum Engine CC, Maxmum  Engine CC, and Averahe  Engine CC of all Nehicles 
select MINEngine_CC=MIN(Engine_CC), MAXEngine_CC=MAX(Engine_CC),AVGEngine_CC=AVG(Engine_CC) 
		from dbo.VehicleDetails;

-- [34] Get all Vehicles that have the minimum Engine_CC
select * from VehicleDetails
		WHERE Engine_CC = (SELECT MIN(Engine_CC) FROM VehicleDetails)

-- [35] Get all Vehicles that have the maximum Engine_CC
select * from VehicleDetails
		WHERE Engine_CC = (SELECT MAX(Engine_CC) FROM VehicleDetails)

-- [36] Get all Vehicles that have Engine_CC Below average
select * from VehicleDetails
		WHERE Engine_CC < (SELECT AVG(Engine_CC) as TheAvg FROM VehicleDetails)

-- [37]  Get all Vehicles that have Engine_CC Above average 61211
select count(*) from 
	(
		select * from VehicleDetails
		WHERE Engine_CC > (SELECT AVG(Engine_CC) as TheAvg FROM VehicleDetails)
	)R3

-- [38] Get all unique Engin_CC and sort them Desc
select Distinct(Engine_CC) from VehicleDetails order by Engine_CC Desc;

-- [39] Get the Maximum 3 Engine CC
select  Distinct Top 3 Engine_CC from VehicleDetails order by Engine_CC Desc;

-- [40] Get all vehicles that has one of  the max 3 Engine CC
select  * from VehicleDetails Where Engine_CC in (select  Distinct Top 3 Engine_CC from VehicleDetails order by Engine_CC Desc);





