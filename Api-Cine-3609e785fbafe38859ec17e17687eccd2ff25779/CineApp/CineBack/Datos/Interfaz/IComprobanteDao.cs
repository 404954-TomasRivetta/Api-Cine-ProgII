using CineBack.Entidades;

namespace CineBack.Datos.Interfaz
{
    public interface IComprobanteDao
    {
        bool Crear(Comprobante oC);
        List<Cliente> GetClientes();
        List<Empleado> GetEmpleados();
        List<TipoFormaPago> GetFormasPagos();
    }
}
