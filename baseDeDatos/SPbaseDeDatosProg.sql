use lc_tpi_cine

create procedure SP_CONSULTAR_BARRIOS
as
begin
    select * from barrios order by 2
end
--------------------------------------------------
create procedure SP_CONSULTAR_EMPLEADOS
as
begin
    select * from empleados order by 2
end
--------------------------------------------------
create procedure SP_CONSULTAR_FORMAS_PAGO
as
begin
    select * from forma_pago order by 2
end
--------------------------------------------------
create procedure SP_CONSULTAR_CLIENTES
as
begin
    select * from clientes order by 2
end
----------------------------------------------------------
create procedure SP_CONSULTAR_TIPOS_PELICULAS
as
begin
    select * from tipos_pelicula order by 2
end
-----------------------------------------------------------
create procedure SP_CONSULTAR_DIALECTOS
as
begin
    select * from dialectos order by 2
end
-----------------------------------------------------------
create procedure SP_CONSULTAR_DIRECTORES
as
begin
    select * from directores order by 2
end
-----------------------------------------------------------
create procedure SP_CONSULTAR_TIPOS_PUBLICO
as
begin
    select * from tipos_publico order by 2
end
-----------------------------------------------------------
create procedure SP_CONSULTAR_ACTORES
as
begin
    select * from actores order by 2
end
-----------------------------------------------------------
create procedure SP_CONSULTAR_PELICULA_POR_NRO
@idPelicula int
as
begin
	select * from peliculas
	where id_pelicula=@idPelicula
end
-----------------------------------------------------------
--SP INSERTAR PELICULA--
create procedure [dbo].[SP_INSERTAR_PELICULA]
@descripcion varchar(150),
@id_tipo_pelicula int,
@id_idioma int,
@id_tipo_publico int,
@subtitulada int,
@id_director int
as
insert into peliculas(descripcion,id_tipo_pelicula,id_idioma,id_tipo_publico,subtitulada,id_director)
values(@descripcion,@id_tipo_pelicula,@id_idioma,@id_tipo_pelicula,@subtitulada,@id_director)

--SP INSERTAR CLIENTE--
create procedure SP_INSERTAR_CLIENTE
@nombre varchar(150)=null,@apellido varchar(150)=null,@correo varchar(150)=null,@nro_tel int=null
,@cod_barrio int=null,
@calle varchar(150)=null,@calle_nro int=null,@dni int=null
as
insert into clientes(nombre,apellido,correo,nro_tel,cod_barrio,calle,calle_nro,dni)
values(@nombre,@apellido,@correo,@nro_tel,@cod_barrio,@calle,@calle_nro,@dni)

--SP MODIFICAR CLIENTE--
create procedure SP_MODIFICAR_CLIENTE
@nombre varchar(150),@apellido varchar(150),@correo varchar(150),@nro_tel int,@cod_barrio int,
@calle varchar(150),@calle_nro int,@dni int,@id_cliente int
as
update clientes
set nombre=@nombre,apellido=@apellido,correo=@correo,nro_tel=@nro_tel,cod_barrio=@cod_barrio,
calle=@calle,calle_nro=@calle_nro
where id_cliente=@id_cliente

--SP MODIFICAR PELICULA
create procedure SP_MODIFICAR_PELICULA
@idPelicula int,
@nombrePelicula varchar(150),
@tipoPelicula int,
@idIdioma int,
@idTipoPublico int,
@subtitulada int,
@idDirector int
as
update peliculas
set descripcion = @nombrePelicula,id_tipo_pelicula=@tipoPelicula,
	id_idioma=@idIdioma,id_tipo_publico=@idTipoPublico,
	subtitulada = @subtitulada,
	id_director = @idDirector
where id_pelicula=@idPelicula

--SP INSERTAR COMPROBANTE--
create procedure [dbo].[SP_INSERTAR_COMPROBANTE]
@id_cliente int,
@id_forma_pago int,
@id_empleado int,
@cant_estradas int
as
insert into comprobantes(id_cliente, id_forma_pago, id_empleado, cant_entradas)
values(@id_cliente, @id_forma_pago, @id_empleado, @cant_estradas)

--SP CONSULTAR PELICULA FILTRADA
create procedure [dbo].[SP_FILTRAR_PELICULA]
@genero int=null,
@publico int=null,
@dialecto int=null
as
begin
	select p.id_pelicula,
			p.descripcion,
			p.id_tipo_pelicula,
			P.id_idioma,
			P.id_tipo_publico,
			p.subtitulada,
			P.id_director
	from peliculas p
	where (@genero is null OR p.id_tipo_pelicula = @genero)
	AND (@publico is null OR P.id_tipo_publico = @publico)
	AND (@dialecto is null OR P.id_idioma = @dialecto)
	AND (p.fechaBaja is null)
end

--SP BORRAR PELICULA
alter PROCEDURE [dbo].[SP_ELIMINAR_PELICULA] 
	@idPelicula int
AS
BEGIN
	update peliculas
	set fechaBaja = GETDATE()
	where id_pelicula = @idPelicula
END

select * from peliculas

--SP BORRAR CLIENTE
alter procedure SP_BORRAR_CLIENTE
	@idCliente int
AS
BEGIN
	update clientes
	set fechaBaja = GETDATE()
	where id_cliente = @idCliente
END

--SP FILTRAR CLIENTE
alter PROCEDURE SP_CONSULTAR_CLIENTES_CON_FILTROS
@id_barrio int=null,
@cliente varchar(50)=null
as
select C.id_cliente,c.nombre+' '+c.apellido, c.correo, c.cod_barrio,c.nro_tel
from clientes c
where (@id_barrio is null or c.cod_barrio=@id_barrio)
    and (@cliente is null OR c.apellido LIKE '%' + @cliente + '%')
	and (c.fechaBaja is null)

exec SP_CONSULTAR_CLIENTES_CON_FILTROS

select * from clientes

--REPORTE
create procedure SP_REPORTE_GENEROS_MAS_TAQUILLEROS
as
select tip.descripcion as genero, sum(cant_entradas * pre_unitario) as facturacion
from comprobantes c
join tickets t on t.id_comprobante=c.id_comprobante
join butacas b on t.id_butacas = b.id_butaca
join funciones f on f.id_funcion = b.id_funcion
join peliculas p on p.id_pelicula = f.id_pelicula
join tipos_pelicula tip on tip.id_tipo_pelicula = p.id_tipo_pelicula
GROUP BY tip.descripcion
order by Facturacion  DESC

--REPORTE 2
create procedure SP_REPORTE_PELICULAS_MAS_TAQUILLERAS
as
select p.descripcion as pelicula, sum(cant_entradas * pre_unitario) as Facturacion
from comprobantes c
join tickets t on t.id_comprobante=c.id_comprobante
join butacas b on t.id_butacas = b.id_butaca
join funciones f on f.id_funcion = b.id_funcion
join peliculas p on p.id_pelicula = f.id_pelicula
GROUP BY p.descripcion
order by Facturacion  DESC