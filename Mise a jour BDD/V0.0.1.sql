/* Pour �viter les probl�mes �ventuels de perte de donn�es, passez attentivement ce script en revue avant de l'ex�cuter en dehors du contexte du Concepteur de bases de donn�es.*/
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
EXECUTE sp_rename N'dbo.Flight.id_Crew', N'Tmp_id_Salaried', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Flight.Tmp_id_Salaried', N'id_Salaried', 'COLUMN' 
GO
ALTER TABLE dbo.Flight SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Flight', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Flight', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Flight', 'Object', 'CONTROL') as Contr_Per