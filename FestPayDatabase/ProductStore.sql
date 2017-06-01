CREATE TABLE [dbo].[ProductStore]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [StoreId] INT NOT NULL, 
    [PriceModifier] DECIMAL(5, 5) NOT NULL DEFAULT 1
)
