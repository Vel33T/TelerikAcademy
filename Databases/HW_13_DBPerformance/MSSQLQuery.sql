-- Use or Create DB
USE PerformanceDB

-- Add Table
CREATE TABLE Logs (
	LogID int PRIMARY KEY IDENTITY NOT NULL,
	LogDate datetime NOT NULL,
	LogContent nvarchar(1000) NOT NULL
)
GO

-- Declare fill procedure
CREATE PROC usp_FillLogs
	@logsTotal int
AS
DECLARE
	@iterator int = 0
WHILE (@iterator < @logsTotal)
BEGIN
	DECLARE @dateTime datetime = GETDATE()
	INSERT INTO Logs
	VALUES (
		@dateTime,
		'(LogID:' +
			CONVERT(nvarchar, @iterator) +
			';LogDate:' +
			CONVERT(nvarchar, @dateTime) +
			') Lorem Ipsum Dolor Sit Amet'
	)
	SET @iterator = @iterator + 1;
END
GO

-- Fill with 10 000 000 entries
-- Expect around 5GB for both mdf and ldf files
-- This may take a while...
EXEC usp_FillLogs 10000000

-- Clear cache
CHECKPOINT; DBCC DROPCLEANBUFFERS;

-- Create an index over LogDate
CREATE INDEX ix_Logs_LogDate ON Logs(LogDate)

-- Create an index over LogContent
CREATE INDEX ix_Logs_LogContent ON Logs(LogContent)

-- Use statistics for all queries
-- SET STATISTICS TIME ON
-- query..
-- SET STATISTICS TIME OFF

-- Search by date range
SELECT *
FROM Logs
WHERE LogDate
	BETWEEN '2013-07-18 23:00:00.000'
	AND '2013-07-18 23:00:05.000'

-- Search by content left match
SELECT *
FROM Logs
WHERE LogContent LIKE '(LogID:155%'

-- Search by content right match
SELECT *
FROM Logs
WHERE LogContent LIKE '%50PM) Lorem Ipsum Dolor Sit Amet'

-- Search by content double match
SELECT *
FROM Logs
WHERE LogContent LIKE '%LogData%'

-- Results:
-- - filling data : 3h 51m 23s 352ms
--
-- - date range search - 4846 rows
--   - base search : 25s 617ms
--   - cached search : 841ms
--   - indexed search : 285 ms
--
-- - left content match - 11111 rows
--   - base search : 24s 136ms
--   - cached search : 2s 494ms
--   - indexed search : 909ms
--
-- - right content match - 40116
--   - base search : 1m 13s 709ms
--   - cached search : 50s 051ms
--   - indexed search : 39s 139ms
--
-- - double content match
--   - base search : 1m 21s 887ms
--   - cached search : 1m 5s 491ms
--   - indexed search : 1m 3s 421ms
--
--   date index creation : 1m 52s 214ms
--   content index creation : 12m 39s 528ms