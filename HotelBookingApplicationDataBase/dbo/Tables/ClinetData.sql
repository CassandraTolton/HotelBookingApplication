CREATE TABLE [dbo].[Clients] (
    [ClientId]     INT NOT NULL PRIMARY KEY IDENTITY,
    [FirstName]   VARCHAR (50)  NOT NULL,
    [LastName]    VARCHAR (50)  NOT NULL,
    [PhoneNumber] VARCHAR (50)  NOT NULL,
    [Address]     VARCHAR (250) NOT NULL
);

