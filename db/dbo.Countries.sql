CREATE TABLE [dbo].[Countries] (
    [IdCountry]   INT        NOT NULL,
    [Name]        NCHAR (40) NOT NULL,
    [IdContinent] INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCountry] ASC),
    CONSTRAINT [FK_Countries_ToContinents] FOREIGN KEY ([IdContinent]) REFERENCES [dbo].[Continents] ([IdContinent])
);