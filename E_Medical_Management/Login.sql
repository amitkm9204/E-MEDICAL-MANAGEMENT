CREATE TABLE [dbo].[Table]
(
    [UserId] INT NOT NULL, 
    [Password] VARCHAR(10) NOT NULL, 
    [Name] VARCHAR(30) NOT NULL, 
    [Phone] CHAR(10) NOT NULL, 
    [Sex] CHAR NOT NULL, 
    [Age] INT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([UserId])
)
