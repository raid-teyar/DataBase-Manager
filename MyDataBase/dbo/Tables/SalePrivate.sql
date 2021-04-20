CREATE TABLE [dbo].[SalePrivate]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NOT NULL, 
    [SaleDate] DATETIME2 NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [Total] MONEY NOT NULL, 
    [SubTotal] MONEY NULL
)
