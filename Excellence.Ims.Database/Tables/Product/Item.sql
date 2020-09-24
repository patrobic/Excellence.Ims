CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(MAX) NULL,
    [Description] VARCHAR(MAX) NULL, 
    [CategoryFK] INT NULL,
)
