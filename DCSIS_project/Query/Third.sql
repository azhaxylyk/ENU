SELECT i.Book_ID, b.Book_Name, r.FullName, i.IssueDate, i.ReturnDate, i.ReturnNote, e.Employee_Name
FROM LibIssues i
JOIN LibBooks b ON i.Book_ID = b.Book_ID
JOIN LibReaders r ON i.Reader_ID = r.Reader_ID
JOIN LibEmployees e ON i.Employee_ID = e.Employee_ID
WHERE i.ReturnDate IS NULL



SELECT i.Book_ID, b.Book_Name, r.FullName, i.IssueDate, i.ReturnDate, i.ReturnNote, e.Employee_Name
FROM LibIssues i
JOIN LibBooks b ON i.Book_ID = b.Book_ID
JOIN LibReaders r ON i.Reader_ID = r.Reader_ID
JOIN LibEmployees e ON i.Employee_ID = e.Employee_ID
WHERE r.FullName = 'Litzy Jordan'