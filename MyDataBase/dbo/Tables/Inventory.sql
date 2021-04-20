﻿CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ItemId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
