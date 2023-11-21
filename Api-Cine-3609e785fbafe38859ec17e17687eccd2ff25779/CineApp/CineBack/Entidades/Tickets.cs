namespace CineBack.Entidades
{
    public class Tickets
    {
        public int IdComprobante { get; set; }
        //public int IdButaca { get; set; }
        public Butaca Butaca { get; set; }
        public double PreUnitario { get; set; }

        public Tickets()
        {

        }
        public Tickets(int com, Butaca b, double pre)
        {
            IdComprobante = com;
            Butaca = b;
            PreUnitario = pre;
        }
    }
}
