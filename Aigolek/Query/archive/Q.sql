INSERT INTO [dbo].[LibPositions] ([Position_Name], [Salary], [Responsibilities], [Requirements])
VALUES ('Information Systems Manager', 350000.0000, 'Manage the information technology and computer systems of the library', 'Bachelor’s degree in computer science or a related field and experience in information technology management.')

DELETE FROM [dbo].[LibPositions] WHERE [Position_ID] = 5

UPDATE [dbo].[LibPositions]
SET [Salary] = 210000.0000
WHERE [Position_ID] = 1



INSERT INTO [dbo].[LibEmployees] ([Employee_Name], [Age], [Gender], [Address], [Phone], [Pasport], [Position_ID])
VALUES ('Nate Fuller', 32, 'M', 'Abay 15', 7055216423, 790703244623, 3)

DELETE FROM [dbo].[LibEmployees] WHERE [Employee_ID] = 4

UPDATE [dbo].[LibEmployees]
SET [Age] = 46
WHERE [Employee_ID] = 2


INSERT INTO [dbo].[LibPublishers] ([Publisher_Name], [City], [Address])
VALUES ('Atamura', 'Almaty', 'Dostyq 12')

DELETE FROM [dbo].[LibPublishers] WHERE [Publisher_ID] = 3

UPDATE [dbo].[LibPublishers]
SET [City] = 'Nur-Sultan'
WHERE [Publisher_ID] = 2


INSERT INTO [dbo].[LibGenres] ([Genre_Name], [Description])
VALUES ('Romance', 'Books that focus on the romantic relationships between characters.')

DELETE FROM [dbo].[LibGenres] WHERE [Genre_ID] = 6

UPDATE [dbo].[LibGenres]
SET [Description] = 'Books that focus on the romantic relationships between characters, often with a happy ending.'
WHERE [Genre_ID] = 1


INSERT INTO [dbo].[LibBooks] ([Book_Name], [Author], [Publisher_ID], [Year], [Genre_ID])
VALUES ('The Picture of Dorian Gray', 'Oscar Wilde', 2, 2016, 1);

DELETE FROM [dbo].[LibBooks]
WHERE [Book_ID] = 4;

UPDATE [dbo].[LibBooks]
SET [Year] = 2022
WHERE [Book_ID] = 5;


INSERT INTO [dbo].[LibReaders] ([FullName], [BirthDate], [Gender], [Address], [Phone], [Passport])
VALUES ('Amina Suleimenova', '2001-08-12', 'F', 'Baitursynov 35', 7025469875, 120812963852);

DELETE FROM [dbo].[LibReaders]
WHERE [Reader_ID] = 8;

UPDATE [dbo].[LibReaders]
SET [Phone] = 7021357902
WHERE [Reader_ID] = 5;


INSERT INTO [dbo].[LibIssues] ([Book_ID], [Reader_ID], [IssueDate], [Employee_ID])
VALUES (9, 2, '2023-04-11', 3);

DELETE FROM [dbo].[LibIssues]
WHERE Book_ID = 7 AND Reader_ID = 10;

UPDATE [dbo].[LibIssues]
SET [ReturnDate] = '2023-05-01'
WHERE [Book_ID] = 9 AND [Reader_ID] = 2;
