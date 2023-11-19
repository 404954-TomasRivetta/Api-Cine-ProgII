namespace CineBack.Entidades
{
    public class TipoPelicula
    {
        public int IdTipoPelicula { get; set; }

        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
        public TipoPelicula(int id, string desc)
        {
            IdTipoPelicula = id;
            Descripcion = desc;
        }

    }
}
