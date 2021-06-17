use proyecto;

SELECT * FROM usuario;

INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  VALUES ('Andrea', 'Lopez', 'andreamail@mail.com', 'pass', 'admin');
INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  VALUES ('Raul', 'Granados', 'raulmail@mail.com', 'pass', 'profesor');

SELECT * FROM libro;

INSERT INTO libro (codigo ,titulo ,num_ejemplares, isbn,autor, editorial, anio_edicion, num_edicion, pais, idioma, materia, num_paginas, ubicacion, descripcion, activo)
	VALUES ('asd123','Libro 1', 3, '23423421', 'Autor 1', 'Editorial 1', '2000', 2,'El Salvador', 'Ingles', 'Ciencias', 20, '4C', 'Libro de ciencias', 1);

INSERT INTO libro (codigo ,titulo ,num_ejemplares, isbn,autor, editorial, anio_edicion, num_edicion, pais, idioma, materia, num_paginas, ubicacion, descripcion, activo)
	VALUES ('asd124','Libro 2', 3, '23423424', 'Autor 2', 'Editorial 1', '2000', 2,'El Salvador', 'Ingles', 'Ciencias', 20, '45', 'Libro de ciencias', 1);

INSERT INTO libro (codigo ,titulo ,num_ejemplares, isbn,autor, editorial, anio_edicion, num_edicion, pais, idioma, materia, num_paginas, ubicacion, descripcion, activo)
	VALUES ('asd125','Libro 3', 3, '23423425', 'Autor 2', 'Editorial 1', '2000', 2,'El Salvador', 'Ingles', 'Ciencias', 20, '45', 'Libro de ciencias', 0);