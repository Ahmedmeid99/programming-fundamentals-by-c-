
use C21_DB1;
Go

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    Balance DECIMAL(10, 2)
);

Go

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    FromAccount INT,
    ToAccount INT,
    Amount DECIMAL(10, 2),
    Date DATETIME
);

Go

-- Insert sample data into Accounts
INSERT INTO Accounts (AccountID, Balance) VALUES (1, 500.00); -- Account 1 with $500
INSERT INTO Accounts (AccountID, Balance) VALUES (2, 300.00); -- Account 2 with $300



