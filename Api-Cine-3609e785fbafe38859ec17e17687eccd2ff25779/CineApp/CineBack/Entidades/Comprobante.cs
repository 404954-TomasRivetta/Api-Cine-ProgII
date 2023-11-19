namespace CineBack.Entidades
{
    public class Comprobante
    {
        public int IdCliente { get; set; }
        public int IdForma_pago { get; set; }
        public int IdEmpleado { get; set; }
        public int CantEntradas { get; set; }
        public List<Tickets> tickets { get; set; }

        public Comprobante()
        {
            tickets = new List<Tickets>();
        }
        public void AgregarTicket(Tickets ticket)
        {
            tickets.Add(ticket);
        }
        public void QuitarTicket(int posicion)
        {
            tickets.RemoveAt(posicion);
        }       
    }
}
