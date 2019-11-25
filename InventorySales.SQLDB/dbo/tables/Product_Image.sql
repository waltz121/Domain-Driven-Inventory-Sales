CREATE TABLE [dbo].[Product_Image]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [Image] VARBINARY(MAX) NOT NULL, 
    [Description] NVARCHAR(90) NULL, 
    CONSTRAINT [FK_Product_Image_ToProduct] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]) 
)
