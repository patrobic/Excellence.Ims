CREATE TABLE [dbo].[Product_WooCommerce]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShippingClassId] INT NOT NULL,
    [WarrantyId] INT NOT NULL,
	[Weight] INT NULL,
	[Length] INT NULL,
	[Width] INT NULL,
	[Height] INT NULL,
	[IsFeatured] BIT NOT NULL DEFAULT 0,
	[Published] BIT NOT NULL DEFAULT 1,
	[Visibility] BIT NOT NULL DEFAULT 1,
	[InStock] BIT NOT NULL DEFAULT 0,
	[BackordersAllowed] BIT NOT NULL DEFAULT 0,
	[TaxStatus] BIT NOT NULL DEFAULT 1,
    CONSTRAINT [FK_Product_Retail_ShippingClass] FOREIGN KEY ([ShippingClassId]) REFERENCES [ShippingClass]([Id]),
	CONSTRAINT [FK_Product_Retail_Warranty] FOREIGN KEY ([WarrantyId]) REFERENCES [Warranty]([Id]), 
    CONSTRAINT [FK_ProductInfo_Product] FOREIGN KEY ([Id]) REFERENCES [Product]([Id]),
)
