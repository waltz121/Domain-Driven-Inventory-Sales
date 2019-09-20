CREATE TABLE [dbo].[Daily_Inventory_Levels]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Levels] INT NOT NULL, 
    [Product_ID] INT NOT NULL, 
    [Day_Date] DATETIME NOT NULL
)
