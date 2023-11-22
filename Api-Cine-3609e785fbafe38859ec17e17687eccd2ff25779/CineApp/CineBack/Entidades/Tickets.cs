namespace CineBack.Entidades
{
    public class Tickets
    {
        public int IdComprobante { get; set; }
        //public int IdButaca { get; set; }
        public int IdButaca { get; set; }
        public double PreUnitario { get; set; }

        public Tickets()
        {

        }
        public Tickets(int com, int idButaca, double pre)
        {
            IdComprobante = com;
            IdButaca = idButaca;
            PreUnitario = pre;
        }
    }
}
