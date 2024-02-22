---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------ [41-50] ------------------

use VehicleMakesDB;

select * from dbo.Bodies;
select * from dbo.SubModels ;
select * from dbo.MakeModels;
select * from dbo.DriveTypes;
select * from dbo.Makes;
select * from dbo.FuelTypes;
select * from dbo.VehicleDetails;

-- [41] Get all Makes that has one of  the max 3 Engine CC
SELECT Distinct Makes.Make, VehicleDetails.Engine_CC
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Where Engine_CC in (select  Distinct Top 3 Engine_CC from VehicleDetails order by Engine_CC Desc);

-- [42] Get a table of unique Engine_CC and calculate tak per Engine_cc
SELECT Distinct Engine_CC, Tax=
	CASE
		WHEN Engine_CC Between 0 AND 1000 THEN 100
		WHEN Engine_CC Between 1001 AND 2000 THEN 200
		WHEN Engine_CC Between 2001 AND 4000 THEN 300
		WHEN Engine_CC Between 4001 AND 6000 THEN 400
		WHEN Engine_CC Between 6001 AND 8000 THEN 500
		WHEN Engine_CC > 8000 THEN 600
		ELSE 0
	END
	FROM VehicleDetails Order by Engine_CC;
--------------------------------------------------------
	SELECT Engine_CC, Tax=
	CASE
		WHEN Engine_CC Between 0 AND 1000 THEN 100
		WHEN Engine_CC Between 1001 AND 2000 THEN 200
		WHEN Engine_CC Between 2001 AND 4000 THEN 300
		WHEN Engine_CC Between 4001 AND 6000 THEN 400
		WHEN Engine_CC Between 6001 AND 8000 THEN 500
		WHEN Engine_CC > 8000 THEN 600
		ELSE 0
	END
	FROM(SELECT Distinct Engine_CC FROM VehicleDetails)R4
	Order by Engine_CC;

-- [43] Get Make and Total Number of Doors Manufactured per Make
SELECT Makes.Make, Sum(VehicleDetails.NumDoors) AS CountOfVehicles
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Group by Make Order by CountOfVehicles;

-- [44] et Make and Total Number of Doors Manufactured by 'Ford'
SELECT Makes.Make, Sum(VehicleDetails.NumDoors) AS CountOfVehicles
		FROM VehicleDetails 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Group by Make Having Makes.Make = 'Ford'
		Order by CountOfVehicles;
-- [45] Get Number of Models per Make
SELECT Makes.Make, Count(MakeModels.ModelName) AS CountOfModels
	FROM MakeModels 
	INNER JOIN Makes ON MakeModels.MakeID = Makes.MakeID
	Group by Makes.Make
	Order by CountOfModels Desc;

-- [46] Get the Highest 3 manufacturers that make the highest number of Models
SELECT Top 3 Makes.Make, Count(*) AS CountOfModels
	FROM MakeModels 
	INNER JOIN Makes ON MakeModels.MakeID = Makes.MakeID
	Group by Makes.Make
	Order by CountOfModels Desc;

-- [47] Get the highest number of models manufastured
SELECT MAX(CountOfModels) FROM (SELECT  Count(*) AS CountOfModels
	FROM MakeModels 
	INNER JOIN Makes ON MakeModels.MakeID = Makes.MakeID
	Group by Makes.Make)R4

-- [48] Get the highest Make number of model
SELECT Makes.Make,Count(*) AS NumberOfModels
		FROM Makes
		INNER JOIN MakeModels ON Makes.MakeID =	MakeModels.MakeID
		Group by Makes.Make 
		Having Count(*) = 
		(
			SELECT Max(NumberOfModels) AS MaxNumberOfModels From 
			(
				SELECT MakeID,Count(*) AS NumberOfModels from MakeModels
				Group by MakeID
			)R1
		)

-- [49] Get the lowest Make number of model
SELECT Makes.Make,Count(*) AS NumberOfModels
		FROM Makes
		INNER JOIN MakeModels ON Makes.MakeID =	MakeModels.MakeID
		Group by Makes.Make 
		Having Count(*) = 
		(
			SELECT Min(NumberOfModels) AS MaxNumberOfModels From 
			(
				SELECT MakeID,Count(*) AS NumberOfModels from MakeModels
				Group by MakeID
			)R1
		)

-- [50] Get all Fuel type, each time the result should be showed in randdom order
select * from dbo.FuelTypes order by NEWID();
