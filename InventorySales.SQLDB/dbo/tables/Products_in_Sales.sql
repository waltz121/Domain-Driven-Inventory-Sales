CREATE TABLE [dbo].[Products_in_Sales]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Sales_ID] INT NOT NULL, 
    [Product_ID] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    CONSTRAINT [FK_Products_in_Sales_ToSales] FOREIGN KEY ([Sales_ID]) REFERENCES [Sale]([Id]), 
    CONSTRAINT [FK_Products_in_Sales_ToProducts] FOREIGN KEY ([Product_ID]) REFERENCES [Product]([Id])
)
