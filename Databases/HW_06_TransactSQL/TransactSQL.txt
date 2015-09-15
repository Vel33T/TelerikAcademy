-- Task 1 Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and 
-- Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. Write a stored 
-- procedure that selects the full names of all persons.

CREATE DATABASE BankAccount
GO
 
USE BankAccount
CREATE TABLE Persons (
	PersonID int IDENTITY PRIMARY KEY,
	FirstName nvarchar(100) NOT NULL,
	LastName nvarchar(100) NOT NULL,
	SSN int NOT NULL
)
GO
CREATE TABLE Accounts (
	AccountID INT IDENTITY PRIMARY KEY,
	Balance money DEFAULT 0,
	PersonId INT NULL FOREIGN KEY REFERENCES Persons(PersonId)
)

GO
 
INSERT INTO Persons(FirstName, LastName, SSN) VALUES ('Gosho', 'Goshov', 41223234)
INSERT INTO Persons(FirstName, LastName, SSN) VALUES ('Penyo', 'Penyov', 42342345)
INSERT INTO Persons(FirstName, LastName, SSN) VALUES ('Pesho', 'Peshov', 36346456)
INSERT INTO Persons(FirstName, LastName, SSN) VALUES ('Joro', 'Jorov', 3123123)
INSERT INTO Accounts(Balance, PersonId) VALUES (200, 2)
INSERT INTO Accounts(Balance, PersonId) VALUES (300, 3)
INSERT INTO Accounts(Balance, PersonId) VALUES (400, 4)
GO
 
CREATE PROC dbo.usp_SelectFullNames
AS
	SELECT  CONCAT(FirstName, ' ', LastName) AS [FULL Name]
	FROM Persons
GO
 
EXEC usp_SelectFullNames
GO

-- Task 2 Create a stored procedure that accepts a number as a parameter and returns
-- all persons who have more money in their accounts than the supplied number.

CREATE PROC dbo.usp_SelectPersonMoreMoney (@moneybalance money)
AS
	SELECT  CONCAT(FirstName, ' ', LastName) AS [FULL Name], a.Balance
	FROM Persons p
		JOIN Accounts a
		ON a.PersonId = p.PersonID
	WHERE a.Balance > @moneybalance
	ORDER BY a.Balance
GO

EXEC usp_SelectPersonMoreMoney 200

-- Task 3 Create a function that accepts as parameters – sum, yearly interest rate and number
-- of months. It should calculate and return the new sum. Write a SELECT to test whether
-- the function works as expected.

CREATE FUNCTION fn_CalcInterest(@SUM money, @yearlyInterest numeric(18, 2), @months int)
	RETURNS NUMERIC(18, 2)
AS
BEGIN
	RETURN (@yearlyInterest / 12) * @months * @SUM + @SUM
END
GO
 
SELECT dbo.fn_CalcInterest(500, 0.2, 5)
GO

-- Task 4 Create a stored procedure that uses the function from the previous example to give
-- an interest to a person's account for one month. It should take the AccountId and the
-- interest rate as parameters.

CREATE PROC dbo.usp_CalculateInterest (@accountID int, @yearlyInterest numeric(18, 2))
AS
	UPDATE Accounts
	SET Balance = CONVERT(money, dbo.fn_CalcInterest(Balance, @yearlyInterest, 1))
	WHERE AccountID = @accountID
GO
 
EXEC dbo.usp_CalculateInterest 2,0.2
GO

-- Task 5 Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney
-- (AccountId, money) that operate in transactions.

CREATE PROC dbo.usp_WithdrawMoney (@accountID int, @money money)
AS
BEGIN TRAN
	UPDATE Accounts
	SET Balance = Balance - @money
	WHERE AccountID = @accountID
COMMIT TRAN
GO

CREATE PROC dbo.usp_DepositMoney (@accountID int, @money money)
AS
BEGIN TRAN
	UPDATE Accounts
	SET Balance = Balance + @money
	WHERE AccountID = @accountID
	COMMIT TRAN
GO
 
EXEC dbo.usp_WithdrawMoney 2, 50
EXEC dbo.usp_WithdrawMoney 1, 50
EXEC dbo.usp_DepositMoney 1, 200
GO

-- Task 6 Create another table – Logs(LogID, AccountID, OldSum, NewSum). Add a trigger to
-- the Accounts table that enters a new entry into the Logs
-- table every time the sum on an account changes.

CREATE TABLE Logs (
	LogID int IDENTITY PRIMARY KEY,
	OldSum money NOT NULL,
	NewSum money NOT NULL,
	AccountID int NOT NULL FOREIGN KEY REFERENCES Accounts(AccountID)
)
GO
 
CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
	INSERT INTO Logs (OldSum, NewSum, AccountID)
	SELECT d.Balance, i.Balance, d.AccountID
	FROM deleted AS d
		JOIN inserted AS i
		ON d.AccountID = i.AccountID
GO
 
EXEC dbo.usp_DepositMoney 1, 200
GO