CREATE TABLE [dbo].[Products_in_Sales]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Sales_Id] INT NOT NULL, 
    [Product_Id] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    CONSTRAINT [FK_Products_in_Sales_ToSales] FOREIGN KEY ([Sales_Id]) REFERENCES [Sales]([Id]), 
    CONSTRAINT [FK_Products_in_Sales_ToProducts] FOREIGN KEY ([Product_Id]) REFERENCES [Products]([Id])
)
