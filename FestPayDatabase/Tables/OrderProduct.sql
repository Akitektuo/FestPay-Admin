﻿CREATE TABLE [dbo].[OrderProduct]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OrderId] INT NOT NULL, 
    [ProductId] INT NOT NULL,
	CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY ([OrderId]) REFERENCES [Order]([Id]),
	CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id])
)
