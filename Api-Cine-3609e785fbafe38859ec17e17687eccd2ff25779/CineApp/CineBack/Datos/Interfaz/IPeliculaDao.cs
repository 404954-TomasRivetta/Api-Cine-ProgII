using CineBack.Entidades;

namespace CineBack.Datos.Interfaz
{
    public interface IPeliculaDao
    {
        bool Modificar(Pelicula pelicula, int id);
        bool Borrar(int id_pel);
        bool Crear(Pelicula pelicula);
        List<Dialecto> TraerDialectos();
        List<TipoPelicula> TraerTiposPelicula();
        List<TipoPublico> TraerTiposPublico();
        List<Director> TraerDirectores();

        List<Pelicula> ObtenerPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto);

        Pelicula ObtenerPeliculaPorNro(int nro);

    }
}
