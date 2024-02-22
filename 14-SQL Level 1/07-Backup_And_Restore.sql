----------------------------------
-- Backup and Restore
----------------------------------

-- Create file and save database in it
Backup database Company
to disk ='E:\Test\Company.bak';

-- Save Differences to exists file 
Backup database Company
to disk ='E:\Test\Company.bak'
with Differential;

-- drop database to restore it again
use master;
alter database Company set single_user with rollback immediate;
IF EXISTS (SELECT * From sys.databases WHERE name = 'Company')
BEGIN
	Drop Database Company;
END;

-- Restore Database from file Company.bak
Restore database Company
FROM disk ='E:\Test\Company.bak';

Restore database HR_Database
FROM disk ='E:\Test\HR_Database.bak';