-- Create DB
CREATE DATABASE performancedb
	CHARACTER SET = 'utf8'
	COLLATE = 'utf8_general_ci'

USE performancedb

-- Create and split table
CREATE TABLE logs (
	logID INT NOT NULL,
	logDate DATETIME NOT NULL,
	logContent VARCHAR(1000) NOT NULL
)
PARTITION BY RANGE ( YEAR(logDate) ) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (2000),
    PARTITION p2 VALUES LESS THAN MAXVALUE
);

-- Create filling procedure that generates N entries with random date in the range [ now - vYears; now ]
DELIMITER $$
CREATE PROCEDURE up_filldata (
	IN vLogsTotal INT,
	IN vYears INT
)
BEGIN
	DECLARE vIterator INT;
	SET vIterator = 0;
        WHILE (vIterator < vLogsTotal)
        DO
        	INSERT INTO Logs (
                	logDate,
                        logContent
                )
            	VALUES (
                	NOW() - INTERVAL FLOOR(RAND() * vYears) YEAR,
                    'Lorem Ipsum Dolor Sit Amet'
                );
        	SET vIterator = vIterator + 1;
	END WHILE;
END;
$$
DELIMITER ;

-- Fill with 1 000 000 entries
-- If you can wait that long...
CALL up_filldata ( 1000000, 30 );

-- Search in multiple partitions
SELECT *
FROM Logs
WHERE LogDate
	BETWEEN '1989-12-01 23:00:00.000'
	AND '1991-01-31 23:00:00.000'

-- Search in single partition
SELECT *
FROM Logs
WHERE LogDate
	BETWEEN '1985-01-01 23:00:00.000'
	AND '1986-01-01 23:00:00.000'
