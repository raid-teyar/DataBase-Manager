CREATE TABLE [dbo].[Itemes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ReteilPrice] MONEY NOT NULL
)
