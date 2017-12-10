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
    public class Regalo_Datos
    {
    
        Servidor servidor;
        private SqlDataReader cargar;

        public Regalo_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Regalo regalo)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Regalo_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",regalo.Id),
                    new SqlParameter("nombre",regalo.Nombre),
                    new SqlParameter("canidad",regalo.Cantida),
                    new SqlParameter("foto",regalo.Foto),
                    new SqlParameter("enlace",regalo.Enlace),
                    new SqlParameter("deseo",regalo.Deseado),
                    new SqlParameter("descripcion",regalo.Descripcion),
                    new SqlParameter("id_Participante",regalo.Id_Participante)

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



        public void Actualizar(Regalo regalo)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Regalo_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                   new SqlParameter("id",regalo.Id),
                    new SqlParameter("nombre",regalo.Nombre),
                    new SqlParameter("canidad",regalo.Cantida),
                    new SqlParameter("foto",regalo.Foto),
                    new SqlParameter("enlace",regalo.Enlace),
                    new SqlParameter("deseo",regalo.Deseado),
                    new SqlParameter("descripcion",regalo.Descripcion),
                    new SqlParameter("id_Participante",regalo.Id_Participante)
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

        public static List<Regalo> ObtenerTodos()
        {
            List<Regalo> lista = new List<Regalo>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Regalo_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Regalo regalo = new Regalo();
                    regalo.Id = Convert.ToInt32(reader["id"].ToString());
                    regalo.Nombre = reader["Nombre"].ToString();
                    regalo.Cantida = Convert.ToChar(reader["cantidad"]);
                    //participante.Foto = Convert.ToSByte(reader["foto"].ToString());
                    regalo.Enlace = reader["enlace"].ToString();
                    regalo.Deseado = Convert.ToBoolean(reader["deseo"]);
                    regalo.Descripcion = reader["descripcion"].ToString();
                    regalo.Id_Participante =reader["id_participante"].ToString();

                    lista.Add(regalo);
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

                SqlCommand command = new SqlCommand("SP_Regalo_DeleteRow", servidor.Conectar());
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

        public static Regalo ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Regalo_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Regalo regalo = new Regalo();
                    regalo.Id = Convert.ToInt32(reader["id"].ToString());
                    regalo.Nombre = reader["Nombre"].ToString();
                    regalo.Cantida = Convert.ToChar(reader["cantidad"]);
                    //participante.Foto = Convert.ToSByte(reader["foto"].ToString());
                    regalo.Enlace = reader["enlace"].ToString();
                    regalo.Deseado = Convert.ToBoolean(reader["deseo"]);
                    regalo.Descripcion = reader["descripcion"].ToString();
                    regalo.Id_Participante = reader["id_participante"].ToString();


                    return regalo;
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