--use lc_tpi_cine

set dateformat dmy

-- Estados de las butacas
INSERT INTO estados_butaca VALUES('OCUPADA')
INSERT INTO estados_butaca VALUES('LIBRE')
-- Formas de pago
INSERT INTO forma_pago VALUES('Efectivo')
INSERT INTO forma_pago VALUES('Transferencia')
INSERT INTO forma_pago VALUES('Tarjeta de credito')
INSERT INTO forma_pago VALUES('Tarjeta de débito')
--TIPOS DE PUBLICO
INSERT INTO tipos_publico(descripcion)
VALUES 
 ('Niños'),
 ('Adolescentes'),
 ('Jovenes'),
 ('Adultos'),
 ('Ancianos')

 --DIRECTORES
INSERT INTO directores(nombre,apellido)
VALUES
('Steven','Spielberg'),
('James','gunn'),
('Martin','Scorsese'),
('Quentin','Tarantino'),
('Tim','Burton')
--Dialectos
INSERT INTO dialectos (descripcion) VALUES ('Castellano')
INSERT INTO dialectos (descripcion) VALUES ('Español Latino')
INSERT INTO dialectos (descripcion) VALUES ('Inglés')
INSERT INTO dialectos (descripcion) VALUES ('Italiano')
INSERT INTO dialectos (descripcion) VALUES ('Francés')
--Tipos de peliculas
INSERT INTO tipos_pelicula (descripcion) VALUES ('Acción')
INSERT INTO tipos_pelicula (descripcion) VALUES ('Aventura')
INSERT INTO tipos_pelicula (descripcion) VALUES ('Comedia')
INSERT INTO tipos_pelicula (descripcion) VALUES ('Terror')
INSERT INTO tipos_pelicula (descripcion) VALUES ('Ciencia Ficción')

--BARRIOS
insert into barrios(descripcion)
values ('1 de mayo')
insert into barrios(descripcion)
values ('Alberdi')
insert into barrios(descripcion)
values ('Alta Córdoba')
insert into barrios(descripcion)
values ('Alto Palermo')
insert into barrios(descripcion)
values ('Alto Alberdi')
insert into barrios(descripcion)
values ('Altos San Martín')
insert into barrios(descripcion)
values ('Argüello Norte')
insert into barrios(descripcion)
values ('Autódromo')
insert into barrios(descripcion)
values ('Bella Vista')
insert into barrios(descripcion)
values ('Bajo General Paz')
insert into barrios(descripcion)
values ('Bajo Galan')
insert into barrios(descripcion)
values ('Congreso')
insert into barrios(descripcion)
values ('El Cabildo')
insert into barrios(descripcion)
values ('El Trébol')
insert into barrios(descripcion)
values ('Ejército Argentino')
insert into barrios(descripcion)
values ('General Paz')
insert into barrios(descripcion)
values     ('General Artigas')
insert into barrios(descripcion)
values ('General Belgrano')
insert into barrios(descripcion)
values ('General Bustos')
insert into barrios(descripcion)
values ('Horizonte')
insert into barrios(descripcion)
values ('Inaudi')
insert into barrios(descripcion)
values ('Ituzaingo')

--Actores--
insert into actores(apellido,nombre)
values('Mortensen','Sara')
insert into actores(apellido,nombre)
values('Statham','Jason')
insert into actores(apellido,nombre)
values('Johnson','Dwayne')
insert into actores(apellido,nombre)
values('Watson','Emma')
insert into actores(apellido,nombre)
values('Smith','Will')
insert into actores(apellido,nombre)
values('Cruise','Tom')
insert into actores(apellido,nombre)
values('DiCaprio','Leonardo')
insert into actores(apellido,nombre)
values('Jolie','Angelina')

-- TIPOS DE SALAS
INSERT INTO tipo_salas VALUES('Sala 2D')
INSERT INTO tipo_salas VALUES('Sala 3D')
INSERT INTO tipo_salas VALUES('Sala XD')
INSERT INTO tipo_salas VALUES('Sala PLAY')

-- SALAS
INSERT INTO salas(id_tipos_salas)
VALUES
(1),
(2),
(3),
(4)

-- PELICULAS
INSERT INTO peliculas(descripcion,id_tipo_pelicula,id_idioma,id_tipo_publico,subtitulada,id_director)
VALUES
('Soy leyenda',1,1,1,1,1),
('Volver al futuro',1,1,1,1,1),
('Barbie',2,2,2,2,1),
('Oppenhaimer',2,2,2,2,2),
('Spiderman',3,3,3,2,3),
('Jonh Wick',3,3,3,1,3),
('Kill bill',4,4,4,1,4),
('Reservoir dogs',4,4,4,1,4),
('Batman',5,5,5,2,5),
('El padrino',5,5,5,1,5),
('Titanic', 1, 1, 1, 1, 1),
('El Señor de los Anillos', 1, 1, 1, 1, 1),
('Toy Story', 2, 2, 2, 2, 2),
('La La Land', 2, 2, 2, 2, 2),
('Jurassic Park', 3, 3, 3, 2, 3),
('Inception', 3, 3, 3, 1, 3),
('Pulp Fiction', 4, 4, 4, 1, 4),
('The Shawshank Redemption', 4, 4, 4, 1, 4),
('The Dark Knight', 5, 5, 5, 2, 5),
('Forrest Gump', 5, 5, 5, 1, 5);

-- FUNCIONES
INSERT INTO funciones(id_sala,id_pelicula,fecha,hora)
VALUES
(1,1,'1/1/2023',8),
(1,1,'4/2/2022',9),
(1,2,'7/3/2021',11),
(2,2,'11/4/2020',14),
(2,3,'14/5/2019',16),
(2,3,'17/6/2018',18),
(3,4,'19/7/2017',20),
(3,4,'24/8/2016',21),
(4,5,'27/10/2015',22),
(3, 6, '2/2/2014', 10),
(3, 7, '5/3/2013', 12),
(1, 8, '8/4/2013', 14),
(4, 9, '11/5/2015', 16),
(4, 10, '14/6/2016', 18),
(2, 11, '17/7/2017', 20),
(2, 12, '20/8/2020', 22),
(1, 13, '23/9/2022', 24),
(1, 14, '26/10/2010', 26),
(3, 14, '29/11/2016', 28);
INSERT INTO funciones(id_sala,id_pelicula,fecha,hora)
VALUES
(1,1,'21/11/2023',8),
(1,1,'22/11/2023',9),
(1,2,'24/11/2023',11),
(2,2,'24/11/2023',14),
(2,3,'25/11/2023',16),
(2,3,'26/11/2023',18),
(3,4,'20/11/2023',20),
(3,4,'24/11/2023',21),
(4,5,'27/11/2023',22),
(3, 6, '2/11/2023', 10),
(3, 7, '20/11/2023', 12),
(1, 8, '19/11/2023', 14),
(4, 9, '18/11/2023', 16),
(4, 10, '17/11/2023', 18),
(2, 11, '17/11/2023', 20),
(2, 12, '20/11/2023', 22),
(1, 13, '23/11/2023', 24),
(1, 14, '26/11/2023', 26),
(3, 14, '29/11/2023', 28);

--Butacas
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (2,6,2,1)
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (5,10,1,1)
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (4,8,3,1)
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (6,12,4,1)
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (8,9,5,1)
INSERT INTO butacas (fila,columna,id_funcion,id_estado_butaca) VALUES (10,6,6,1)
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (3, 7, 2, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (6, 11, 1, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (5, 9, 3, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (7, 13, 4, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (9, 10, 5, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (11, 7, 6, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (5, 6, 1, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (7, 6, 2, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (1, 6, 3, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 4, 4, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (3,4, 5, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 7, 6, 1);
INSERT INTO butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 6, 7, 1);


--Clientes
insert into clientes(nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Rodrigo','Moran','rodriMoran@hotmail.com.ar',351354958,3,'Manuel belgrano',32,42574321)

insert into clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Nicolas','Perlo','nicoPerlo@gmail.com',351846394,9,' Nicaragua',80,44457913)

insert into clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Alexis','Cantonati','alexisCantonati@yahoo.com',351568741,11,'San Martin',105,44951248)

insert into clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni) 
VALUES('Santiago','Artaza','santiArtaza@hotmail.com.ar',351256413,6,'Mar del plata',25,44465846)

insert into clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni) 
VALUES('Valentino','Bertello','valenBertello@gmail.com',351259301,8,'Peron',60,45241874)

insert into clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Tomas','Rivetta','tomasRivetta@yahoo.com',351338677,2,'Honduras',90,44924654)

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('María','López','mariaLopez@gmail.com',351456789,5,'San Juan',40,41234567);

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Lucas','Gómez','lucasGomez@hotmail.com',351987654,7,'Rivadavia',75,42223333);

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni) 
VALUES('Carolina','Martínez','caroMartinez@yahoo.com',351111111,10,'Buenos Aires',15,43334444);

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
VALUES('Gustavo','Fernández','gusFernandez@gmail.com',351222222,4,'La Rioja',55,44445555);

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni) 
VALUES('Liliana','Suarez','liliSuarez@hotmail.com.ar',351333333,1,'Tucumán',85,45556666);

INSERT INTO clientes (nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni) 
VALUES('Federico','García','fedeGarcia@yahoo.com',351444444,12,'Córdoba',100,46667777);


--Empleados
insert into empleados VALUES('Carlos','Rosa','carlosRosa@hotmail.com.ar',351224488,6,'Casa rosada',200,35099126)

insert into empleados VALUES('Maia','Rodriguez','MaiRodriguez@gmail.com',351241563,9,'Chile',110,30145654)

insert into empleados VALUES('Marina','Lopez','mariLopez@yahoo.com',351227895,1,'Belgrano',25,30654123)

insert into empleados VALUES('Valentina','Caceres','valenCaceres@gmail.com',351287456,2,'Casa blanca',500,35624512)

insert into empleados VALUES('Cesar','Alegre','cesarAlegre@yahoo.com',351654587,3,'Pasadena',25,25987453)

insert into empleados VALUES('Lucas','Caceres','lucasCaceres@hotmail.com',351205120,5,'Libertad',230,36254874)

INSERT INTO empleados VALUES('Laura','Gutiérrez','lauraGutierrez@gmail.com',351334455,4,'Recoleta',150,31234567);

INSERT INTO empleados VALUES('Diego','Ramírez','diegoRamirez@hotmail.com',351876543,7,'San Telmo',80,32223333);

INSERT INTO empleados VALUES('Martín','Pérez','martinPerez@yahoo.com',351999999,10,'Palermo',30,33334444);

INSERT INTO empleados VALUES('Ana','Fernández','anaFernandez@gmail.com',351888888,5,'Nuñez',250,34445555);

INSERT INTO empleados VALUES('Roberto','Sánchez','robertoSanchez@hotmail.com.ar',351777777,1,'Flores',35,35556666);

INSERT INTO empleados VALUES('Karina','Torres','karinaTorres@yahoo.com',351666666,12,'Villa Devoto',120,36667777);

--Actores pel
insert into actores_pel(id_pelicula,id_actor)
values (1,1)
insert into actores_pel(id_pelicula,id_actor)
values (2,2)
insert into actores_pel(id_pelicula,id_actor)
values (2,3)
insert into actores_pel(id_pelicula,id_actor)
values (4,3)
insert into actores_pel(id_pelicula,id_actor)
values (3,1)
insert into actores_pel(id_pelicula,id_actor)
values (2,1)
insert into actores_pel(id_pelicula,id_actor)
values (1,4)
insert into actores_pel(id_pelicula,id_actor)
values (11,5)
insert into actores_pel(id_pelicula,id_actor)
values (12,5)
insert into actores_pel(id_pelicula,id_actor)
values (13,6)
insert into actores_pel(id_pelicula,id_actor)
values (14,7)
insert into actores_pel(id_pelicula,id_actor)
values (15,7)
insert into actores_pel(id_pelicula,id_actor)
values (16,8)
insert into actores_pel(id_pelicula,id_actor)
values (17,8)


--Reservas
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(1,1,'Nicolas','09/10/2023')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(2,6,'Alexis','28/11/2023')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(5,4,'Santiago','01/01/2024')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(4,3,'Lautaro','05/11/2023')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(1,3,'Tomas','05/01/2024')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(3,4,'Martin','12/12/2023')
insert into reservas(id_cliente,id_butaca,nombre_reserva,fecha_reserva)
values(3,5,'Fabricio','28/12/2023')
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (6, 8, 'Ana', '15/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (7, 10, 'Pedro', '02/12/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (8, 7, 'Lucía', '18/12/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (9, 9, 'Elena', '24/12/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (10, 12, 'Juan', '05/01/2024');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (11, 5, 'Luisa', '15/01/2024');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (12, 2, 'Fernando', '02/02/2024');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (12, 2, 'Fernando', '02/02/2024');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (2,1, 'Fernando', '16/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (12,15, 'Garcia', '16/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (10,13, 'Gufe', '16/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (4,6, 'Artaza', '16/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (9,10, 'Cati', '16/11/2023');
INSERT INTO reservas(id_cliente, id_butaca, nombre_reserva, fecha_reserva) VALUES (7,11, 'Lopez', '16/11/2023');

--Comprobantes
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (2,3,4,5)
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (3,1,1,2)
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (5,2,2,20)
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (1,4,6,10)
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (4,4,3,4)
INSERT INTO comprobantes (id_cliente,id_forma_pago,id_empleado,cant_entradas) VALUES (6,1,5,2)
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (7, 1, 3, 8);
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (8, 1, 5, 15);
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (9, 2, 4, 12);
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (10, 2, 2, 6);
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (11, 3, 1, 3);
INSERT INTO comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (12, 4, 6, 18);

--Tickets
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (4,2,1500)
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (3,3,1800)
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (1,5,1700)
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (5,4,2000)
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (1,1,1425)
INSERT INTO tickets (id_comprobante,id_butacas,pre_unitario) VALUES (6,6,1550)
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (7, 7, 900);
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (8, 8, 3900);
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (9, 9, 5750);
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (10, 10, 4100);
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (11, 11, 850);
INSERT INTO tickets (id_comprobante, id_butacas, pre_unitario) VALUES (12, 12, 1800);

insert into funciones (id_sala, id_pelicula, fecha, hora)values(3, 4, '15/11/2023', 23)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 2, 11, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (6, 2, 1, 9)
insert tickets (id_comprobante, id_butacas, pre_unitario) VALUES (7, 7, 2500)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(2, 5, '14-11-2023', 22)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 3, 12, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (5, 2, 1, 4)
insert tickets (id_comprobante, id_butacas, pre_unitario) VALUES (8, 8, 1699)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 6, '12-11-2023', 21)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 4, 13, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (4, 1, 1, 2)
insert tickets (id_comprobante, id_butacas, pre_unitario) VALUES (9, 9, 900)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(2, 7, '11-11-2023', 20)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 5, 14, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (3, 1, 1, 4)
insert tickets (id_comprobante, id_butacas, pre_unitario) VALUES (10, 10, 2199)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(2, 8, '15-11-2023', 19)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 6, 15, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 1, 1, 10)
insert tickets (id_comprobante, id_butacas, pre_unitario) VALUES (11, 11, 999)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 9, '10-11-2023', 18)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 6, 15, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 6)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (12, 12, 1800)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 10, '9-11-2023', 17)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 7, 17, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 8)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (13, 13, 2200)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 9, '15-11-2023', 16)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 7, 18, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 7)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (14, 14, 900)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 4, '16-11-2023', 22)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 9, 18, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 8)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (15, 15, 1000)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 7, '12-11-2023', 22)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 9, 19, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 8)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (16, 16, 1000)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 5, '8-11-2023', 22)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 10, 20, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 8)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (17, 17, 2800)

insert into funciones (id_sala, id_pelicula, fecha, hora)values(1, 6, '8-11-2023', 22)
insert into butacas (fila, columna, id_funcion, id_estado_butaca) VALUES (2, 10, 21, 2);
insert into comprobantes (id_cliente, id_forma_pago, id_empleado, cant_entradas) VALUES (2, 2, 1, 8)
insert into tickets (id_comprobante, id_butacas, pre_unitario) VALUES (18, 18, 2800)



update butacas
set fila=1,columna=4
where id_butaca=31
update butacas
set fila=1,columna=5
where id_butaca=32
update butacas
set fila=1,columna=6
where id_butaca=33
update butacas
set fila=1,columna=7
where id_butaca=34
update butacas
set fila=1,columna=8
where id_butaca=35
update butacas
set fila=1,columna=9
where id_butaca=36
update butacas
set fila=1,columna=10
where id_butaca=37
update butacas
set fila=1,columna=11
where id_butaca=38 
update butacas
set fila=2,columna=3
where id_butaca=39
update butacas
set fila=2,columna=4
where id_butaca=40
update butacas
set fila=2,columna=5
where id_butaca=41
update butacas
set fila=2,columna=6
where id_butaca=42
update butacas
set fila=2,columna=7
where id_butaca=43
update butacas
set fila=2,columna=8
where id_butaca=44
update butacas
set fila=2,columna=9
where id_butaca=45
update butacas
set fila=2,columna=10
where id_butaca=46
update butacas
set fila=2,columna=11
where id_butaca=47
update butacas
set fila=2,columna=12
where id_butaca=48
update butacas
set fila=3,columna=2
where id_butaca=49
update butacas
set fila=3,columna=3
where id_butaca=50
update butacas
set fila=3,columna=4
where id_butaca=51
update butacas
set fila=3,columna=5
where id_butaca=52
update butacas
set fila=3,columna=6
where id_butaca=53
update butacas
set fila=3,columna=7
where id_butaca=54
update butacas
set fila=3,columna=8
where id_butaca=55
update butacas
set fila=3,columna=9
where id_butaca=56
update butacas
set fila=3,columna=10
where id_butaca=57
update butacas
set fila=3,columna=11
where id_butaca=58
update butacas
set fila=3,columna=12
where id_butaca=59
update butacas
set fila=3,columna=13
where id_butaca=60
update butacas
set fila=4,columna=1
where id_butaca=61
update butacas
set fila=4,columna=2
where id_butaca=62

INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES (4, NULL, 3)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES (4, NULL, 4)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 5)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 6)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 7)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 8)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 9)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 10)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 11)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES ( 4, NULL, 12)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES (4, NULL, 13)
GO
INSERT [dbo].[butacas] ([fila], [id_estado_butaca], [columna]) VALUES (4, NULL, 14)