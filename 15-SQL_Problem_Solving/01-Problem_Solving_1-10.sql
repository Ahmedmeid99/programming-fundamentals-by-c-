---------------------------------------
--------[SQL Solve Problems]-----------
---------------------------------------
------------- [1-10] ------------------

restore Database VehicleMakesDB
from Disk='E:\Test\VehicleMakesDB.bak'

use VehicleMakesDB;

select * from dbo.Bodies;
select * from dbo.SubModels;
select * from dbo.MakeModels;
select * from dbo.DriveTypes;
select * from dbo.Makes;
select * from dbo.FuelTypes;
select * from dbo.VehicleDetails;


-- [1] Create Master View 
Create View VehicleMasterDetails As
	select dbo.VehicleDetails.ID,
	dbo.VehicleDetails.MakeID ,          dbo.Makes.Make,
	dbo.VehicleDetails.ModelID,          dbo.MakeModels.ModelName,
	dbo.VehicleDetails.SubModelID,       dbo.SubModels.SubModelName,
	dbo.VehicleDetails.BodyID,           dbo.Bodies.BodyName,
	Vehicle_Display_Name,                dbo.VehicleDetails.Year,
	dbo.VehicleDetails.DriveTypeID,      dbo.DriveTypes.DriveTypeName,
	dbo.VehicleDetails.Engine,           dbo.VehicleDetails.Engine_CC,
	dbo.VehicleDetails.Engine_Cylinders, dbo.VehicleDetails.Engine_Liter_Display,
	dbo.VehicleDetails.FuelTypeID,       dbo.FuelTypes.FuelTypeName,dbo.VehicleDetails.NumDoors
	from dbo.VehicleDetails
		JOIN dbo.Makes      ON dbo.VehicleDetails.MakeID      = dbo.Makes.MakeID
		JOIN dbo.MakeModels ON dbo.VehicleDetails.ModelID     = dbo.MakeModels.ModelID
		JOIN dbo.SubModels  ON dbo.VehicleDetails.SubModelID  = dbo.SubModels.SubModelID
		JOIN dbo.Bodies     ON dbo.VehicleDetails.BodyID      = dbo.Bodies.BodyID
		JOIN dbo.DriveTypes ON dbo.VehicleDetails.DriveTypeID = dbo.DriveTypes.DriveTypeID
		JOIN dbo.FuelTypes  ON dbo.VehicleDetails.FuelTypeID  = dbo.FuelTypes.FuelTypeID;

Select * from VehicleMasterDetails;

-- [2] Get all Vehicles make between 1950 : 2000
select * from dbo.VehicleDetails Where Year between 1950 and 2000;

-- [3] Get number make between 1950 : 2000
select count(Year) from dbo.VehicleDetails Where Year between 1950 and 2000;

-- [4] Get number make between 1950 : 2000 per Make and order by Name of Vehicles Desc
select dbo.Makes.Make,NumberOfVehicles = Count(dbo.VehicleDetails.Vehicle_Display_Name) 
		from dbo.VehicleDetails JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID
		Where Year between 1950 and 2000
		Group by (dbo.Makes.Make) order by Count(dbo.VehicleDetails.Vehicle_Display_Name) desc ;

-- [5] Get all Makes that have create > 1200 make between 1950 : 2000
select dbo.Makes.Make,NumberOfVehicles = Count(dbo.VehicleDetails.Vehicle_Display_Name) 
		from dbo.VehicleDetails JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID
		Where (Year between 1950 and 2000 )
		Group by (dbo.Makes.Make) having Count(dbo.VehicleDetails.Vehicle_Display_Name) >=12000
		order by Count(dbo.VehicleDetails.Vehicle_Display_Name) desc ;
----------------------------------------------------------------
select * from
	(
		SELECT dbo.Makes.Make, NumberOfVehicles = Count(*) 
		from dbo.VehicleDetails JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID
		Where (dbo.VehicleDetails.Year between 1950 and 2000 )
		Group by dbo.Makes.Make
	) R1
Where NumberOfVehicles >=12000

-- [6] select dbo.Makes.Make,NumberOfVehicles = Count(dbo.VehicleDetails.Vehicle_Display_Name) 
select dbo.Makes.Make, NumberOfVehicles = Count(dbo.VehicleDetails.Vehicle_Display_Name), TotalVehicles = (select count(ID) from dbo.VehicleDetails)
		from dbo.VehicleDetails JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID
		Where (Year between 1950 and 2000 )
		Group by (dbo.Makes.Make)
		order by Count(dbo.VehicleDetails.Vehicle_Display_Name) desc ;

-- [7]  Get number,Calculate it`s percentage
select * , CAST(NumberOfVehicles AS float)/CAST(TotalVehicles AS float) AS Perc from
	(
		SELECT dbo.Makes.Make, NumberOfVehicles = Count(*), TotalVehicles = (select count(*) from dbo.VehicleDetails)
		from dbo.VehicleDetails JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID
		Where (Year between 1950 and 2000 )
		Group by (dbo.Makes.Make)
	)R2
order by NumberOfVehicles desc;

--[8] Get Make , FueltypeName , and Number of Vehicles per FueltypeNam, Make
SELECT	dbo.Makes.Make, dbo.FuelTypes.FuelTypeName 
		,count(*) AS NumberOfVehices
		from dbo.VehicleDetails
		JOIN dbo.Makes ON dbo.VehicleDetails.MakeID = dbo.Makes.MakeID 
		JOIN dbo.FuelTypes ON dbo.VehicleDetails.FuelTypeID = dbo.FuelTypes.FuelTypeID
		Where dbo.VehicleDetails.Year between 1950 and 2000 
		group by  dbo.FuelTypes.FuelTypeName ,dbo.Makes.Make
		order by dbo.Makes.Make

-- [9] Get Make , FueltypeName , and Number of Vehicles per FueltypeNam, Make runs with 'GAS'
SELECT	*
		from dbo.VehicleDetails
		JOIN dbo.FuelTypes ON dbo.VehicleDetails.FuelTypeID = dbo.FuelTypes.FuelTypeID
		Where dbo.FuelTypes.FuelTypeName =N'GAS'

-- [10] Get All Makes that runs with 'GAS'
SELECT Makes.Make, FuelTypes.FuelTypeName
		FROM FuelTypes 
		INNER JOIN VehicleDetails ON FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Group by Makes.Make, FuelTypes.FuelTypeName having dbo.FuelTypes.FuelTypeName =N'GAS'
----------------------------------------------------------------------------------------------
SELECT Makes.Make, FuelTypes.FuelTypeName
		FROM FuelTypes 
		INNER JOIN VehicleDetails ON FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Where dbo.FuelTypes.FuelTypeName =N'GAS'
		Group by Makes.Make, FuelTypes.FuelTypeName  
----------------------------------------------------------------------------------------------
SELECT distinct Makes.Make, FuelTypes.FuelTypeName
		FROM FuelTypes 
		INNER JOIN VehicleDetails ON FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID 
		INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
		Where dbo.FuelTypes.FuelTypeName =N'GAS'
