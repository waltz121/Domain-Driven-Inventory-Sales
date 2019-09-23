CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product_Type_Code] INT NOT NULL, 
    [Product_Name] NVARCHAR(50) NULL, 
    [Unit_Price] DECIMAL NOT NULL, 
    [Product_Description] NVARCHAR(50) NULL, 
    [Reorder_Level] INT NULL, 
    [Reorder_Quantity] INT NULL, 
    [Other_Details] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Product_ToProduct_Type] FOREIGN KEY ([Product_Type_Code]) REFERENCES [Product_Types]([Product_Type_Code])
)
