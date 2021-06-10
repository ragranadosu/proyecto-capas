use proyecto;

-------- Procedimientos Usuario ---------

-- Listar

CREATE PROC usuario_listar
AS
	SELECT idusuario as IdUsuario, nombre_completo as Nombre, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	ORDER BY idusuario DESC
GO

-- Buscar

CREATE PROC usuario_buscar
@valor varchar(30)
AS
	SELECT idusuario as IdUsuario, nombre_completo as Nombre, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	WHERE nombre_completo like '%' + @valor + '%'
	ORDER BY nombre_completo DESC
GO

-- Insertar

CREATE PROC usuario_insertar
@nombre varchar(50),
@email VARCHAR(50),
@contrasena VARCHAR (255),
@rol VARCHAR (20)
AS
	INSERT INTO usuario (nombre_completo, email, contrasena, rol)  values (@nombre, @email, @contrasena, @rol);
GO

-- Actualizar

CREATE PROC usuario_actualizar
@idusuario INTEGER,
@nombre varchar(50),
@email VARCHAR(50),
@contrasena VARCHAR (255),
@rol VARCHAR (20)
AS
	UPDATE usuario SET nombre_completo=@nombre, email=@email, contrasena=@contrasena, rol=@rol
	WHERE idusuario=@idusuario
GO

-- Eliminar 

CREATE PROC usuario_eliminar
@idusuario INTEGER
AS
	DELETE FROM usuario
	WHERE idusuario=@idusuario
GO