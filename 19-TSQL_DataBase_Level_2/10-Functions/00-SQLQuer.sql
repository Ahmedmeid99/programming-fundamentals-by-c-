

use C21_DB1

Select *, ROW_NUMBER() Over (order by Name) as Number from Employees; -- 12345

-- 3	Emily Davis	    2	2023-03-20	1
-- 2	Jane Doe	    3	2023-02-15	2
-- 1	John Smith	    3	2023-01-10	3
-- 4	Michael Brown	1	2022-11-05	4
-- 5	Sarah Miller	4	2023-01-05	5

Select *, Rank()  Over (order by Balance) as Number from Accounts  --1134567 

-- 5	100.00	1
-- 6	100.00	1
-- 3	120.00	3
-- 7	230.00	4
-- 4	233.00	5
-- 1	250.00	6
-- 2	270.00	7

Select *, Dense_Rank()  Over (order by Balance) as Number from Accounts  --1123456 -- works good with students Grade

-- 5	100.00	1
-- 6	100.00	1
-- 3	120.00	2
-- 7	230.00	3
-- 4	233.00	4
-- 1	250.00	5
-- 2	270.00	6

Select * , Rank() over (Partition by Department order by Salary) as Number from Employees2 -- HR 123 -- IT 12345 -- Marketing 12345678

-- Employee 16	      HR	59616	91	1
-- Employee 3	      HR	65631	80	2
-- Employee 6	      HR	72678	96	3
-- Employee 9	      HR	96016	69	4
-- Employee 15	      IT	66887	92	1
-- Employee 10	      IT	88321	94	2
-- Employee 12	      IT	113425	65	3
-- Employee 19	Marketing	57671	95	1
-- Employee 17	Marketing	65336	66	2
-- Employee 2	Marketing	69239	75	3

Select Name,Department,Salary,avg(Salary)  over (Partition by Department) as AVGGrade from Employees2

-- Employee 3	      HR	65631	90532
-- Employee 4	      HR	97942	90532
-- Employee 8	      HR	117597	90532
-- Employee 10	      IT	88321	96527
-- Employee 5	      IT	117478	96527
-- Employee 12	      IT	113425	96527
-- Employee 15	      IT	66887	96527
-- Employee 1	Marketing	99716	94238
-- Employee 2	Marketing	69239	94238
-- Employee 11	Marketing	123774	94238

SELECT 
    Name,Department,Salary,
    LAG(Salary, 1) OVER (ORDER BY Department DESC) AS PreviousGrade,
    Salary,
    LEAD(Salary, 1) OVER (ORDER BY Department DESC) AS NextGrade
FROM 
    Employees2
ORDER BY Department DESC;

-- Employee 1	Marketing	99716	NULL	99716	69239
-- Employee 2	Marketing	69239	99716	69239	101190
-- Employee 7	Marketing	101190	69239	101190	123774
-- Employee 11	Marketing	123774	101190	123774	92557
-- Employee 14	Marketing	92557	123774	92557	65336
-- Employee 17	Marketing	65336	92557	65336	112501
-- Employee 18	Marketing	112501	65336	112501	57671
-- Employee 19	Marketing	57671	112501	57671	126163
-- Employee 20	Marketing	126163	57671	126163	66887
-- Employee 15	      IT	66887	126163	66887	113425
-- Employee 12	      IT	113425	66887	113425	117478
-- Employee 5	      IT	117478	113425	117478	88321
-- Employee 10	      IT	88321	117478	88321	72678
-- Employee 6	      HR	72678	88321	72678	117597
-- Employee 8	      HR	117597	72678	117597	96016
-- Employee 9	      HR	96016	117597	96016	65631
-- Employee 3	      HR	65631	96016	65631	97942
-- Employee 4	      HR	97942	65631	97942	124250
-- Employee 13	      HR	124250	97942	124250	59616
-- Employee 16	      HR	59616	124250	59616	NULL
 
 
 --------------------------
 -- Pagination
 --------------------------

 Declare @PageNumber  int ,@RowsPerPage int;

 Set @PageNumber  = 2 ;Set @RowsPerPage = 7;

 SELECT *
FROM Employees2
ORDER BY Department
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS -- to Scipe count of Reocords 
FETCH NEXT @RowsPerPage ROWS ONLY; -- To Get count of Reocords 


-- Employee 10	      IT	88321	94
-- Employee 5	      IT	117478	72
-- Employee 12	      IT	113425	65
-- Employee 15	      IT	66887	92
-- Employee 1	Marketing	99716	81
-- Employee 2	Marketing	69239	75
-- Employee 11	Marketing	123774	88