CREATE TABLE [dbo].[Product_Tag]
(
	PRIMARY KEY ([ProductId], [TagId]),
    [ProductId] INT NOT NULL, 
    [TagId] INT NOT NULL, 
    CONSTRAINT [FK_Product_Tag_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
    CONSTRAINT [FK_Product_Tag_Tag] FOREIGN KEY ([TagId]) REFERENCES [Tag]([Id])
)
