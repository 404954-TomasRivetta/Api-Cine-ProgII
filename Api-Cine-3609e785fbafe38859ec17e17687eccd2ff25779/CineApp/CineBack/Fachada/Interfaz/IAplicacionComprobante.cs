using CineBack.Entidades;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionComprobante
    {
        List<Cliente> GetClientes();
        List<Empleado> GetEmpleados();
        List<TipoFormaPago> GetFormasPagos();
        bool SaveComprobante(Comprobante oComprobante);
        List<Pelicula> GetPeliculas();

        List<Funciones> TraerFunciones(int nro);
        int ObtenerProximoPresupuesto();
        public int ObtenerProximaButaca();
    }
}
