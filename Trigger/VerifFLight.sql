USE [AirAtlantique]
GO
/****** Object:  Trigger [dbo].[VerifFlightIntegrity]    Script Date: 18/06/2019 12:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[VerifFlightIntegrity] ON [dbo].[Flight]
FOR UPDATE, INSERT
AS

BEGIN
DECLARE @isPlaneUsed INTEGER,@idPlane INTEGER, @idFlight INTEGER,@idAirportDepart INTEGER,@idAirportEnd INTEGER,@HeureDepart DATETIME,@test integer, @HeureArrive DATETIME, @PrintMessage nvarchar(50)

SET @idPlane=(SELECT id_Plane from inserted)
SET @idFlight=(SELECT id from inserted)


SET @idAirportDepart=(SELECT id_Airport_Start FROM inserted)
SET @idAirportEnd=(SELECT id_Airport_End FROM inserted)

SET @HeureDepart=(SELECT Hours_Departure from inserted)
SET @HeureArrive=(SELECT Hours_Arrival from inserted)

SET @isPlaneUsed =(SELECT COUNT(*) from Flight where  id_Plane = @idPlane AND  id <> @idFlight AND Hours_Departure >= @HeureDepart AND Hours_Departure <= @HeureArrive )

--SET @idpassenger=(SELECT id_passenger FROM inserted)
--SET @idflight=(SELECT id_flight FROM inserted)
--set @idpricelist=(SELECT id_price_list FROM inserted)
--SET @birthday=(SELECT birthday FROM Passenger WHERE id=@idpassenger)
--SET @departuretime=(SELECT departure_time FROM Flight WHERE id=@idflight)
--SET @nom=(SELECT nom FROM Price_List WHERE id=@idpricelist)
SET @PrintMessage = 'Le voyage n est pas cohérent'
IF(@idAirportDepart LIKE @idAirportEnd OR @HeureDepart > @HeureArrive OR  @isPlaneUsed > 0 )
  BEGIN
    PRINT @PrintMessage;
	PRINT CONCAT('Avion utiliser ? --> ' , @isPlaneUsed)
    rollback;
  END
END