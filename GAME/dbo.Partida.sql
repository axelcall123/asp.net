CREATE TABLE [dbo].[Partida] (
    [Id_Partida]     INT          NOT NULL DEFAULT 0,
    [Nombre_Partida] VARCHAR (50) NOT NULL DEFAULT General,
    CONSTRAINT [PK_Partida] PRIMARY KEY CLUSTERED ([Id_Partida] ASC)
);

