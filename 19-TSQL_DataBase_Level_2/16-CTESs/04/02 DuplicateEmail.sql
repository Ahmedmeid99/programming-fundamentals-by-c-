
WITH DuplicateEmails AS (
    SELECT 
        Email, 
        COUNT(*) AS DuplicateEmail
    FROM Contacts
    GROUP BY Email
    HAVING COUNT(*) > 1
)
SELECT c.ContactID, c.Name, c.Email
FROM Contacts c
INNER JOIN DuplicateEmails de ON c.Email = de.Email;
