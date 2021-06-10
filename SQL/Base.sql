CREATE DATABASE proyecto;

-- DROP DATABASE proyecto;

use proyecto;

CREATE TABLE usuario (
	idsuario INTEGER IDENTITY PRIMARY KEY,
	nombre VARCHAR(30),
	apellido VARCHAR(30),
	email VARCHAR(50),
	contrasena VARCHAR(255),
	rol VARCHAR(30)
);

CREATE TABLE libro (
	idlibro INTEGER IDENTITY PRIMARY KEY,
	num_ejemplares INTEGER,
	isbn VARCHAR(60),
	autor VARCHAR(255),
	editorial VARCHAR(50),
	anio_edicion VARCHAR(5),
	num_edicion VARCHAR(10),
	pais VARCHAR(30),
	idioma VARCHAR(50),
	materia VARCHAR(50),
	num_paginas INTEGER,
	ubicacion VARCHAR(10),
	descripcion VARCHAR(255)
)

CREATE TABLE prestamo (
	libro INTEGER,
	usuario INTEGER,
	fecha DATE,
	fechalimite DATE
);