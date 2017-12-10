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
    public class Enviar_Invita_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Enviar_Invita_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Enviar_Invitaciones Enviar_Inv)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Enviar_Invitaciones_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",Enviar_Inv.id),
                    new SqlParameter("nombre",Enviar_Inv.Id_Evento),
                    new SqlParameter("f_limite",Enviar_Inv.Id_listaInvitaciones)
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



        public void Actualizar(Enviar_Invitaciones enviar_inv)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Invitaciones_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",enviar_inv.id),
                    new SqlParameter("nombre",enviar_inv.Id_Evento),
                    new SqlParameter("f_limite",enviar_inv.Id_listaInvitaciones)
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

        public static List<Enviar_Invitaciones> ObtenerTodos()
        {
            List<Enviar_Invitaciones> lista = new List<Enviar_Invitaciones>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Invitaciones_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Enviar_Invitaciones enviar_inv = new Enviar_Invitaciones();
                    enviar_inv.id = Convert.ToInt32(reader["Id"]);
                    enviar_inv.Id_Evento = Convert.ToInt32(reader["id_Evento"]);
                    enviar_inv.Id_listaInvitaciones = Convert.ToInt32(reader["id_ListaInvitados"]);

                    lista.Add(enviar_inv);
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

                SqlCommand command = new SqlCommand("SP_Enviar_Invitaciones_DeleteRow", servidor.Conectar());
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

        public static Enviar_Invitaciones ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Enviar_Invitaciones_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Enviar_Invitaciones evento = new Enviar_Invitaciones();
                    evento.id = Convert.ToInt32(reader["Id"]);
                    evento.Id_Evento = Convert.ToInt32(reader["Id_Evento"]);
                    evento.Id_listaInvitaciones = Convert.ToInt32(reader["Id_listaInvitaciones"]);

                    return evento;
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