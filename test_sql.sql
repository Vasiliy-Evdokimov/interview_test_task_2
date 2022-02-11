USE [sql-ex];

/*
Блок заданий 1
*/

/*
Задание 1.1
*/

WITH T1
AS (
	SELECT
		ROW_NUMBER() OVER (PARTITION BY B_Q_ID, utV.V_COLOR ORDER BY B_Q_ID, utV.V_COLOR ASC) as RN,
		B_Q_ID, 
		B_V_ID, 
		utV.V_NAME,
		utV.V_COLOR, 
		SUM(B_VOL) as SUM_VOL
	FROM
		utB, utV
	WHERE 
		(utB.B_V_ID = utV.V_ID) AND 
		(utB.B_Q_ID IN (SELECT B_Q_ID FROM utB GROUP BY B_Q_ID HAVING SUM(B_VOL) = 255 * 3)) 
	GROUP BY B_Q_ID, B_V_ID, utV.V_NAME, utV.V_COLOR	
),
T2 
AS (	
	SELECT DISTINCT B_Q_ID,	RN FROM T1	
),
T3
AS (
	SELECT 
		utQ.Q_NAME,
		T2.RN as [rank],
		(SELECT V_NAME FROM T1 WHERE (T2.B_Q_ID = T1.B_Q_ID) AND (T2.RN = T1.RN) AND (T1.V_COLOR = 'R')) as r,  
		(SELECT V_NAME FROM T1 WHERE (T2.B_Q_ID = T1.B_Q_ID) AND (T2.RN = T1.RN) AND (T1.V_COLOR = 'G')) as g,
		(SELECT V_NAME FROM T1 WHERE (T2.B_Q_ID = T1.B_Q_ID) AND (T2.RN = T1.RN) AND (T1.V_COLOR = 'B')) as b
	FROM 
		T2, utQ
	WHERE 
		T2.B_Q_ID = utQ.Q_ID		
)
SELECT * FROM T3;

/*
Задание 1.2
*/

WITH T2 AS
(
	SELECT
		T1.*,
		CHAR(64 + T1.C_NO) + CAST(T1.R_NO as varchar(1)) AS C_NAME,
		CASE 
			WHEN ((R_NO % 2 = 1) AND (C_NO % 2 = 1)) 
			  OR ((R_NO % 2 = 0) AND (C_NO % 2 = 0)) 
			THEN 1 ELSE 0
		END AS MUST_BLACK
	FROM
		(
			SELECT 
				ROW_NUMBER() OVER (ORDER BY Q_ID ASC) as RN,
				(ROW_NUMBER() OVER (ORDER BY Q_ID ASC) - 1) / 8 + 1 AS R_NO, 
				(ROW_NUMBER() OVER (ORDER BY Q_ID ASC) - 1) % 8 + 1 AS C_NO,
				ISNULL(SUM_VOL, 0) AS SUM_VOL
			FROM [utQ]
			LEFT JOIN
				(
					SELECT 	
						B_Q_ID, 
						SUM(B_VOL) as SUM_VOL
					FROM
						[utB]
					GROUP BY B_Q_ID
				) T0 ON [utQ].Q_ID = T0.B_Q_ID
		) T1
) 
SELECT
	--количество квадратов на своих местах (цвет клетки шахматной доски и квадрата совпадают);
	(SELECT COUNT(*) FROM T2 WHERE (MUST_BLACK = 1) AND (SUM_VOL = 0)) +
	(SELECT COUNT(*) FROM T2 WHERE (MUST_BLACK = 0) AND (SUM_VOL = 765)) as ok,
	--количество квадратов, которые должны быть черными, но таковыми не являются;
	(SELECT COUNT(*) FROM T2 WHERE (MUST_BLACK = 1) AND (SUM_VOL > 0)) as filed,
	--количество белых клеток, для которых не хватило квадратов; 
	32 - (SELECT COUNT(*) FROM T2 WHERE (MUST_BLACK = 0)) as white,
	--количество черных клеток, для которых не хватило квадратов;
	32 - (SELECT COUNT(*) FROM T2 WHERE (MUST_BLACK = 1)) as black,
	--количество краски, необходимое для окраски существующих квадратов до необходимого белого цвета;
	(SELECT COUNT(*) * 765 - SUM(SUM_VOL) FROM T2 WHERE (MUST_BLACK = 0) AND (SUM_VOL < 765)) as color,
	--координаты последнего квадрата на доске.
	(SELECT TOP 1 C_NAME FROM T2 ORDER BY RN DESC) as place;

/*
Блок заданий 2
*/

/*
Задание 2.1
*/

SELECT TOP 1 * FROM 
(	
SELECT
	P.name as name, 
	SUM(
		CASE
			WHEN time_out <= time_in 
			THEN DATEDIFF(MINUTE, time_out, time_in)
			ELSE DATEDIFF(MINUTE, time_out, DATEADD(day, 1, time_in))
		END) as totalTimeFly,
	C.name as company
FROM 
	Pass_in_trip PIT, 
	Trip T, 
	Passenger P, 
	Company C
WHERE 
	(PIT.trip_no = T.trip_no) AND
	(PIT.ID_psg = P.ID_psg) AND 
	(T.ID_comp = C.ID_comp)
GROUP BY P.name, C.name
) T1 
ORDER BY totalTimeFly DESC;

/*
Задание 2.2
*/

WITH T AS
(
SELECT 
	PIT.trip_date,
	COUNT(*) as trip_count
FROM 
	Trip T, 
	(SELECT DISTINCT trip_no, [date] as trip_date FROM Pass_in_trip) PIT
WHERE
	T.trip_no = PIT.trip_no AND
	T.town_from = 'Rostov'
GROUP BY PIT.trip_date
) 
SELECT 
	trip_count as cnt,
	trip_date as 'date'
FROM T 
WHERE trip_count = (SELECT MAX(trip_count) FROM T)
ORDER BY trip_date ASC;