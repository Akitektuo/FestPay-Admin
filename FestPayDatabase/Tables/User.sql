CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(100) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(100) NOT NULL, 
    [Code] NUMERIC NOT NULL, 
    [Coordinates] NVARCHAR(50) NOT NULL, 
    [CanPay] BIT NOT NULL DEFAULT 1, 
    [CanLogIn] BIT NOT NULL DEFAULT 1, 
    [CreditsId] INT NOT NULL, 
    [RoleId] INT NOT NULL, 
    [StoreId] INT NOT NULL,
	CONSTRAINT [FK_User_Credits] FOREIGN KEY ([CreditsId]) REFERENCES [Credits]([Id]),
	CONSTRAINT [FK_User_Role] FOREIGN KEY ([RoleId]) REFERENCES [Role]([Id]),
	CONSTRAINT [FK_User_Store] FOREIGN KEY ([StoreId]) REFERENCES [Store]([Id])
)
