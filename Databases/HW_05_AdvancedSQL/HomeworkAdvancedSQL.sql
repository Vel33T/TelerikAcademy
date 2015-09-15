-- Homework Advanced SQL
-- Mark specific query and press F5

-- Task 1 Write a SQL query to find the names and salaries of the
-- employees that take the minimal salary in the company. Use a nested SELECT statement.
------------------------------------------------------------------------------------------------------------------------------

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary =
	(SELECT MIN(SALARY) FROM Employees)

-- Task 2 Write a SQL query to find the names and salaries of the employees 
-- that have a salary that is up to 10% higher than the minimal salary for the company.
------------------------------------------------------------------------------------------------------------------------------

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary <=
	(SELECT MIN(SALARY) FROM Employees) * 1.1

-- Task 3 Write a SQL query to find the full name, salary and department of the employees 
-- that take the minimal salary in their department. Use a nested SELECT statement.
------------------------------------------------------------------------------------------------------------------------------

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], d.Name, e.Salary
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary <=
	(
	SELECT MIN(SALARY) 
	FROM Employees
	WHERE DepartmentID = d.DepartmentID
	)
ORDER BY Salary DESC

-- Task 4 Write a SQL query to find the average salary in the department #1.
------------------------------------------------------------------------------------------------------------------------------

SELECT AVG(Salary) AS [Avarage Salary In Department #1]
FROM Employees
WHERE DepartmentID = 1

-- Task 5 Write a SQL query to find the average salary  in the "Sales" department.
------------------------------------------------------------------------------------------------------------------------------

SELECT AVG(e.Salary) AS [Avarage Salary In Sales Department]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task 6 Write a SQL query to find the number of employees in the "Sales" department.
------------------------------------------------------------------------------------------------------------------------------

SELECT COUNT(e.EmployeeID) AS [Number Of Employees In Sales Department]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task 7 Write a SQL query to find the number of all employees that have manager.
------------------------------------------------------------------------------------------------------------------------------

SELECT COUNT(EmployeeID) AS [Number Of Employees With Manager]
FROM Employees
WHERE ManagerID IS NOT NULL

-- Task 8 Write a SQL query to find the number of all employees that have no manager.
------------------------------------------------------------------------------------------------------------------------------

SELECT COUNT(EmployeeID) AS [Number Of Employees With No Manager]
FROM Employees
WHERE ManagerID IS NULL

-- Task 9 Write a SQL query to find all departments and the average salary for each of them.
------------------------------------------------------------------------------------------------------------------------------

SELECT d.Name, AVG(e.Salary) AS [Avarage Salary]
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- Task 10 Write a SQL query to find the count of all employees in each department and for each town.
------------------------------------------------------------------------------------------------------------------------------

SELECT COUNT(e.EmployeeID) AS [Number Of Employees], d.Name, t.Name
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY d.Name, t.Name

-- Task 11 Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
------------------------------------------------------------------------------------------------------------------------------

SELECT m.FirstName + ' ' + m.LastName AS [Manager], COUNT(e.EmployeeID) AS [Number Of Employees]
FROM Employees e
	JOIN Employees m
	ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5

-- Task 12 Write a SQL query to find all employees along with their managers. For employees 
-- that do not have manager display the value "(no manager)".
------------------------------------------------------------------------------------------------------------------------------

SELECT e.FirstName + ' ' + e.LastName AS [Employee], ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager]
FROM Employees e
	LEFT JOIN Employees m
	ON e.ManagerID = m.EmployeeID

-- Task 13 Write a SQL query to find the names of all employees whose last name is exactly
-- 5 characters long. Use the built-in LEN(str) function.
------------------------------------------------------------------------------------------------------------------------------

SELECT FirstName + ' ' + LastName AS [Employee]
FROM Employees
WHERE LEN(LastName) = 5

-- Task 14 Write a SQL query to display the current date and time in the following format
-- "day.month.year hour:minutes:seconds:milliseconds". Search in  Google to find how to format dates in SQL Server.
------------------------------------------------------------------------------------------------------------------------------

SELECT CONVERT(VARCHAR(30), GETDATE(), 113)

-- Task 15 Write a SQL statement to create a table Users. Users should have username, password, full name
-- and last login time. Choose appropriate data types for the table fields. Define a primary key column
-- with a primary key constraint. Define the primary key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating usernames. Define a check constraint to ensure the password
-- is at least 5 characters long.
------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Users
(
	UserId int IDENTITY PRIMARY KEY,
	Username nvarchar(50) NOT NULL UNIQUE,
	[Password] nvarchar(50) CHECK(LEN([Password]) >= 5),
	FullName nvarchar(100) NOT NULL,
	LastLogin datetime,
)

-- Task 16 Write a SQL statement to create a view that displays the users from the Users table that
-- have been in the system today. Test if the view works correctly.
------------------------------------------------------------------------------------------------------------------------------

CREATE VIEW [In System Today] AS
SELECT * FROM Users
WHERE DAY(LastLogin) = DAY(GETDATE())

INSERT Users VALUES ('Joro1', 'joreto', 'Joro Jorov', GETDATE())
INSERT Users VALUES ('Pesho1', 'pesheto', 'Pesho Peshev', DATEADD(day, -5, GETDATE()))
SELECT * FROM [In System Today]

-- Task 17 Write a SQL statement to create a table Groups. Groups should have unique name
-- (use unique constraint). Define primary key and identity column.
------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE Groups
(
	GroupId int IDENTITY PRIMARY KEY,
	Name nvarchar(50) NOT NULL UNIQUE,
)

-- Task 18 Write a SQL statement to add a column GroupID to the table Users. Fill some
-- data in this new column and as well in the Groups table. Write a SQL statement to
-- add a foreign key constraint between tables Users and Groups tables.
------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE Users 
ADD GroupId int FOREIGN KEY REFERENCES Groups(GroupId)

-- Task 19 Write SQL statements to insert several records in the Users and Groups tables.
------------------------------------------------------------------------------------------------------------------------------

INSERT Groups VALUES ('Managers')
INSERT Groups VALUES ('Employees')
INSERT Groups VALUES ('To Be Deleted')

UPDATE Users SET GroupId = 1

INSERT Users VALUES ('Lee', 'leelee', 'Lee Sin',  GETDATE(), 2);
INSERT Users VALUES ('Miss', 'missmiss', 'Miss Fortune',  GETDATE(), 2);
INSERT Users VALUES ('Le', 'lelele', 'Le Blank',  GETDATE(), 2);
INSERT Users VALUES ('Baba', 'babababa', 'Baba Meca',  GETDATE(), 2);
INSERT Users VALUES ('Shta', 'shtashta', 'Shta izkeca',  GETDATE(), 2);

-- Task 20 Write SQL statements to update some of the records in the Users and Groups tables.
------------------------------------------------------------------------------------------------------------------------------

UPDATE Users SET Username = UPPER(Username)
UPDATE Groups SET Name = LEFT(Name, 5)

-- Task 21 Write SQL statements to delete some of the records from the Users and Groups tables.
------------------------------------------------------------------------------------------------------------------------------

DELETE FROM Users WHERE Username IN('JORO1', 'PESHO1')
DELETE FROM Groups WHERE GroupId = 3

-- Task 22 Write SQL statements to insert in the Users table the names of all employees from the
-- Employees table. Combine the first and last names as a full name. For username use the first letter
-- of the first name + the last name (in lowercase). Use the same for the password, and NULL for last login time.
------------------------------------------------------------------------------------------------------------------------------

-- I don't know why this is not working :(( spend an hour to find it... lost an hour...

INSERT INTO Users
SELECT 
	LEFT(e.FirstName, 1) + '.' + LOWER(e.LastName) AS Username,
	LEFT(e.FirstName, 1) + '.' + LOWER(e.LastName) + '_blab' AS [Password],
	e.FirstName + '  ' + e.LastName AS FullName,
	GETDATE() AS LastLogin,
	2 AS GroupId
FROM Employees e


-- Task 23 Write a SQL statement that changes the [Password] to NULL for all users
-- that have not been in the system since 10.03.2010.
------------------------------------------------------------------------------------------------------------------------------

UPDATE Users SET LastLogin = NULL
WHERE LastLogin < '10.03.2010'

-- Task 24 Write a SQL statement that deletes all users without [Password]s (NULL [Password]).
------------------------------------------------------------------------------------------------------------------------------

DELETE FROM Users
WHERE [Password] IS NULL

-- Task 25 Write a SQL query to display the average employee salary by department and job title.
------------------------------------------------------------------------------------------------------------------------------

SELECT AVG(e.Salary), e.JobTitle, d.Name
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name

-- Task 26 Write a SQL query to display the minimal employee salary by department and
-- job title along with the name of some of the employees that take it.
------------------------------------------------------------------------------------------------------------------------------

SELECT MIN(e.Salary), d.Name, e.JobTitle
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name

-- Task 27 Write a SQL query to display the town where maximal number of employees work.
------------------------------------------------------------------------------------------------------------------------------

SELECT TOP 1 t.Name, COUNT(*)
FROM Employees e
	JOIN Addresses a 
	ON a.AddressID = e.AddressID
	JOIN Towns t 
	ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY COUNT(*) DESC

-- Task 28 Write a SQL query to display the number of managers from each town.
------------------------------------------------------------------------------------------------------------------------------

SELECT t.Name as Town, COUNT(e.ManagerID) AS ManagersCount
FROM Employees e
	JOIN Addresses a 
	ON e.AddressID = a.AddressID
	JOIN Towns t 
	ON t.TownID = a.TownID
WHERE e.EmployeeID in (SELECT DISTINCT ManagerID FROM Employees)
GROUP BY t.Name
ORDER BY ManagersCount DESC

-- Task 29 Write a SQL to create table WorkHours to store work reports for each employee
-- (employee id, date, task, hours, comments). Don't forget to define  identity, primary key and appropriate foreign key. 
--
-- Issue few SQL statements to insert, update and delete of some data in the table.
--
-- Define a table WorkHoursLogs to track all changes in the WorkHours table with
-- triggers. For each change keep the old record data, the new record data and the command (insert / update / delete).
------------------------------------------------------------------------------------------------------------------------------



-- Task 30 Start a database transaction, delete all employees from the 'Sales'
-- department along with all dependent records from the pother tables. At the end rollback the transaction.
------------------------------------------------------------------------------------------------------------------------------

BEGIN TRAN
DELETE FROM Employees
	SELECT d.Name
	FROM Employees e JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN

-- Task 31 Start a database transaction and drop the table EmployeesProjects.
-- Now how you could restore back the lost table data?
------------------------------------------------------------------------------------------------------------------------------

BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN

-- Task 32 Find how to use temporary tables in SQL Server. Using temporary tables backup all records from
-- EmployeesProjects and restore them back after dropping and re-creating the table.
------------------------------------------------------------------------------------------------------------------------------
