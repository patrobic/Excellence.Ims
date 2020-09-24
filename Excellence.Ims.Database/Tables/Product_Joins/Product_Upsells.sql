CREATE TABLE [dbo].[Product_Upsells]
(
	PRIMARY KEY ([ProductId], [UpsellsId]),
	[ProductId] INT NOT NULL,
	[UpsellsId] INT NOT NULL,
    CONSTRAINT [FK_Product_Upsells_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
    CONSTRAINT [FK_Product_Upsells_Upsells] FOREIGN KEY ([UpsellsId]) REFERENCES [Product]([Id]),
)