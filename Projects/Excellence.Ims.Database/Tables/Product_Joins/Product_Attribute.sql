CREATE TABLE [dbo].[Product_Attribute]
(
	PRIMARY KEY ([ProductId], [AttributeId]),
    [ProductId] INT NOT NULL,
    [AttributeId] INT NOT NULL,
    CONSTRAINT [FK_Product_Attribute_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
    CONSTRAINT [FK_Product_Attribute_Attribute] FOREIGN KEY ([AttributeId]) REFERENCES [Attribute]([Id]),
)
