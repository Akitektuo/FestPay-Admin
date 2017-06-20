CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [PlacementDate] DATETIME NOT NULL, 
    [StoreId] INT NOT NULL,
	[UserId] INT NOT NULL, 
    CONSTRAINT [FK_Order_Store] FOREIGN KEY ([StoreId]) REFERENCES [Store]([Id]),
	CONSTRAINT [FK_Order_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
