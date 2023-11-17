--create database lc_tpi_cine
--go
--use lc_tpi_cine
--go

create table barrios(
cod_barrio int identity(1,1),
descripcion varchar(100)
constraint pk_barrio primary key (cod_barrio)
)

create table clientes
(
id_cliente int identity(1,1),
nombre varchar(150),
apellido varchar(150),
correo varchar(150),
nro_tel int,
cod_barrio int,
calle varchar(150),
calle_nro int,
dni int
constraint pk_cliente primary key(id_cliente)
constraint fk_barrio foreign key (cod_barrio) references barrios (cod_barrio)
)

create table empleados
(
id_empleado int identity(1,1),
nombre varchar(150),
apellido varchar(150),
correo varchar(150),
nro_tel int,
cod_barrio int,
calle varchar(150),
calle_nro int,
dni int
constraint pk_empleados primary key(id_empleado),
constraint fk_barrio_empleados foreign key (cod_barrio) references barrios (cod_barrio)
)

create table forma_pago(
id_forma_pago INT IDENTITY(1, 1),
descripcion varchar(100),
CONSTRAINT pk_forma_pago PRIMARY KEY (id_forma_pago)
)
create table tipo_salas(
    id_tipo_sala int identity(1,1),
    tipo_sala varchar(50)
    constraint pk_id_tipo_sala primary key(id_tipo_sala)
)

create table tipos_publico
(
id_tipo_publico int identity(1,1),
descripcion varchar(150)
constraint pk_tipo_publico primary key(id_tipo_publico)
)

create table dialectos (
id_idioma int identity(1,1),
descripcion varchar(50),
CONSTRAINT pk_dialectos PRIMARY KEY (id_idioma)
)

create table tipos_pelicula (
id_tipo_pelicula int identity(1,1),
descripcion varchar(50),
CONSTRAINT pk_tipos_pelicula PRIMARY KEY (id_tipo_pelicula)
)
create table directores(
id_director int identity(1,1),
nombre varchar(70),
apellido varchar(80)
constraint pk_director primary key (id_director)
)
create table peliculas(
    id_pelicula int identity(1,1),
    descripcion varchar(150) not null,
    id_tipo_pelicula int,
    id_idioma int,
    id_tipo_publico int,
    subtitulada int,
	id_director int
    constraint pk_id_pelicula PRIMARY KEY (id_pelicula),
    constraint fk_id_tipo_pelicula FOREIGN KEY (id_tipo_pelicula)
        references tipos_pelicula(id_tipo_pelicula),
    constraint fk_id_tipo_publico FOREIGN KEY (id_tipo_publico)
        references tipos_publico(id_tipo_publico),
    constraint fk_id_idioma FOREIGN KEY (id_idioma)
        references dialectos(id_idioma),
	constraint fk_director foreign key (id_director)
	    references directores (id_director)
)
create table actores(
id_actor int identity(1,1),
apellido varchar(60),
nombre varchar(50)
constraint pk_actor primary key (id_actor)
)
create table actores_pel(
id_actores_pel int identity(1,1),
id_pelicula int,
id_actor int
CONSTRAINT pk_id_actores_pel PRIMARY KEY (id_actores_pel)
constraint fk_pelicula foreign key(id_pelicula) references peliculas(id_pelicula),
constraint fk_actor foreign key(id_actor) references actores(id_actor)

)

create table salas (
id_sala int identity(1,1),
id_tipos_salas int
CONSTRAINT pk_salas PRIMARY KEY (id_sala)
CONSTRAINT fk_salas_tipo FOREIGN KEY (id_tipos_salas) REFERENCES tipo_salas (id_tipo_sala)
)

create table funciones(
id_funcion INT IDENTITY(1, 1),
id_sala INT,
id_pelicula INT,
fecha datetime,
hora int
CONSTRAINT pk_funcion PRIMARY KEY (id_funcion),
CONSTRAINT fk_sala_funcion FOREIGN KEY (id_sala)
REFERENCES salas (id_sala),
CONSTRAINT fk_pelicula_funcion FOREIGN KEY (id_pelicula)
REFERENCES peliculas (id_pelicula)
)
create table estados_butaca(
id_estado_butaca int identity(1,1),
estado_butaca varchar(60)
constraint pk_estado_butaca primary key (id_estado_butaca)
)
create table butacas(
id_butaca int identity(1,1),
fila int,
columna int,
id_funcion int,
id_estado_butaca int
constraint pk_butaca primary key(id_butaca)
constraint fk_funcion foreign key(id_funcion) references funciones(id_funcion),
constraint fk_estado_butaca foreign key(id_estado_butaca) references estados_butaca (id_estado_butaca)
)

create table comprobantes (
id_comprobante int identity(1,1),
id_cliente int,
id_forma_pago int,
id_empleado int,
cant_entradas int
CONSTRAINT pk_comprobantes PRIMARY KEY (id_comprobante),
CONSTRAINT fk_comprobantes_cliente FOREIGN KEY (id_cliente) REFERENCES clientes (id_cliente),
CONSTRAINT fk_comprobantes_empleado FOREIGN KEY (id_empleado) REFERENCES empleados (id_empleado),
CONSTRAINT fk_comprobantes_forma FOREIGN KEY (id_forma_pago) REFERENCES forma_pago (id_forma_pago)
)

create table tickets
(
id_ticket int identity(1,1),
id_comprobante int,
id_butacas int,
pre_unitario int
CONSTRAINT pk_ticket PRIMARY KEY(id_ticket),
CONSTRAINT fk_comprobante FOREIGN KEY(id_comprobante) REFERENCES comprobantes (id_comprobante),
CONSTRAINT fk_id_butacas_ticket FOREIGN KEY (id_butacas) REFERENCES Butacas(id_butaca)
)

create table reservas
(
id_reserva int identity(1,1),
id_cliente int,
id_butaca int,
nombre_reserva varchar(150),
fecha_reserva date,
constraint pk_reservas primary key(id_reserva),
constraint fk_cliente foreign key(id_cliente) references clientes(id_cliente),
constraint fk_id_butaca foreign key(id_butaca) references Butacas(id_butaca)
)