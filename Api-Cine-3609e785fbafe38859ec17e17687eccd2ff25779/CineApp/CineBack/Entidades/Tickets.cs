namespace CineBack.Entidades
{
    public class Tickets
    {
        public int IdComprobante { get; set; }
        public int IdButaca { get; set; }
        public double PreUnitario { get; set; }

        public Tickets()
        {
            IdComprobante = 0;
            IdButaca = 0;
            PreUnitario = 0;
        }
        public Tickets(int com, int but, double pre)
        {
            IdComprobante = com;
            IdButaca = but;
            PreUnitario = pre;
        }
    }
}
