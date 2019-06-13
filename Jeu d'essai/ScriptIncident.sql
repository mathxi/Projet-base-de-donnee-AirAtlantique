USE [AirAtlantique]
GO

INSERT INTO [dbo].[Incident]
           ([id_Plane]
           ,[id_Salaried]
           ,[Severity]
           ,[Comment]
           ,[Date])
     VALUES
           (1
           ,1
           ,9
           ,'Moteur ne fonctionnant plus dans le bon sens.'
           ,'10/08/2017')
GO


