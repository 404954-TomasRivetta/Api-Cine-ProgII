namespace CineBack.Entidades
{
    public class Actor
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
