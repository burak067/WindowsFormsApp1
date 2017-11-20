CREATE TABLE [dbo].[User]
(
	[Id_User] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email_User] NVARCHAR(50) NOT NULL, 
    [Name_User] NVARCHAR(50) NOT NULL, 
    [Vorname_User] NVARCHAR(50) NOT NULL, 
    [Gdatum_User] NVARCHAR(50) NOT NULL
)
