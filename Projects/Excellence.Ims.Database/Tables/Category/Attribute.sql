CREATE TABLE [dbo].[Attribute]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Title] VARCHAR(MAX) NOT NULL, 
	[NameId] INT NOT NULL,
	CONSTRAINT [FK_Attribute_AttributeName] FOREIGN KEY ([NameId]) REFERENCES [AttributeName]([Id]),
)
