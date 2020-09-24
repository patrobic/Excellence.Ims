/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--use master
--GO

--IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Excellence.Ims.Database')
--BEGIN
--	ALTER DATABASE [Excellence.Ims.Database] SET single_user WITH ROLLBACK IMMEDIATE
--	DROP DATABASE [Excellence.Ims.Database]
--END
--GO

--CREATE DATABASE [Excellence.Ims.Database]

--USE [Excellence.Ims.Database]
--GO
