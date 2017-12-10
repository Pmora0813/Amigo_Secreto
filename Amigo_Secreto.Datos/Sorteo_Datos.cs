using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Datos
{
    public class Sorteo_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Sorteo_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Sorteo sorteo)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Sorteo_Insert", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",sorteo.Id),
                    new SqlParameter("id_Grupo",sorteo.Id_Grupo)

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



        public void Actualizar(Sorteo sorteo)
        {

            try
            {
                // Ejecuta la sentencia sql en la conexion indicada
                SqlCommand command = new SqlCommand("SP_Sorteo_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",sorteo.Id),
                    new SqlParameter("id_Grupo",sorteo.Id_Grupo)
               };
                command.Parameters.AddRange(parameters);
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

        public static List<Sorteo> ObtenerTodos()
        {
            List<Sorteo> lista = new List<Sorteo>();
            Servidor oservidor = new Servidor();

            try
            {
                // Ejecuta la sentencia sql en la conexion indicada
                SqlCommand command = new SqlCommand("SP_Sorteo_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
              
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Sorteo sorteo = new Sorteo();
                    sorteo.Id = Convert.ToInt32(reader["id"].ToString());
                    sorteo.Id_Grupo = Convert.ToInt32(reader["id_Grupo"].ToString());

                    lista.Add(sorteo);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                oservidor.Desconectar();
            }

            return lista;
        }

        public void Eliminar(int id)
        {
            try
            {

                SqlCommand command = new SqlCommand("SP_Sorteo_DeleteRow", servidor.Conectar());
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

        public static Sorteo ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Sorteo_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Sorteo sorteo = new Sorteo();
                    sorteo.Id = Convert.ToInt32(reader["id"].ToString());
                    sorteo.Id_Grupo = Convert.ToInt32(reader["id_Grupo"].ToString());



                    return sorteo;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                oservidor.Desconectar();
            }

            return null;
        }

    }
}