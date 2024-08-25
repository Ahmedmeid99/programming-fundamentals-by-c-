
use C21_DB1;

-- Inserting a new student
INSERT INTO Students (StudentID, Name, Subject, Grade)
VALUES (110, 'ALi Doe', 'Mathematics', 75); -- will insert also new record in log table

-- (1 row affected)

-- (1 row affected)

-- Checking the log table
SELECT * FROM StudentInsertLog;