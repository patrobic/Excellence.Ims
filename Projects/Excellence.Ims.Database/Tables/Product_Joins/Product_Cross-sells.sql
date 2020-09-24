CREATE TABLE [dbo].[Product_Cross-sells]
(
	PRIMARY KEY ([ProductId], [Cross-sellsId]),
	[ProductId] INT NOT NULL,
	[Cross-sellsId] INT NOT NULL, 
    CONSTRAINT [FK_Product_Cross-sells_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
    CONSTRAINT [FK_Product_Cross-sells_Cross-sells] FOREIGN KEY ([Cross-sellsId]) REFERENCES [Product]([Id]),
)
