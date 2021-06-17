CREATE DATABASE proyecto;

-- DROP DATABASE proyecto;

use proyecto;

CREATE TABLE usuario (
	idusuario INTEGER IDENTITY PRIMARY KEY,
	nombre VARCHAR(30),
	apellido VARCHAR(30),
	email VARCHAR(50),
	contrasena VARCHAR(255),
	rol VARCHAR(30)
);

CREATE TABLE libro (
	idlibro INTEGER IDENTITY PRIMARY KEY,
	codigo VARCHAR(20),
	titulo VARCHAR(150),
	prestado BIT DEFAULT 0,
	num_ejemplares INTEGER,
	isbn VARCHAR(60),
	autor VARCHAR(255),
	editorial VARCHAR(50),
	anio_edicion VARCHAR(5),
	num_edicion INTEGER,
	pais VARCHAR(30),
	idioma VARCHAR(50),
	materia VARCHAR(50),
	num_paginas INTEGER,
	ubicacion VARCHAR(10),
	descripcion VARCHAR(255),
	activo BIT,

)

CREATE TABLE prestamo (
	idprestamo INTEGER IDENTITY PRIMARY KEY,
	idlibro INTEGER,
	idusuario INTEGER,
	fecha DATE,
	fecha_limite DATE,
	FOREIGN KEY (idlibro) REFERENCES libro (idlibro),
	FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);