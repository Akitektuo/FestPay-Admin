CREATE TABLE [dbo].[ProductStore]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [StoreId] INT NOT NULL, 
    [PriceModifier] DECIMAL(5, 5) NOT NULL DEFAULT 1,
	[Stock] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_ProductStore_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]),
	CONSTRAINT [FK_ProductStore_Store] FOREIGN KEY ([StoreId]) REFERENCES [Store]([Id])
)
