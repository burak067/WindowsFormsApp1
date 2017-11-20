CREATE TABLE [dbo].[Table]
(
	[Id_User] INT NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Vorname] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Geburtsdatum] NVARCHAR(50) NOT NULL
)
