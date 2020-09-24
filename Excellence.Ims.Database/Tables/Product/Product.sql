CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(MAX) NOT NULL,
    [Description] VARCHAR(MAX) NULL,
    [SKU] VARCHAR(MAX) NOT NULL,
    [TypeId] INT NOT NULL DEFAULT 1,
    [ParentId] INT NULL, 
    [Price] MONEY NOT NULL,
    [Date] DATE NOT NULL,
    CONSTRAINT [FK_Product_Type] FOREIGN KEY ([TypeId]) REFERENCES [Type]([Id]),
    CONSTRAINT [FK_Product_Parent] FOREIGN KEY ([ParentId]) REFERENCES [Product]([Id]),
)
