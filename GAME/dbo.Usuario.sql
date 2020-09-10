CREATE TABLE [dbo].[Usuario] (
    [Id_Usuario]     INT          NOT NULL DEFAULT 0,
    [Nombre]         VARCHAR (50) NOT NULL DEFAULT Alex,
    [Apellido]       VARCHAR (50) NOT NULL DEFAULT Barrios,
    [Nombre_Usuario] VARCHAR (50) NOT NULL DEFAULT Lu,
    [Contraseña]     VARCHAR (50) NOT NULL DEFAULT 123,
    [Fecha_Nac]      DATE         NOT NULL DEFAULT 2/12/2020,
    [Pais]           VARCHAR (10) NOT NULL DEFAULT GT,
    [Correo]         VARCHAR (20) NOT NULL DEFAULT lol@gmail.com,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id_Usuario] ASC),
    CONSTRAINT [FK_Usuario_Partida] FOREIGN KEY ([Id_Usuario]) REFERENCES [dbo].[Partida] ([Id_Partida])
);

