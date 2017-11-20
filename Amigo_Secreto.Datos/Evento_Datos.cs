using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Amigo_Secreto.Datos
{
    public class Evento_Datos
    {
        private Servidor servidor;
        private SqlDataReader cargar;

        public Evento_Datos()
        {
            servidor = new Servidor();

        }
        public void Crear_Evento(Evento evento)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Evento_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",evento.Id),
                    new SqlParameter("nombre",evento.Nombre),
                    new SqlParameter("f_limite",evento.F_Limite),
                    new SqlParameter("f_entrega",evento.F_Entrega),
                    new SqlParameter("cupo",evento.Cupo),
                    new SqlParameter("localizacion",evento.Localizacion),
                    new SqlParameter("activo",evento.Activo),
                    new SqlParameter("p_minimo_regalo",evento.P_Minimo_Regalo),
                    new SqlParameter("p_maximo_regalo",evento.P_Maximo_Regalo),
                    new SqlParameter("grupo",evento.Grupo)
                };
                command.Parameters.AddRange(parameters);
                cargar = command.ExecuteReader();



            }
            catch
            {
                throw;
            }
            finally
            {
                servidor.Desconectar();
            }
        }



        public void Actualizar(Evento evento)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Evento_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",evento.Id),
                    new SqlParameter("nombre",evento.Nombre),
                    new SqlParameter("f_limite",evento.F_Limite),
                    new SqlParameter("f_entrega",evento.F_Entrega),
                    new SqlParameter("cupo",evento.Cupo),
                    new SqlParameter("localizacion",evento.Localizacion),
                    new SqlParameter("activo",evento.Activo),
                    new SqlParameter("p_minimo_regalo",evento.P_Minimo_Regalo),
                    new SqlParameter("p_maximo_regalo",evento.P_Maximo_Regalo),
                    new SqlParameter("grupo",evento.Grupo)
               };
                command.Parameters.AddRange(parameters);
                // Ejecuta la sentencia sql en la conexion indicada
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                servidor.Desconectar();
            }
        }

        public List<Evento> ObtenerTodos()
        {
            List<Evento> lista = new List<Evento>();

            try
            {

                SqlCommand command = new SqlCommand("SP_Evento_SelectAll", servidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Evento evento = new Evento();
                    evento.Id = Convert.ToInt32(reader["Id"]);
                    evento.Nombre = reader["Nombre"].ToString();
                    evento.F_Limite = Convert.ToDateTime(reader["f_limite"]);
                    evento.F_Entrega = Convert.ToDateTime(reader["f_entrega"]);
                    evento.Cupo = Convert.ToInt32(reader["cupo"]);
                    evento.Localizacion = reader["localizacion"].ToString();
                    evento.Activo = Convert.ToBoolean(reader["activo"].ToString());
                    evento.P_Maximo_Regalo = Convert.ToInt32(reader["p_maximo_regalo"]);
                    evento.P_Minimo_Regalo = Convert.ToInt32(reader["p_minimo_regalo"]);
                    evento.Grupo = Convert.ToBoolean(reader["grupo"]);
                    
                    lista.Add(evento);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                servidor.Desconectar();
            }

            return lista;
        }

        public void Eliminar(int id)
        {
            try
            {
               
                SqlCommand command = new SqlCommand("SP_Evento_DeleteRow", servidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                command.ExecuteNonQuery();


            }
            catch
            {
                throw;
            }
            finally
            {
                servidor.Desconectar();
            }
        }

        public static Evento ObtenerPorId(int id)
        {
            // System.Configuration: necesita agregar la referencia
            string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["Heladeria.UI.Properties.Settings.CadenaConexion"].ConnectionString;

            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_Evento_SelectRow";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Evento cat = new Evento();
                    cat.Id = Convert.ToInt32(reader["Id"]);
                    cat.Nombre = reader["Nombre"].ToString();

                   // cat.Helados = HeladoDatos.ObtenerPorCategoria(cat.Id);

                    return cat;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}