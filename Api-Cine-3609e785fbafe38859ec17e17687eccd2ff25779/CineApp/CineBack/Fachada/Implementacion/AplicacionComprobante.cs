using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;

namespace CineBack.Fachada.Implementacion
{
    public class AplicacionComprobante : IAplicacionComprobante
    {
        IComprobanteDao dao;

        public AplicacionComprobante()
        {
            dao = new ComprobanteDao();
        }
        public bool SaveComprobante(Comprobante oComprobante)
        {
            return dao.Crear(oComprobante);
        }
        public int ObtenerProximoPresupuesto()
        {
            return dao.ObtenerProximoComprobante();
        }

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        public List<Empleado> GetEmpleados()
        {
            return dao.GetEmpleados();
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            return dao.GetFormasPagos();
        }

        public List<Pelicula> GetPeliculas()
        {
            return dao.TraerPeliculas();
        }

        public List<Funciones> TraerFunciones(int nro)
        {
            return dao.TraerFunciones(nro);
        }
    }
}
