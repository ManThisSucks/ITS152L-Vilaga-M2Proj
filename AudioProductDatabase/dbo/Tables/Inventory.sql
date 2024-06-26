CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemID] INT NOT NULL, 
    [InvCount] INT NOT NULL, 
    [WarrantyInMonths] INT NOT NULL, 
    [UnitPricePHP] DECIMAL(19, 4) NOT NULL DEFAULT 999999, 
    CONSTRAINT [FK_Inventory_Items] FOREIGN KEY (ItemID) REFERENCES Items(Id)
)
