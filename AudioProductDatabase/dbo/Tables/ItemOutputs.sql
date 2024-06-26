CREATE TABLE [dbo].[ItemOutputs]
(
    [ItemId] INT NOT NULL, 
    [ConnectorId] INT NOT NULL, 
    [Count] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_ItemOutputs_Items] FOREIGN KEY (ItemId) REFERENCES Items(Id), 
    CONSTRAINT [FK_ItemOutputs_Connectors] FOREIGN KEY (ConnectorId) REFERENCES Connectors(Id), 
    PRIMARY KEY ([ItemId], [ConnectorId])
)
