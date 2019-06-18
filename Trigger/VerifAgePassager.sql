ALTER TRIGGER Verification_Age_Enfant
On dbo.Billet
FOR INSERT
AS 

DECLARE @VOL_DATE DATETIME
declare @Datenaissance Date
declare @Age int 
declare @DateVol Date
declare @idVol int
declare @resultat date 

BEGIN

	declare @IdTarif int  = ( select id_Price from inserted )
	declare @IdClient int = ( select id_Passenger from inserted )
	declare @IdVoyages int = ( select id_Trip from inserted )




	set @Datenaissance = (SELECT Birthdate FROM Passenger)
	
	DECLARE cursord CURSOR FOR select id_Flight from Flight_Trip where id_Trip = @IdVoyages
	OPEN cursord
	FETCH NEXT FROM cursord INTO @idVol
	WHILE @@FETCH_STATUS = 0 
		BEGIN
			set @DateVol = (select Hours_Departure from Flight where id = @idVol)

			
			print DATEADD(year, 10,@Datenaissance )
			print @DateVol
			if @DateVol < DATEADD(year, 10,@Datenaissance )
			BEGIN
				PRINT 'AGE < 10'
				rollback 
			END
		FETCH NEXT FROM cursord INTO @idVol  

		END 
	CLOSE cursord
	DEALLOCATE cursord
	



 
	
	
END
GO
