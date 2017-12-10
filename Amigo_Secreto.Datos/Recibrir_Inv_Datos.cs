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
    public class Recibrir_Inv_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Recibrir_Inv_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Recivir_Invitaciones recibir_inv)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Recivir_Invitaciones_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",recibir_inv.Id),
                    new SqlParameter("Id_Participante",recibir_inv.Id_Participante),
                    new SqlParameter("descripcion",recibir_inv.Descripcion)


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



        public void Actualizar(Recivir_Invitaciones recibir_inv)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Recivir_Invitaciones_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",recibir_inv.Id),
                    new SqlParameter("Id_Participante",recibir_inv.Id_Participante),
                    new SqlParameter("descripcion",recibir_inv.Descripcion)
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

        public static List<Recivir_Invitaciones> ObtenerTodos()
        {
            List<Recivir_Invitaciones> lista = new List<Recivir_Invitaciones>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Recivir_Invitacioness_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Recivir_Invitaciones recibir_Inv = new Recivir_Invitaciones();
                    recibir_Inv.Id = Convert.ToInt32(reader["Id"]);
                    recibir_Inv.Id_Participante = reader["id_Participante"].ToString();
                    recibir_Inv.Descripcion = reader["descripcion"].ToString();

                    lista.Add(recibir_Inv);
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

                SqlCommand command = new SqlCommand("SP_Recivir_Invitaciones_DeleteRow", servidor.Conectar());
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

        public static Recivir_Invitaciones ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Recivir_Invitaciones_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Recivir_Invitaciones recibir_Inv = new Recivir_Invitaciones();
                    recibir_Inv.Id = Convert.ToInt32(reader["Id"]);
                    recibir_Inv.Id_Participante = reader["id_Participante"].ToString();
                    recibir_Inv.Descripcion = reader["descripcion"].ToString();

                    return recibir_Inv;
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