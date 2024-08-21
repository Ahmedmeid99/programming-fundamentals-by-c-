DECLARE @Balance DECIMAL(10, 2) = 950.00; -- Example balance
DECLARE @Withdrawal DECIMAL(10, 2) = 100.00; -- Withdrawal amount

--Loop with Conditional Exit
WHILE @Balance > 0
BEGIN
    -- Perform a withdrawal
    SET @Balance = @Balance - @Withdrawal;

    IF @Balance < 0
		BEGIN
			PRINT 'Insufficient funds for withdrawal.';
			BREAK;
		END

    PRINT 'New Balance: ' + CAST(@Balance AS VARCHAR);
END


-- New Balance: 850.00
-- New Balance: 750.00
-- New Balance: 650.00
-- New Balance: 550.00
-- New Balance: 450.00
-- New Balance: 350.00
-- New Balance: 250.00
-- New Balance: 150.00
-- New Balance: 50.00
-- Insufficient funds for withdrawal.