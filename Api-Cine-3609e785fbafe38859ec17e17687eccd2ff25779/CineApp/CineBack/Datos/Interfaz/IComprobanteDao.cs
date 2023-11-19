using CineBack.Entidades;

namespace CineBack.Datos.Interfaz
{
    public interface IComprobanteDao
    {
        bool Crear(Comprobante oC);
        List<Cliente> GetClientes();
        List<Empleado> GetEmpleados();
        List<TipoFormaPago> GetFormasPagos();
        List<Pelicula> TraerPeliculas();

        List<Funciones> TraerFunciones(int nro);

        int ObtenerProximoComprobante();
    }
}
