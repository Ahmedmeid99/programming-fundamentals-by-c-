---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------ [11-20] ------------------

use VehicleMakesDB;

select * from dbo.Bodies;
select * from dbo.SubModels;
select * from dbo.MakeModels;
select * from dbo.DriveTypes;
select * from dbo.Makes;
select * from dbo.FuelTypes;
select * from dbo.VehicleDetails;

-- [11] Get Total count of Makes that run using GAS
select count(*) from 
	(
		SELECT  Makes.Make, FuelTypes.FuelTypeName
		FROM VehicleDetails 
		INNER JOIN FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Where FuelTypes.FuelTypeName = N'GAS'
		Group by  Makes.Make, FuelTypes.FuelTypeName
	)R1

-- [12] Count Vehicles by make and order them by numberOfvehicles from hight to low
SELECT  Makes.Make, NumberOfVehicle = Count(Vehicle_Display_Name)
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Group by  Makes.Make
		order by  NumberOfVehicle desc

-- [13] Get all Makes and Count of Vehicles where count > 20k Vehicles
SELECT  Makes.Make, NumberOfVehicle=Count(Vehicle_Display_Name)
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Group by  Makes.Make having Count(Vehicle_Display_Name) > 20000
		order by  NumberOfVehicle desc

-- [14] Get all Makes with make starts with 'B'
SELECT Makes.Make
		FROM Makes
		Where Makes.Make Like 'B%'

-- [15] Get all Makes with make Ends with 'W'
SELECT  Makes.Make
		FROM Makes
		Where Makes.Make Like '%W'

-- [16] Get all Makes that manufactures DriveTypeName = FWD
SELECT  Distinct Makes.Make, DriveTypes.DriveTypeName
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID 
		INNER JOIN DriveTypes ON VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
		Where DriveTypes.DriveTypeName = 'FWD'

-- [17] otal count of all Makes that manufactures DriveTypeName = FWD
|SELECT count(*) from
	(
		SELECT  Distinct Makes.Make, DriveTypes.DriveTypeName
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID 
		INNER JOIN DriveTypes ON VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
		Where DriveTypes.DriveTypeName = 'FWD'
	)R3

-- [18] Get Total vehicles per DriveTypeName per Make and order them per Make asc per toal Desc
SELECT   Makes.Make, DriveTypes.DriveTypeName, count(DriveTypes.DriveTypeName) AS NumberOfVehicle
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID 
		INNER JOIN DriveTypes ON VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
		Group by  Makes.Make, DriveTypes.DriveTypeName
		Order by Make asc, NumberOfVehicle desc

-- [19] Get Total vehicles per DriveTypeName per Make Then Filter only returns total 10k
SELECT   Makes.Make, DriveTypes.DriveTypeName, count(DriveTypes.DriveTypeName) AS NumberOfVehicle
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID 
		INNER JOIN DriveTypes ON VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
		Group by  Makes.Make, DriveTypes.DriveTypeName having count(DriveTypes.DriveTypeName) > 10000
		Order by Make asc, NumberOfVehicle desc

-- [20] Get all vehicles that number of doors is not specified
select * from dbo.VehicleDetails Where NumDoors is Null;














