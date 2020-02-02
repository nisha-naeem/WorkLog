CREATE TABLE [dbo].[ErrorMessages]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Code] VARCHAR(10) NOT NULL, 
    [Message] VARCHAR(200) NOT NULL
)
