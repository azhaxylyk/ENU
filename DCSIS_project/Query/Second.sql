SELECT b.Book_ID, b.Book_Name, p.Publisher_Name, g.Genre_Name
FROM LibBooks b
JOIN LibPublishers p ON b.Publisher_ID = p.Publisher_ID
JOIN LibGenres g ON b.Genre_ID = g.Genre_ID
WHERE p.Publisher_Name = 'Ana tili'


SELECT b.Book_ID, b.Book_Name, p.Publisher_Name, g.Genre_Name
FROM LibBooks b
JOIN LibPublishers p ON b.Publisher_ID = p.Publisher_ID
JOIN LibGenres g ON b.Genre_ID = g.Genre_ID
WHERE b.Author = 'George Orwell'


SELECT b.Book_ID, b.Book_Name, p.Publisher_Name, g.Genre_Name
FROM LibBooks b
JOIN LibPublishers p ON b.Publisher_ID = p.Publisher_ID
JOIN LibGenres g ON b.Genre_ID = g.Genre_ID
WHERE b.Year = 2022
