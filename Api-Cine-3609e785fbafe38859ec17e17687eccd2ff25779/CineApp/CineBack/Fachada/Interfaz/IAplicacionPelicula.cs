using CineBack.Entidades;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionPelicula
    {
        List<TipoPublico> GetTiposPublicos();
        List<Director> GetDirectores();

        List<Dialecto> GetDialectos();

        List<Actor> GetActoresPel();

        List<TipoPelicula> GetTiposPeliculas();

        bool SavePelicula(Pelicula oPelicula);

        List<Pelicula> GetPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto);

        bool DeletePelicula(int idPelicula);

        bool ModifyPelicula(Pelicula oPelicula, int id);

        Pelicula GetPeliculaById(int idPelicula);
    }
}
