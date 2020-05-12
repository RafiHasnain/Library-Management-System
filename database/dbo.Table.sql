CREATE TABLE [dbo].[library_person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [fullname] VARCHAR(50) NULL, 
    [username] VARCHAR(50) NULL, 
    [password] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [contact] VARCHAR(50) NULL
)
