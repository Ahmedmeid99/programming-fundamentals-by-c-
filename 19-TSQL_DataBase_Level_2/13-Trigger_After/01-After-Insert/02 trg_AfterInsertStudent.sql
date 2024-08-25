
CREATE TRIGGER trg_AfterInsertStudent ON Students
AFTER INSERT

AS
BEGIN
  
    INSERT INTO StudentInsertLog(StudentID, Name, Subject, Grade) -- insert what will came back (return) from select
    SELECT StudentID, Name, Subject, Grade FROM inserted; -- inserted this is a temp table 

END;
