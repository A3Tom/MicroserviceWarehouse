CREATE TABLE [dbo].[Transaction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ItemId] INT NOT NULL,
	[LocationId] INT NOT NULL,
	[Quantity] DECIMAL NOT NULL,
    
	[CreatedOn]			DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,

    CONSTRAINT [FK_Transaction_Item] FOREIGN KEY ([ItemId]) REFERENCES [Item]([Id]),
    CONSTRAINT [FK_Transaction_Location] FOREIGN KEY ([LocationId]) REFERENCES [Location]([Id])
)