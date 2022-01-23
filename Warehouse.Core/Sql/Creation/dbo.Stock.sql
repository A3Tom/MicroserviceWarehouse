CREATE TABLE [dbo].[Stock]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[LocationId] INT NOT NULL,
	[Quantity] DECIMAL NOT NULL DEFAULT 0,
	[UnitOfMeasurement] INT NOT NULL DEFAULT 0, 

    CONSTRAINT [FK_Stock_Location] FOREIGN KEY ([LocationId]) REFERENCES [Location]([Id])
)
