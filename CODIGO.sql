DELETE FROM DBO.Usuario WHERE Id_Usuario<50
SELECT*FROM dbo.Usuario
SELECT*FROM dbo.Jugador

CREATE DATABASE Game;
Use Game;
CREATE TABLE Usuario(
	Id_Usuario INT IDENTITY(1,1) NOT NULL,
	Nombre varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	Nombre_Usuario varchar(50) NOT NULL,
	Contraseña varchar(50) NOT NULL,
	Fecha_Nac date NOT NULL,
	Pais varchar(10) NOT NULL,
	Correo varchar(20) NOT NULL,
	PRIMARY KEY(Id_Usuario));

CREATE TABLE Jugador(
	Id_Jugador int IDENTITY(1,1) NOT NULL,
	Tipo_Jugador varchar(30) NOT NULL,
	Id_Usuario int NOT NULL,
	PRIMARY KEY(Id_Jugador));

CREATE TABLE Partida(
	Id_Partida int IDENTITY(1,1) NOT NULL,
	Id_Jugador1 int NOT NULL,
	Id_Jugador2 int NOT NULL,
	PRIMARY KEY(Id_Partida)
);

CREATE TABLE Partida_Jugada(
	Id_Partida_Jugada int IDENTITY(1,1) NOT NULL,
	Moviminetos_P1 int NOT NULL,
	Movimientos_p2 int NOT NULL,
	Conlusion varchar(10) NOT NULL,
	Tipo varchar(10) NOT NULL,
	Id_Partida int NOT NULL,
	Id_Jugador1 int NOT NULL,
	Id_Jugador2 int NOT NULL,
	PRIMARY KEY(Id_Partida_Jugada)
);

CREATE TABLE Torneo(
	Id_Torneo int IDENTITY(1,1) NOT NULL,
	Id_Partida int NOT NULL,
	Id_Torneo_Jugado int NOT NULL,
	PRIMARY KEY(Id_Torneo)
);

CREATE TABLE Torneo_Jugado(
	Id_Torneo_Jugado int IDENTITY(1,1) NOT NULL,
	Conclusion varchar(10) NOT NULL,
	PRIMARY KEY(Id_Torneo_Jugado)
);

---------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE spInsertUser
	@Nombre  VARCHAR(50),
	@Apellido VARCHAR(50),
	@Nombre_Usuario VARCHAR (50),
	@Contraseña VARCHAR (50),
	@Fecha_Nac DATE,
	@Pais VARCHAR (10),
	@Correo VARCHAR (20)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Usuario (/*Id_Usuario,*/Nombre,Apellido,Nombre_Usuario,Contraseña,Fecha_Nac,Pais,Correo)
			VALUES(/*@Id,*/@Nombre,@Apellido,@Nombre_Usuario,@Contraseña,@Fecha_Nac,@Pais,@Correo)
END
GO
-----------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE stpGetUserPass
	@Nombre_Usuario VARCHAR (50),
	@Contraseña VARCHAR (50)
AS
BEGIN
	SELECT TOP 1 COUNT(*) FROM Usuario
	WHERE Nombre_Usuario=@Nombre_Usuario and Contraseña=@Contraseña
END
GO
------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE getIdUsuario
	@Nombre_Usuario VARCHAR (50)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT Id_Usuario 
	FROM Usuario
	WHERE Nombre_Usuario=@Nombre_Usuario;
END  
GO
-------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ActualizarTorneo 
	@PartidaUno int,
	@PartidaDos int,
	@PartidaTres int,
	@PartidaCuatro int,
	@Team varchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE Torneo_Partidas
	SET PartidaUno=@PartidaUno,
		PartidaDos=@PartidaDos,
		PartidaTres=@PartidaTres,
		PartidaCuatro=@PartidaCuatro
		WHERE Team=@Team
END
GO
--------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spInsertJugador
	@Tipo_Jugador VARCHAR(30),
	@Id_Usuario int
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO Jugador(Tipo_Jugador,Id_Usuario)
	VALUES (@Tipo_Jugador,@Id_Usuario)
END
GO
--------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE getIdJugador
	@Nombre_Usuario VARCHAR(50)
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @id INT
	SET @id=(SELECT Id_Usuario 
	FROM Usuario 
	WHERE Nombre_Usuario=@Nombre_Usuario)
	--*--
	SELECT Id_Jugador 
	FROM Jugador 
	WHERE Id_Usuario=@id
END
GO
----------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE spInsertPartida 
	@Id_Jugador1 INT,
	@Id_Jugador2 int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Partida(Id_Jugador1,Id_Jugador2)
	VALUES (@Id_Jugador1,@Id_Jugador2)
END
GO