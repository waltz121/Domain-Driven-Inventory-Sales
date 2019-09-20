CREATE TABLE [dbo].[Product_Types]
(
	[Product_Type_Code] INT NOT NULL PRIMARY KEY, 
    [Parent_Product_Type_Code] INT NOT NULL, 
    [Product_Type_Description] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Product_Types_ToProduct_Types] FOREIGN KEY ([Parent_Product_Type_Code]) REFERENCES [Product_Types]([Product_Type_Code])
)
