using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CineBack.Datos.Implementacion
{
    public class PeliculaDao : IPeliculaDao
    {
        public bool Borrar(int id_pel)
        {
            string sp = "SP_ELIMINAR_PELICULA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idPelicula", id_pel));
            int afectadas = HelperDB.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public bool Crear(Pelicula pelicula)
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
                comando.CommandText = "SP_INSERTAR_PELICULA";
                comando.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                comando.Parameters.AddWithValue("@id_tipo_pelicula", pelicula.IdTipoPelicula);
                comando.Parameters.AddWithValue("@id_idioma", pelicula.IdIdioma);
                comando.Parameters.AddWithValue("@id_tipo_publico", pelicula.IdTipoPublico);
                comando.Parameters.AddWithValue("@subtitulada", pelicula.Subtitulada);
                comando.Parameters.AddWithValue("@id_director", pelicula.IdDirector);
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
            return resultado; ;
        }

        public Pelicula ObtenerPeliculaPorNro(int nro)
        {
            //SP_CONSULTAR_PELICULA_POR_NRO
            Pelicula pelicula = new Pelicula();
            string sp = "SP_CONSULTAR_PELICULA_POR_NRO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@idPelicula", nro));

            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow fila in dt.Rows)
            {
                pelicula.Descripcion = fila["descripcion"].ToString();
                pelicula.IdTipoPelicula = Convert.ToInt32(fila["id_tipo_pelicula"].ToString());
                pelicula.IdIdioma = Convert.ToInt32(fila["id_idioma"].ToString());
                pelicula.IdTipoPublico = Convert.ToInt32(fila["id_tipo_publico"].ToString());
                pelicula.Subtitulada = Convert.ToInt32(fila["subtitulada"].ToString());
                pelicula.IdDirector = Convert.ToInt32(fila["id_director"].ToString());

            }

            return pelicula;
        }

        public bool Modificar(Pelicula pelicula, int id)
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
                comando.CommandText = "SP_MODIFICAR_PELICULA";
                comando.Parameters.AddWithValue("@idPelicula", id);
                comando.Parameters.AddWithValue("@nombrePelicula", pelicula.Descripcion);
                comando.Parameters.AddWithValue("@tipoPelicula", pelicula.IdTipoPelicula);
                comando.Parameters.AddWithValue("@idIdioma ", pelicula.IdIdioma);
                comando.Parameters.AddWithValue("@idTipoPublico ", pelicula.IdTipoPublico);
                comando.Parameters.AddWithValue("@subtitulada ", pelicula.Subtitulada);
                comando.Parameters.AddWithValue("@idDirector ", pelicula.IdDirector);
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

        public List<Dialecto> TraerDialectos()
        {
            List<Dialecto> lDialectos = new List<Dialecto>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_DIALECTOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_idioma"].ToString());
                string desc = fila["descripcion"].ToString();
                Dialecto d = new Dialecto(id, desc);
                lDialectos.Add(d);
            }
            return lDialectos;
        }

        public List<Director> TraerDirectores()
        {
            List<Director> lDirectores = new List<Director>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_DIRECTORES");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_director"].ToString());
                string nom = fila["nombre"].ToString();
                string ape = fila["apellido"].ToString();
                Director d = new Director(id, nom, ape);
                lDirectores.Add(d);
            }
            return lDirectores;
        }
        public List<Pelicula> TraerPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_PELICULAS");
            foreach (DataRow fila in tabla.Rows)
            {
                string desc = fila["descripcion"].ToString();
                int id_tipo_pelicula = int.Parse(fila["id_tipo_pelicula "].ToString());
                int id_idioma = int.Parse(fila["id_idioma "].ToString());
                int id_tipo_publico = int.Parse(fila["id_tipo_publico "].ToString());
                int subtitulada = int.Parse(fila["id_tipo_pelicula "].ToString());
                int id_director = int.Parse(fila["id_tipo_pelicula "].ToString());
                Pelicula peli = new Pelicula(desc, id_tipo_pelicula, id_idioma, id_tipo_publico, subtitulada, id_director);
                lPeliculas.Add(peli);
            }
            return lPeliculas;
        }

        public List<TipoPelicula> TraerTiposPelicula()
        {
            List<TipoPelicula> lPeliculas = new List<TipoPelicula>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_PELICULAS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_tipo_pelicula"].ToString());
                string desc = fila["descripcion"].ToString();
                TipoPelicula t = new TipoPelicula(id, desc);
                lPeliculas.Add(t);
            }
            return lPeliculas;
        }

        public List<TipoPublico> TraerTiposPublico()
        {
            List<TipoPublico> lTipoPublicos = new List<TipoPublico>();
            DataTable tabla = HelperDB.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_PUBLICO");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_tipo_publico"].ToString());
                string desc = fila["descripcion"].ToString();
                TipoPublico t = new TipoPublico(id, desc);
                lTipoPublicos.Add(t);
            }
            return lTipoPublicos;
        }

        public List<Pelicula> ObtenerPeliculasFiltradas(int tipoPelicula, int tipoPublico, int dialecto)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            string sp = "[dbo].[SP_FILTRAR_PELICULA]";

            List<Parametro> lst = new List<Parametro>();

            lst.Add(new Parametro("@genero", tipoPelicula != 0 ? tipoPelicula : DBNull.Value));
            lst.Add(new Parametro("@publico", tipoPublico != 0 ? tipoPublico : DBNull.Value));
            lst.Add(new Parametro("@dialecto", dialecto != 0 ? dialecto : DBNull.Value));

            DataTable dt = HelperDB.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Pelicula pelicula = new Pelicula();

                pelicula.IdPelicula = Convert.ToInt32(row[0].ToString());
                pelicula.Descripcion = row[1].ToString();
                pelicula.IdTipoPelicula = Convert.ToInt32(row[2].ToString());
                pelicula.IdIdioma = Convert.ToInt32(row[3].ToString());
                pelicula.IdTipoPublico = Convert.ToInt32(row[4].ToString());
                pelicula.Subtitulada = Convert.ToInt32(row[5].ToString());
                pelicula.IdDirector = Convert.ToInt32(row[6].ToString());

                peliculas.Add(pelicula);
            }

            return peliculas;
        }
    }
}
