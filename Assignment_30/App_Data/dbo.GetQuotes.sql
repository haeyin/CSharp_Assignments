CREATE TABLE [dbo].[GetQuotes] (
    [Id]           INT           NOT NULL,
    [FirstName]    VARCHAR (50)  NULL,
    [LastName]     VARCHAR (50)  NULL,
    [EmailAddress] VARCHAR (100) NULL,
    [Birthday]     DATE          NULL,
    [CarYear]      VARCHAR (5)   NULL,
    [CarMake]      VARCHAR (50)  NULL,
    [CarModel]     VARCHAR (50)  NULL,
    [DUI]          BIT           NOT NULL,
    [SpeedingTix]  INT           NOT NULL,
    [FCorL]        BIT           NOT NULL,
    CONSTRAINT [PK_GetQuotes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

