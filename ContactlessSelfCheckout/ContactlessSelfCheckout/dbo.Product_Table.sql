CREATE TABLE [dbo].[Table]
(
	[Product_ID] INT NOT NULL PRIMARY KEY, 
    [Product_Name] VARCHAR(50) NOT NULL, 
    [Product_Category] VARCHAR(50) NOT NULL, 
    [Product_Price] MONEY NOT NULL DEFAULT 0, 
    [Product_Stock] INT NOT NULL DEFAULT 0
)
