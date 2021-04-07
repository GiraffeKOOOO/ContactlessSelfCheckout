CREATE TABLE [dbo].[Table_Product] (
    [Product_ID]       INT          NOT NULL,
    [Product_Name]     VARCHAR (50) NOT NULL,
    [Product_Category] VARCHAR (50) NOT NULL,
    [Product_Price]    DECIMAL (10, 2) DEFAULT ((0)) NOT NULL,
    [Product_Stock]    INT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Product_ID] ASC)
);

