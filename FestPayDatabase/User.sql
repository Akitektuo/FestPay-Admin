CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(100) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(100) NOT NULL, 
    [Code] NUMERIC NOT NULL, 
    [Coordinates] NVARCHAR(50) NOT NULL, 
    [Flag] INT NOT NULL 
)
