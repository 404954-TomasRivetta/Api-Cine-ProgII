using CineBack.Entidades;

namespace CineBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool Modificar(int id, Cliente cliente);
        bool Borrar(int IdCliente);

        bool Crear(Cliente cliente);
        List<Barrio> TraerBarrios();
        Cliente TraerClienteId(int id);

        List<Cliente> ObtenerClientesFiltrados(int idBarrio);

    }
}
