﻿using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CineBack.Datos.Implementacion
{
    public class ComprobanteDao : IComprobanteDao
    {
        public bool Crear(Comprobante oC)
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
                comando.CommandText = "dbo.SP_INSERTAR_COMPROBANTE";
                comando.Parameters.AddWithValue("@id_cliente", oC.IdCliente);
                comando.Parameters.AddWithValue("@id_forma_pago", oC.IdForma_pago);
                comando.Parameters.AddWithValue("@id_empleado", oC.IdEmpleado);
                comando.Parameters.AddWithValue("@cant_estradas", oC.CantEntradas);
                comando.Parameters.AddWithValue("@id_funcion", oC.IdFuncion);
                
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_comprobante";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(pOut);
                comando.ExecuteNonQuery();

                int comprobanteNum = (int)pOut.Value;

                SqlCommand cmdDetalle;

                int detalleNro = 1;

                foreach (Tickets ti in oC.tickets)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_TICKET",conexion,t);

                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_comprobante", comprobanteNum);
                    cmdDetalle.Parameters.AddWithValue("@id_butaca", ti.IdButaca);
                    cmdDetalle.Parameters.AddWithValue("@pre_unitario", ti.PreUnitario);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }

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
        public List<Butaca> GetButacasOcupadas(int idFuncion)
        {
            List<Butaca> lButacas = new List<Butaca>();

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("id_funcion", idFuncion));
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_BUTACAS_OCUPADAS",lParametros);
            foreach(DataRow fila in tabla.Rows)
            {
                Butaca b = new Butaca();
                b.IdButaca = Convert.ToInt32(fila["id_butaca"]);
                b.Fila= Convert.ToInt32(fila["fila"]);
                b.Columna=Convert.ToInt32(fila["columna"]);
                lButacas.Add(b);
            }
            return lButacas;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_cliente"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                string correo = fila["correo"].ToString();
                int tel = int.Parse(fila["nro_tel"].ToString());
                int barrio = int.Parse(fila["cod_barrio"].ToString());
                string calle = fila["calle"].ToString();
                int calleNro = int.Parse(fila["calle_nro"].ToString());
                int dni = int.Parse(fila["dni"].ToString());
                Cliente c = new Cliente(cod, nom, ape, correo, tel, barrio, calle, calleNro, dni);
                lClientes.Add(c);
            }
            return lClientes;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> lEmpleados = new List<Empleado>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_EMPLEADOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_empleado"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                string correo = fila["correo"].ToString();
                int tel = int.Parse(fila["nro_tel"].ToString());
                int barrio = int.Parse(fila["cod_barrio"].ToString());
                string calle = fila["calle"].ToString();
                int calleNro = int.Parse(fila["calle_nro"].ToString());
                int dni = int.Parse(fila["dni"].ToString());
                Empleado e = new Empleado(cod, nom, ape, correo, tel, barrio, calle, calleNro, dni);
                lEmpleados.Add(e);
            }
            return lEmpleados;
        }

        public List<TipoFormaPago> GetFormasPagos()
        {
            List<TipoFormaPago> lForma = new List<TipoFormaPago>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_FORMAS_PAGO");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["id_forma_pago"].ToString());
                string des = fila["descripcion"].ToString();
                TipoFormaPago t = new TipoFormaPago();
                t.Descripcion = des;
                t.id = cod;
                lForma.Add(t);
            }
            return lForma;
        }

        public int ObtenerProximaButaca()
        {
            string sp = "SP_PROXIMA_BUTACA";
            return HelperDB.ObtenerInstancia().ProximoComprobante(sp, "@next");
        }

        public int ObtenerProximoComprobante()
        {
            string sp = "SP_PROXIMO_ID";
            return HelperDB.ObtenerInstancia().ProximoComprobante(sp,"@next");
        }

        public List<Funciones> TraerFunciones(int nro)
        {
            List<Funciones> lFunciones = new List<Funciones>();
            string sp = "SP_FECHA_HORA_FUNCION_PELICULA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_pelicula", nro));

            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow fila in dt.Rows)
            {
                Funciones f = new Funciones();
                f.IdFuncion = (int)fila[0];
                f.FechaHora = fila[1].ToString();
                lFunciones.Add(f);
            }
            
            return lFunciones;
        }

        public List<Pelicula> TraerPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULAS_Comprobante");
            foreach (DataRow fila in tabla.Rows)
            {
                int id_pelicula = Convert.ToInt32(fila["id_pelicula"].ToString());
                string desc = fila["descripcion"].ToString();
                Pelicula peli = new Pelicula(id_pelicula, desc);
                lPeliculas.Add(peli);
            }
            return lPeliculas;
        }
    }
}
