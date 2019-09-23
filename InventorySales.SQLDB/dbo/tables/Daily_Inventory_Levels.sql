CREATE TABLE [dbo].[Daily_Inventory_Levels]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Levels] INT NOT NULL, 
    [Product_ID] INT NOT NULL, 
    [Day_Date] DATETIME NOT NULL, 
    CONSTRAINT [FK_Daily_Inventory_Levels_ToProduct] FOREIGN KEY ([Product_ID]) REFERENCES [Products]([Id]), 
    CONSTRAINT [FK_Daily_Inventory_Levels_ToRef_Calendar] FOREIGN KEY ([Day_Date]) REFERENCES [Ref_Calendar]([Day_Date])
)
