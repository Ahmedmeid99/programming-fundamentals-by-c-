--------------------------------
----------[Constraint]----------
--------------------------------
-- Default
-- Check
-- Unique
-- Indexs
--------------------------------

Create Table Men(
ID INT Identity PRIMARY KEY,
F_Name varchar(255) NOT NULL,
L_Name varchar(255) NOT NULL,
UserName varchar(255) Unique NOT NULL,
Experiance int CHECK(Experiance >= 0),
Gendor char(1) DEFAULT 'M' NOT NULL
)

--drop Table Men;

Insert Into Men
--Values ('Ali','Eid','AbuAli',-1) -- Field Experiance Must be More than 0
--Values ('Ali','Eid','AbuEid',0)  -- Field UserName Must be Uique
Values ('Ahmed','Eid','AbuEid','M',1);

Create Index I_LastName on Employees(LastName);

