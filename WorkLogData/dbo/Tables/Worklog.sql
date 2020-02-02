CREATE TABLE [dbo].[WorkLog]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Log] VARCHAR(MAX) NOT NULL, 
    [ComplaintId] INT NOT NULL, 
    CONSTRAINT [FK_WorkLog_Complaints] FOREIGN KEY ([ComplaintId]) REFERENCES [Complaints]([Id])
)
