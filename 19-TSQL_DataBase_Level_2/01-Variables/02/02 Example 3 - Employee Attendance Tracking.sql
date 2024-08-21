

-- This script generates an employee attendance report for a specified month and year.
-- It tracks the number of days present, absent, and on leave for a particular employee.

-- Declare variables
DECLARE @ReportMonth INT;
DECLARE @ReportYear INT;
DECLARE @TotalDays INT;
DECLARE @EmployeeID INT;
DECLARE @PresentDays INT;
DECLARE @AbsentDays INT;
DECLARE @LeaveDays INT;

-- Initialize variables
SET @ReportMonth = 7; -- Set the month for the report
SET @ReportYear = 2023; -- Set the year for the report
SET @EmployeeID = 101; -- Set the Employee ID for the report

-- Calculate total days in the month
SET @TotalDays = DAY(EOMONTH(DATEFROMPARTS(@ReportYear, @ReportMonth, 1)));
------------------------------
--			Note
------------------------------
print DATEFROMPARTS(@ReportYear, @ReportMonth, 1) -- 2023-07-01
print '-------------------------------------';
print EOMONTH(DATEFROMPARTS(@ReportYear, @ReportMonth, 1)) -- 2023-07-31
print '-------------------------------------';
-----------------------------------------------

-- Calculate present, absent, and leave days
SELECT @PresentDays = COUNT(*)
FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID AND MONTH(AttendanceDate) = @ReportMonth AND YEAR(AttendanceDate) = @ReportYear AND Status = 'Present';

SELECT @AbsentDays = COUNT(*)
FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID AND MONTH(AttendanceDate) = @ReportMonth AND YEAR(AttendanceDate) = @ReportYear AND Status = 'Absent';

SELECT @LeaveDays = COUNT(*)
FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID AND MONTH(AttendanceDate) = @ReportMonth AND YEAR(AttendanceDate) = @ReportYear AND Status = 'Leave';

-- Print the report
PRINT 'Employee Attendance Report for Employee ID: ' + CAST(@EmployeeID AS VARCHAR);
PRINT 'Report Month: ' + CAST(@ReportMonth AS VARCHAR) + '/' + CAST(@ReportYear AS VARCHAR);
PRINT 'Total Working Days: ' + CAST(@TotalDays AS VARCHAR);
PRINT 'Days Present: ' + CAST(@PresentDays AS VARCHAR);
PRINT 'Days Absent: ' + CAST(@AbsentDays AS VARCHAR);
PRINT 'Days on Leave: ' + CAST(@LeaveDays AS VARCHAR);
