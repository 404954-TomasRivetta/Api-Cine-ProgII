﻿using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CineBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public List<Barrio> TraerBarrios()
        {
            List<Barrio> lBarrios = new List<Barrio>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_BARRIOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["cod_barrio"].ToString());
                string desc = fila["descripcion"].ToString();
                Barrio b = new Barrio(cod, desc);
                lBarrios.Add(b);
            }
            return lBarrios;
        }
        public Cliente TraerClienteId(int id)
        {
            Cliente c = new Cliente();
            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@id", id));
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTE_POR_ID", lParametros);

            foreach (DataRow fila in tabla.Rows)
            {
                c.CodCliente = (int)fila["id_cliente"];
                c.Nombre = fila["nombre"].ToString();
                c.Apellido = fila[2].ToString();
                c.Correo = fila[3].ToString();
                c.NroTel = Convert.ToInt32(fila[4]);
                c.CodBarrio = Convert.ToInt32(fila[5]);
                c.Calle = fila[6].ToString();
                c.CalleNro = Convert.ToInt32(fila[7]);
                c.Dni = Convert.ToInt32(fila[8]);
            }
            return c;
        }
        public bool Modificar(int id, Cliente cliente)
        {
            bool resultado = true;
            SqlConnection conexion= HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "sp_modificar_cliente";
                comando.Parameters.AddWithValue("@id_cliente",id);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@correo", cliente.Correo);
                comando.Parameters.AddWithValue("@nro_tel", cliente.NroTel);
                comando.Parameters.AddWithValue("@cod_barrio", cliente.CodBarrio);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@calle_nro", cliente.CalleNro);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {

                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;            
        }
        public bool Borrar(int idCliente)
        {
            string sp = "SP_BORRAR_CLIENTE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idCliente", idCliente));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public bool Crear(Cliente cliente)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_CLIENTE";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@correo", cliente.Correo != "" ? cliente.Correo : DBNull.Value);
                comando.Parameters.AddWithValue("@nro_tel", cliente.NroTel);
                comando.Parameters.AddWithValue("@cod_barrio", cliente.CodBarrio);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@calle_nro", cliente.CalleNro);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }

        public List<Cliente> ObtenerClientesFiltrados(int idBarrio)
        {
            List<Cliente> clientes = new List<Cliente>();
            string sp = "SP_CONSULTAR_CLIENTES_CON_FILTROS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_barrio", idBarrio != 0 ? idBarrio : DBNull.Value));
            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Cliente c = new Cliente();
                c.CodCliente = int.Parse(row[0].ToString());
                c.Nombre = row[1].ToString();
                c.Correo = row[2].ToString();
                c.CodBarrio = Convert.ToInt32(row[3].ToString());
                c.NroTel = Convert.ToInt32(row[4].ToString());
                clientes.Add(c);
            }

            return clientes;
        }
    }
}
