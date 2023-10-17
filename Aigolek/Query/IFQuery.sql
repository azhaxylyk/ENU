/*1-мысал: Барлық кітаптарды таңдап, кітаптың жаңа екенін көрсететін бағанды ​​қосыңыз (2022 жылдан кейін жарияланған).*/
SELECT [BookID]
      ,[Title]
      ,[AuthorID]
      ,[GenreID]
      ,[Description]
      ,[Image]
      ,[Year]
      ,[Pages],
      CASE 
         WHEN [Year] > 2022 THEN 'Жаңа кітап'
         ELSE 'Көне кітап'
      END AS [Status]
FROM [KidsLibrary].[dbo].[Books];


/*2-мысал: шолуларды таңдап, шолудың оң (4 немесе 5 бағаланған) немесе теріс (1, 2 немесе 3 бағаланған) екенін көрсететін бағанды ​​қосыңыз.*/
SELECT [ReviewID]
      ,[UserID]
      ,[BookID]
      ,[ReviewText]
      ,[Rating],
      CASE 
         WHEN [Rating] >= 4 THEN 'Оң сынау'
         ELSE 'Теріс сынау'
      END AS [Review type]
FROM [KidsLibrary].[dbo].[Reviews];


/*3-мысал: Пайдаланушыларды таңдап, пайдаланушының әкімші екенін көрсететін бағанды ​​қосыңыз (егер олардың аты «әкімші» болса).*/
SELECT [UserID]
      ,[Username]
      ,[Password]
      ,[Email]
      ,[RegistrationDate],
      CASE 
         WHEN [Username] = 'admin' THEN 'Администратор'
         ELSE 'Қарапайым қолданушы'
      END AS [User type]
FROM [KidsLibrary].[dbo].[Users];
