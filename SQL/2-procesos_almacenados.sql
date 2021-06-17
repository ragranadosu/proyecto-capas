use proyecto;

-------- Procedimientos Usuario ---------

-- Listar

SELECT * FROM libro;

CREATE PROC usuario_listar
AS
	SELECT idusuario as IdUsuario, nombre as Nombre, apellido as Apellido, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	ORDER BY idusuario ASC
GO

-- Listar Profesor

CREATE PROC usuario_listarProfesor
AS
	SELECT idusuario as IdUsuario, nombre as Nombre, apellido as Apellido, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	WHERE rol = 'profesor'
	ORDER BY idusuario ASC
GO

-- Buscar

CREATE PROC usuario_buscar
@valor varchar(30)
AS
	SELECT idusuario as IdUsuario, nombre as Nombre, apellido as Apellido, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	WHERE nombre like '%' + @valor + '%' or apellido like '%' + @valor + '%'
	ORDER BY nombre ASC
GO

-- Buscar profesor

CREATE PROC usuario_buscarProfesor
@valor varchar(30)
AS
	SELECT idusuario as IdUsuario, nombre as Nombre, apellido as Apellido, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	WHERE rol='profesor' AND nombre like '%' + @valor + '%' or apellido like '%' + @valor + '%'
	ORDER BY nombre ASC
GO

-- Buscar por Email

CREATE PROC usuario_buscarEmail
@email varchar(30)
AS
	SELECT idusuario as IdUsuario, nombre as Nombre, apellido as Apellido, email as Email, contrasena as Contrasena, rol as Rol
	FROM usuario
	WHERE email=@email
GO

-- Insertar

CREATE PROC usuario_insertar
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@email VARCHAR(50),
@contrasena VARCHAR (255),
@rol VARCHAR (20)
AS
	INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  values (@nombre, @apellido ,@email, @contrasena, @rol);
GO

-- Actualizar

CREATE PROC usuario_actualizar
@idusuario INTEGER,
@nombre varchar(50),
@apellido VARCHAR(50),
@email VARCHAR(50),
@contrasena VARCHAR (255),
@rol VARCHAR (20)
AS
	UPDATE usuario SET nombre=@nombre, apellido=@apellido ,email=@email, contrasena=@contrasena, rol=@rol
	WHERE idusuario=@idusuario
GO

-- Eliminar 

CREATE PROC usuario_eliminar
@idusuario INTEGER
AS
	DELETE FROM usuario
	WHERE idusuario=@idusuario
GO

-------- Procedimientos Libro ---------

-- Listar

CREATE PROC libro_listar
AS
	SELECT idlibro as IdLibro,codigo as Codigo ,titulo as Titulo, prestado as Prestado ,num_ejemplares as NumEjemplares, isbn as Isbn, autor as Autor, editorial as Editorial, anio_edicion as AnioEdicion, num_edicion as NumEdicion, pais as Pais, idioma as Idioma, materia as Materia, num_paginas as NumPaginas, ubicacion as Ubicacion, descripcion as Descripcion, activo as Activo
	FROM libro
	ORDER BY idlibro ASC
GO

-- Listar Activos

CREATE PROC libro_listarActivos
AS
	SELECT idlibro as IdLibro,codigo as Codigo ,titulo as Titulo, prestado as Prestado ,num_ejemplares as NumEjemplares, isbn as Isbn, autor as Autor, editorial as Editorial, anio_edicion as AnioEdicion, num_edicion as NumEdicion, pais as Pais, idioma as Idioma, materia as Materia, num_paginas as NumPaginas, ubicacion as Ubicacion, descripcion as Descripcion, activo as Activo
	FROM libro
	WHERE activo=1
	ORDER BY idlibro ASC
GO

--Buscar

CREATE PROC libro_buscar
@valor varchar(30)
AS
	SELECT idlibro as IdLibro, codigo as Codigo, titulo as Titulo, prestado as Prestado, num_ejemplares as NumEjemplares, isbn as Isbn, autor as Autor, editorial as Editorial, anio_edicion as AnioEdicion, num_edicion as NumEdicion, pais as Pais, idioma as Idioma, materia as Materia, num_paginas as NumPaginas, ubicacion as Ubicacion, descripcion as Descripcion, activo as Activo
	FROM libro
	WHERE titulo like '%' + @valor + '%' or descripcion like '%' + @valor + '%'
	ORDER BY titulo ASC
GO

--Buscar por codigo

CREATE PROC libro_buscar
@valor varchar(30)
AS
	SELECT idlibro as IdLibro, codigo as Codigo, titulo as Titulo, prestado as Prestado, num_ejemplares as NumEjemplares, isbn as Isbn, autor as Autor, editorial as Editorial, anio_edicion as AnioEdicion, num_edicion as NumEdicion, pais as Pais, idioma as Idioma, materia as Materia, num_paginas as NumPaginas, ubicacion as Ubicacion, descripcion as Descripcion, activo as Activo
	FROM libro
	WHERE codigo=@valor
	ORDER BY titulo ASC
GO

-- Insertar

CREATE PROC libro_insertar
@codigo VARCHAR(20),
@prestado BIT,
@titulo VARCHAR(50),
@num_ejemplares INTEGER,
@isbn VARCHAR(50),
@autor VARCHAR (255),
@editorial VARCHAR (20),
@anio_edicion VARCHAR(50),
@num_edicion INTEGER,
@pais VARCHAR(50),
@idioma VARCHAR(50),
@materia VARCHAR(50),
@num_paginas INTEGER,
@ubicacion VARCHAR(50),
@descripcion VARCHAR(255),
@activo BIT
AS
	INSERT INTO libro (codigo, titulo ,num_ejemplares, isbn,autor, editorial, anio_edicion, num_edicion, 
						pais, idioma, materia, num_paginas, ubicacion, descripcion, activo)
		values (@codigo, @titulo, @num_ejemplares, @isbn, @autor, @editorial, @anio_edicion, @num_edicion,
				@pais, @idioma, @materia, @num_paginas, @ubicacion, @descripcion, @activo);
GO

-- Actualizar

CREATE PROC libro_actualizar
@idlibro INTEGER,
@codigo VARCHAR(20),
@titulo VARCHAR(50),
@prestado bit,
@num_ejemplares INTEGER,
@isbn VARCHAR(50),
@autor VARCHAR (255),
@editorial VARCHAR (20),
@anio_edicion VARCHAR(50),
@num_edicion INTEGER,
@pais VARCHAR(50),
@idioma VARCHAR(50),
@materia VARCHAR(50),
@num_paginas INTEGER,
@ubicacion VARCHAR(50),
@descripcion VARCHAR(255),
@activo BIT
AS
	UPDATE libro SET codigo=@codigo, titulo=@titulo, prestado=@prestado,num_ejemplares=@num_ejemplares, isbn=@isbn, autor=@autor, editorial=@editorial,
					anio_edicion=@anio_edicion, num_edicion=@num_edicion, pais=@pais, idioma=@idioma, materia=@materia,
					num_paginas=@num_paginas, ubicacion=@ubicacion, descripcion=@descripcion, activo=@activo
	WHERE idlibro=@idlibro
GO

-- Eliminar 

CREATE PROC libro_eliminar
@idlibro INTEGER
AS
	DELETE FROM libro
	WHERE idlibro=@idlibro
GO

-------- Procedimientos Prestamo ---------

-- Listar

CREATE PROC prestamo_listar
AS
	SELECT idprestamo as IdPrestamo, idlibro as Libro, idusuario as Usuario, fecha as Fecha, fecha_limite as FechaLimite
	FROM prestamo
	ORDER BY idprestamo ASC
GO

-- Listar por id de profesor 

CREATE PROC prestamo_listarPorProfesor
@idprofesor INTEGER
AS
	SELECT idprestamo as IdPrestamo, idlibro as Libro, idusuario as Usuario, fecha as Fecha, fecha_limite as FechaLimite
	FROM prestamo
	WHERE idusuario=@idprofesor
	ORDER BY idprestamo ASC
GO

-- Insertar

CREATE PROC prestamo_insertar
@idlibro INTEGER,
@idusuario INTEGER,
@fecha DATE,
@fecha_limite DATE
AS
	UPDATE libro SET prestado=1 WHERE idlibro=@idlibro
	INSERT INTO prestamo (idlibro, idusuario, fecha, fecha_limite)  values (@idlibro, @idusuario, @fecha, @fecha_limite);
GO

-- Devolver 

CREATE PROC prestamo_devolver
@idprestamo INTEGER,
@idlibro INTEGER
AS
	UPDATE libro SET prestado=0 WHERE idlibro=@idlibro
	DELETE FROM prestamo WHERE idprestamo=@idprestamo
GO
