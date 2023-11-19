using CineBack.Entidades;

namespace CineBack.Fachada.Interfaz
{
    public interface IAplicacionCliente
    {
        List<Barrio> GetBarrios();
        Task<Cliente> GetClientesIdAsync(int id);
        bool SaveCliente(Cliente oCliente);

        bool ModifyCliente(int id, Cliente oCliente);

        bool DeleteCliente(int idCliente);


        List<Cliente> GetClientesFiltrados(int idBarrio);
    }
}
