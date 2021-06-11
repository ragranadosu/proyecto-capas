use proyecto;

SELECT * FROM usuario WHERE email = 'raulmail@mail.com';

INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  values ('Andrea', 'Lopez', 'andreamail@mail.com', 'pass', 'admin');
INSERT INTO usuario (nombre, apellido, email, contrasena, rol)  values ('Raul', 'Granados', 'raulmail@mail.com', 'pass', 'profesor');