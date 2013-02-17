CREATE TABLE [dbo].[Info] (
    [IdInfo]	INT			NOT NULL,
    [IdCountry] INT			NOT NULL,
    [Info]      TEXT		NOT NULL,
    [IP]        NCHAR (20)	NOT NULL,
    [Location]  NCHAR (40)	NOT NULL,
    PRIMARY KEY CLUSTERED ([IdInfo] ASC), 
    CONSTRAINT [FK_Info_ToCountries] FOREIGN KEY ([IdCountry]) REFERENCES [Countries]([IdCountry])
);

