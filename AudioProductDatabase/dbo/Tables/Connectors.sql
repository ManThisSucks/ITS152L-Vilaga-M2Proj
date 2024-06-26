CREATE TABLE [dbo].[Connectors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Variant] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(250) NULL, 
    [Image] IMAGE NULL 
)
