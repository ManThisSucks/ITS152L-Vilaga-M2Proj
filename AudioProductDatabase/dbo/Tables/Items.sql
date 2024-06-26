CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(20) NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Make] NVARCHAR(50) NOT NULL, 
    [Variant] NVARCHAR(50) NULL,
    [Description] NVARCHAR(250) NULL , 
    [Msrp] DECIMAL(19, 4) NULL, 
    [Image] IMAGE NULL, 
)
