CREATE TABLE [dbo].[SalePublic]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PrivatSaleId] INT NOT NULL, 
    [ProdectId] INT NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL DEFAULT 0, 
    [Quantity] INT NOT NULL DEFAULT 1 
)
