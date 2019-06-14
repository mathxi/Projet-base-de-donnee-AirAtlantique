USE [AirAtlantique]
GO

INSERT INTO [dbo].[Flight]
           ([id_Plane]
           ,[id_Airport_Start]
           ,[id_Airport_End]
           ,[id_Airport_End_Real]
           ,[Hours_Departure]
           ,[Hours_Arrival]
           ,[Hours_Lift_OFF]
           ,[Hours_Landing])
     VALUES
           (1
           ,4
           ,1
           ,4
           ,'10-06-2019 10:00:00'
           ,'10-06-2019 11:30:30'
           ,'10-06-2019 10:15:00'
           ,'10-06-2019 11:15:00')
GO


