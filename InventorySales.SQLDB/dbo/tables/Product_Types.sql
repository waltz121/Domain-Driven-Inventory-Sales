CREATE TABLE [dbo].[Product_Types]
(
	[Product_Type_Code] INT NOT NULL PRIMARY KEY, 
    [Parent_Product_Type_Code] INT NOT NULL, 
    [Product_Type_Description] NVARCHAR(50) NULL
)
