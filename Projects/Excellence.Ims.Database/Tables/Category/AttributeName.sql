CREATE TABLE [dbo].[AttributeName]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Title] VARCHAR(MAX) NOT NULL,
	[CategoryId] INT NOT NULL,
	CONSTRAINT [FK_AttributeName_AttributeCategory] FOREIGN KEY ([CategoryId]) REFERENCES [AttributeCategory]([Id]),
)
