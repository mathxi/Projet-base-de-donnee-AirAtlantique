/* Pour éviter les problèmes éventuels de perte de données, passez attentivement ce script en revue avant de l'exécuter en dehors du contexte du Concepteur de bases de données.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Airport SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Airport', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Airport', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Airport', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Flight ADD CONSTRAINT
	FK_Flight_Airport FOREIGN KEY
	(
	id_Airport_End
	) REFERENCES dbo.Airport
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Flight ADD CONSTRAINT
	FK_Flight_Airport1 FOREIGN KEY
	(
	id_Airport_End_Real
	) REFERENCES dbo.Airport
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Flight ADD CONSTRAINT
	FK_Flight_Airport2 FOREIGN KEY
	(
	id_Airport_Start
	) REFERENCES dbo.Airport
	(
	id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Flight SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Flight', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Flight', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Flight', 'Object', 'CONTROL') as Contr_Per 