CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(100) NOT NULL, 
    [Description] NCHAR(500) NULL, 
    [Price] NUMERIC(9) NOT NULL, 
    [Image] NCHAR(100) NOT NULL
)
