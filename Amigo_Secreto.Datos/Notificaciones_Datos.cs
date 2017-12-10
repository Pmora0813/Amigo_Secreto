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
    public class Notificaciones_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Notificaciones_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Enviar_Notificaciones notificacion)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Enviar_Notificaciones_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",notificacion.Id),
                    new SqlParameter("Descripcion",notificacion.Descripcion),
                    new SqlParameter("id_Participante",notificacion.Id_Participante),
                    new SqlParameter("noti_general",notificacion.General),

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



        public void Actualizar(Enviar_Notificaciones enviar_Notif)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Notificaciones_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",enviar_Notif.Id),
                    new SqlParameter("Descripcion",enviar_Notif.Descripcion),
                    new SqlParameter("id_Participante",enviar_Notif.Id_Participante),
                    new SqlParameter("noti_general",enviar_Notif.General),
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

        public static List<Enviar_Notificaciones> ObtenerTodos()
        {
            List<Enviar_Notificaciones> lista = new List<Enviar_Notificaciones>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Notificaciones_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Enviar_Notificaciones enviar_notif = new Enviar_Notificaciones();
                    enviar_notif.Id = Convert.ToInt32(reader["Id"]);
                    enviar_notif.Id_Participante = reader["id_Participante"].ToString();
                    enviar_notif.Descripcion = reader["descripcion"].ToString();
                    enviar_notif.General = Convert.ToBoolean(reader["General"]);

                    lista.Add(enviar_notif);
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

                SqlCommand command = new SqlCommand("SP_Enviar_Notificaciones_DeleteRow", servidor.Conectar());
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

        public static Enviar_Notificaciones ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Notificaciones_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Enviar_Notificaciones enviar_notif = new Enviar_Notificaciones();
                    enviar_notif.Id = Convert.ToInt32(reader["Id"]);
                    enviar_notif.Id_Participante = reader["id_Participante"].ToString();
                    enviar_notif.Descripcion = reader["descripcion"].ToString();
                    enviar_notif.General = Convert.ToBoolean(reader["General"]);

                    return enviar_notif;
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