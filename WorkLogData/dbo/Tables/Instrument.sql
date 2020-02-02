CREATE TABLE [dbo].[Instrument]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(100) NOT NULL, 
    [Serial] VARCHAR(50) NOT NULL, 
    [ManufacturerId] INT NOT NULL, 
    [ClassificationId] INT NOT NULL, 
    CONSTRAINT [FK_Instrument_Manufacturer] FOREIGN KEY ([ManufacturerId]) REFERENCES [Manufacturer]([Id]),
    CONSTRAINT [FK_Instrument_Classification] FOREIGN KEY ([ClassificationId]) REFERENCES [Classification]([Id])

)
