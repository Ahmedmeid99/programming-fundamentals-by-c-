
use C21_DB1;


-- Inserting sample data into EmployeeAttendance
CREATE TABLE EmployeeAttendance (
    RecordID INT PRIMARY KEY,
    EmployeeID INT,
    AttendanceDate DATE,
    Status VARCHAR(10) -- Values could be 'Present', 'Absent', 'Leave'
);

-- Inserting sample data into EmployeeAttendance
INSERT INTO EmployeeAttendance (RecordID, EmployeeID, AttendanceDate, Status) VALUES (1, 101, '2023-07-01', 'Present');
INSERT INTO EmployeeAttendance (RecordID, EmployeeID, AttendanceDate, Status) VALUES (2, 102, '2023-07-01', 'Absent');
INSERT INTO EmployeeAttendance (RecordID, EmployeeID, AttendanceDate, Status) VALUES (3, 103, '2023-07-01', 'Leave');
INSERT INTO EmployeeAttendance (RecordID, EmployeeID, AttendanceDate, Status) VALUES (4, 101, '2023-07-02', 'Present');
INSERT INTO EmployeeAttendance (RecordID, EmployeeID, AttendanceDate, Status) VALUES (5, 102, '2023-07-02', 'Present');
-- Add more data as needed

