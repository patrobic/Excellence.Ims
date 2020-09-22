CREATE TABLE [dbo].[Product_Category]
(
	PRIMARY KEY ([ProductId], [CategoryId]),
    [ProductId] INT NOT NULL,
    [CategoryId] INT NOT NULL,
    CONSTRAINT [FK_Product_Category_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
    CONSTRAINT [FK_Product_Category_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]),
)
