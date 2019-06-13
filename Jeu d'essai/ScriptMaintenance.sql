USE [AirAtlantique]
GO

INSERT INTO [dbo].[Maintenance]
           ([id_Incident]
           ,[id_Warehouse]
           ,[Date_Start]
           ,[Date_End]
           ,[Description]
           ,[Place])
     VALUES
           (1
           ,1
           ,'10/08/2017'
           ,'18/08/2017'
           ,'Moteurs fonctionnant dans le mauvais sens.'
           ,'Nantes')
GO


