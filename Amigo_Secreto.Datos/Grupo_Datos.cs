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
   public class Grupo_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Grupo_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Grupos grupo)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Grupos_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",grupo.Id),
                    new SqlParameter("Descripcion",grupo.Id_Evento),
                    new SqlParameter("id_Participante",grupo.Id_Participante)

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



        public void Actualizar(Grupos grupo)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Grupos_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",grupo.Id),
                    new SqlParameter("Descripcion",grupo.Id_Evento),
                    new SqlParameter("id_Participante",grupo.Id_Participante)
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

        public static List<Grupos> ObtenerTodos()
        {
            List<Grupos> lista = new List<Grupos>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Grupos_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Grupos grupo = new Grupos();
                    grupo.Id = Convert.ToInt32(reader["Id"]);
                    grupo.Id_Participante = reader["id_Participante"].ToString();
                    grupo.Id_Evento = Convert.ToInt32(reader["descripcion"]);

                    lista.Add(grupo);
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

                SqlCommand command = new SqlCommand("SP_Grupos_DeleteRow", servidor.Conectar());
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

        public static Grupos ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Grupos_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Grupos grupo = new Grupos();
                    grupo.Id = Convert.ToInt32(reader["Id"]);
                    grupo.Id_Participante = reader["id_Participante"].ToString();
                    grupo.Id_Evento = Convert.ToInt32(reader["descripcion"]);

                    return grupo;
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