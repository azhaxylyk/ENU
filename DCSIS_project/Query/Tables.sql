CREATE TABLE [dbo].[LibPositions](
	[Position_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[Position_Name] [nvarchar](50) NULL,
	[Salary] [money] NULL,
	[Responsibilities] [nvarchar](max) NULL,
	[Requirements] [nvarchar](max) NULL
) 
INSERT INTO [dbo].[LibPositions] ([Position_Name], [Salary], [Responsibilities], [Requirements])
VALUES
('Librarian', 200000.0000, 'Services', 'Fundamentals of librarianship, bibliography'),
('Bibliographer', 190000.0000, 'Informing', 'Fundamentals in the field of bibliography and computer science'),
('Methodist', 250000.0000, 'Analysis', 'Must know library and archive business'),
('Editor', 300000.0000, 'Develops long-term and current plans for the production of printed products.', 
'Methods of editing manuscripts and artistic and technical design of printed products'),
('Accounting and custody documentation specialist', 185000.0000, 'Supervises the documentary support', 
'Instructions for accounting and storage of library collections');



CREATE TABLE [dbo].[LibEmployees](
	[Employee_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[Employee_Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [nchar](10) NULL,
	[Address] [nchar](10) NULL,
	[Phone] [bigint] NULL,
	[Pasport] [bigint] NULL,
	[Position_ID] [int] NOT NULL
)
INSERT INTO [dbo].[LibEmployees] ([Employee_Name], [Age], [Gender], [Address], [Phone], [Pasport], [Position_ID])
VALUES ('Katelyn Baxter', 36, 'F', 'Dostyq 12', 7057894565, 830101123456, 1),
       ('Corinne Jacobs', 45, 'F', 'Muztau 6', 7775236341, 790506452215, 2),
       ('Caylee Berg', 30, 'F', 'Nurjol 3', 7721238529, 921206741852, 3),
       ('Braelyn Alvarez', 25, 'F', 'Ozen 25', 7057418536, 990409562243, 5),
       ('Jabari Yang', 26, 'M', 'Samal 7', 7078256826, 200312564156, 4),
       ('Kiersten Clay', 28, 'M', 'Pushkina 1', 7778566932, 454656512382, 2),
       ('Desmond Bauer', 29, 'M', 'Jenis 9', 7054395431, 745132963399, 3),
       ('Araceli Pollard', 39, 'M', 'Rauan 13', 7025526531, 111111111111, 4),
       ('Jamie Vega', 45, 'F', 'Dostyq 24', 7026536169, 222222222222, 5),
       ('Edgar Craig', 22, 'M', 'Jenis 8', 7054139431, 992233115545, 3);



CREATE TABLE [dbo].[LibPublishers](
	[Publisher_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[Publisher_Name] [char](10) NULL,
	[City] [char](10) NULL,
	[Address] [char](10) NULL
)
INSERT INTO [dbo].[LibPublishers] ([Publisher_Name], [City], [Address])
VALUES ('Ana tili', 'Almaty', 'Dostyq 5'),
       ('G''ylym', 'Astana', 'Jenis 1'),
       ('Oner', 'Qyzylorda', 'Satpai 7'),
       ('Dauir', 'Semei', 'Alash 8'),
       ('Balausa', 'Qaragandy', 'Koshe 1');




CREATE TABLE [dbo].[LibGenres](
	[Genre_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[Genre_Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL
)
INSERT INTO [dbo].[LibGenres] ([Genre_Name], [Description])
VALUES
('Mystery', 'A book in which a crime, often a murder, is investigated by a detective or amateur sleuth.'),
('Thriller', 'Books where the main character is in danger and must prevent bad things from happening. These books are often fast-paced and exciting.'),
('Science Fiction', 'Books that speculate on future scientific and technological advances and their potential impact on society and individuals.'),
('Fantasy', 'Books that feature magic and supernatural elements and often take place in imaginary worlds.'),
('Horror', 'Books that are intended to frighten, scare, or unsettle the reader with tales of the supernatural or macabre.'),
('Young Adult', 'Books that are aimed at teenagers and young adults and deal with themes that are relevant to them, such as first love, coming of age, and self-discovery.');




CREATE TABLE [dbo].[LibBooks](
	[Book_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[Book_Name] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL,
	[Publisher_ID] [int] NOT NULL,
	[Year] [int] NULL,
	[Genre_ID] [int] NOT NULL
)
INSERT INTO [dbo].[LibBooks] ([Book_Name], [Author], [Publisher_ID], [Year], [Genre_ID])
VALUES
('The Great Gatsby', 'F. Scott Fitzgerald', 2, 2012, 1),
('1984', 'George Orwell', 3, 2015, 2),
('To Kill a Mockingbird', 'Harper Lee', 1, 2013, 3),
('Stone Blind', 'Natalie Haynes', 5, 2020, 4),
('Pride and Prejudice', 'Jane Austen', 2, 2019, 1),
('She Who Became the Sun', 'Shelley Parker-Chan', 2, 2021, 4),
('The Da Vinci Code', 'Dan Brown', 4, 2018, 3),
('The Help', 'Kathryn Stockett', 1, 2022, 3),
('One Flew Over the Cuckoo''s Nest', 'Ken Kesey', 1, 2022, 1),
('Buddenbrooks', 'Thomas Mann', 3, 2020, 1)





CREATE TABLE [dbo].[LibReaders](
	[Reader_ID] [int] identity(1,1) NOT NULL PRIMARY KEY,
	[FullName] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[Gender] [nchar](10) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [bigint] NULL,
	[Passport] [bigint] NULL
)
INSERT INTO [dbo].[LibReaders](
	[FullName],
	[BirthDate],
	[Gender],
	[Address],
	[Phone],
	[Passport]
) VALUES 
	('Augustus Barnett', '2004-12-03', 'M', 'Koshe 2', 7057418529, 412031234564),
	('Kole Acevedo', '2005-05-05', 'F', 'Abylai 9', 7775595233, 505057895440),
	('Litzy Jordan', '2002-12-19', 'F', 'Mahambet 8', 7084519922, 212562861600),
	('Abylai Figueroa', '2000-06-09', 'M', 'Abai 14', 7028494632, 662545454650),
	('Palenshei Tugenshei', '1999-02-20', 'F', 'Palenshei 7', 7021458965, 990220852960),
	('Ahalai Mahalai', '2013-03-24', 'M', 'Oral 5', 7018569428, 130324852963),
	('Ayaz Ata', '1995-12-31', 'M', 'Oralma 6', 7054128975, 951231741852),
	('Franco Figueroa', '1990-07-30', 'M', 'Jenis 18', 7777845792, 900730265841),
	('Ignacio Cobb', '2008-08-08', 'F', 'Pushkin 99', 7795813248, 880808852963),
	('Taylor Schwartz', '2000-01-01', 'F', 'Kerei 12', 7785656364, 200001015684);





CREATE TABLE [dbo].[LibIssues](
	[Book_ID] [int] NOT NULL,
	[Reader_ID] [int] NOT NULL,
	[IssueDate] [date] NULL,
	[ReturnDate] [date] NULL,
	[ReturnNote] [nvarchar](50) NULL,
	[Employee_ID] [int] NOT NULL
) 
INSERT INTO [dbo].[LibIssues] (Book_ID, Reader_ID, IssueDate, ReturnDate, ReturnNote, Employee_ID)
VALUES
    (7, 10, '2023-01-03', '2023-02-05', 'late', 1),
    (5, 9, '2023-02-15', '2023-02-25', 'On time', 1),
    (4, 6, '2023-03-22', '2023-03-30', 'On time', 1),
    (1, 3, '2023-03-12', '2023-03-20', 'On time', 1),
    (2, 8, '2023-03-19', '2023-03-30', 'On time', 1),
    (8, 3, '2023-03-14', '2023-04-02', 'late', 1),
    (6, 7, '2023-03-08', '2023-03-16', 'On time', 1),
    (3, 1, '2023-04-02', '2023-04-16', 'On time', 1),
    (9, 3, '2023-04-05', '2023-04-20', 'On time', 1),
    (10, 2, '2023-03-30', '2023-04-05', 'On time', 1);