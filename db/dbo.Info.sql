CREATE TABLE [dbo].[Info] (
    [ID]      INT        NOT NULL,
    [IdCountry]   INT        NOT NULL,
    [InfoCountry] TEXT       NOT NULL,
    [IP]          NCHAR (20) NOT NULL,
    [Location]    NCHAR (40) NOT NULL,
    [Date]        DATE       NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Info_ToCountries] FOREIGN KEY ([IdCountry]) REFERENCES [dbo].[Countries] ([IdCountry])
);

