﻿using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;

namespace CineBack.Fachada.Implementacion
{
    public class AplicacionPelicula : IAplicacionPelicula
    {
        private IPeliculaDao dao;
        public AplicacionPelicula()
        {
            dao = new PeliculaDao();
        }
        public List<Actor> GetActoresPel()
        {
            throw new NotImplementedException();
        }

        public List<Dialecto> GetDialectos()
        {
            return dao.TraerDialectos();
        }

        public List<Director> GetDirectores()
        {
            return dao.TraerDirectores();
        }

        public List<TipoPelicula> GetTiposPeliculas()
        {
            return dao.TraerTiposPelicula();
        }

        public List<TipoPublico> GetTiposPublicos()
        {
            return dao.TraerTiposPublico();
        }

        public bool SavePelicula(Pelicula oPelicula)
        {
            return dao.Crear(oPelicula);
        }

        public List<Pelicula> GetPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto)
        {
            return dao.ObtenerPeliculasFiltradas(tipoPelicula, tipoPublico, dialecto);
        }

        public bool DeletePelicula(int idPelicula)
        {
            return dao.Borrar(idPelicula);
        }

        public bool ModifyPelicula(Pelicula oPelicula, int id)
        {
            return dao.Modificar(oPelicula, id);
        }

        public Pelicula GetPeliculaById(int idPelicula)
        {
            return dao.ObtenerPeliculaPorNro(idPelicula);
        }

    }
}
