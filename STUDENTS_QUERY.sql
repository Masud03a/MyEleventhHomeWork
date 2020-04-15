USE [Masud]
GO

INSERT INTO [dbo].[Students]
           ([ID]
           ,[Name]
           ,[Surname]
           ,[PhoneNumber]
           ,[HomeAdress])
     VALUES
           ('1'
           ,'Masud'
           ,'Amirkhonov'
           ,'+992938851985'
           ,'Binokoron 22/35')
GO


SELECT * FROM dbo.Students