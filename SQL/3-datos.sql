use proyecto;

SELECT * FROM usuario;

INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  VALUES ('Andrea', 'Lopez', 'andreamail@mail.com', 'pass', 'admin');
INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  VALUES ('Raul', 'Granados', 'raulmail@mail.com', 'pass', 'profesor');

SELECT * FROM libro;

INSERT INTO libro (num_ejemplares, isbn,autor, editorial, anio_edicion, num_edicion, pais, idioma, materia, num_paginas, ubicacion, descripcion)
	VALUES ('')