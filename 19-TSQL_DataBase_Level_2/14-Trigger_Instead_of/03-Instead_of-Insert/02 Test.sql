
INSERT INTO StudentView (StudentID, Name, Address, Course, Grade)
VALUES (300, 'abbas', '789 Pine Rd', 'Physics', 50);

-- (1 row affected)

-- (1 row affected)

-- (1 row affected)

SELECT * FROM PersonalInfo WHERE StudentID = 300;
SELECT * FROM AcademicInfo WHERE StudentID = 300;
