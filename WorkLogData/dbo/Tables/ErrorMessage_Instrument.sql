CREATE TABLE [dbo].[ErrorMessage_Instrument]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ErrorMessageId] INT NOT NULL, 
    [InstrumentId] INT NOT NULL,
    CONSTRAINT [FK_ErrorMessage_Instrument_ErrorMessages] FOREIGN KEY ([ErrorMessageId]) REFERENCES [ErrorMessages]([Id]),
	CONSTRAINT [FK_ErrorMessage_Instrument_Instrument] FOREIGN KEY ([InstrumentId]) REFERENCES [Instrument]([Id])

)
