

WITH Numbers AS (


    SELECT 1 AS Number
    
	UNION ALL
   
    SELECT Number + 1 FROM Numbers WHERE Number < 10
)
SELECT * FROM Numbers;

With NUMS AS (

	Select 1 as NUMS
	UNION ALL
	Select NUMS + 1 from NUMS where NUMS < 10
)

select * from NUMS;

