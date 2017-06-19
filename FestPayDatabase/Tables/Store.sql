﻿CREATE TABLE [dbo].[Store]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(100) NOT NULL, 
    [Description] NCHAR(500) NULL, 
    [Location] NVARCHAR(50) NULL, 
    [Image] NCHAR(100) NOT NULL, 
    [ImageURL] NCHAR(100) NOT NULL
)
