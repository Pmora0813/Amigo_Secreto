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
    public class ListaInv_Datos
    {
        private Servidor servidor;
        private SqlDataReader cargar;


        public ListaInv_Datos()
        {
            servidor = new Servidor();
        }

        public void Guardar(Lista_Invitados invitados)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_lista_invitados_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",invitados.Id),
                    new SqlParameter("Correos",invitados.Correo)
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

        public static int ObtenerUltimo()
        {
            Servidor oservidor = new Servidor();
            int ultimo;
            try
            {

                SqlCommand command = new SqlCommand("SP_lista_invitados_Ultimo", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlDataReader reader = command.ExecuteReader();
                object valor = command.ExecuteScalar();
                ultimo = Convert.ToInt32( valor);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                oservidor.Desconectar();
            }
            return ultimo;
        }

        public static List<Lista_Invitados> obtenerTodos()
        {
            List<Lista_Invitados> lista = new List<Lista_Invitados>();
            Servidor oservidor = new Servidor();
            try
            {
                SqlCommand command = new SqlCommand("SP_lista_invitados_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Lista_Invitados listaInv = new Lista_Invitados();
                    listaInv.Id = Convert.ToInt32(reader["id"].ToString());
                    listaInv.Correo = reader["Correos"].ToString();

                    lista.Add(listaInv);
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

        public static Lista_Invitados ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();
            try
            {
                SqlCommand command = new SqlCommand("SP_lista_invitados_SelectRow", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Lista_Invitados invitado = new Lista_Invitados();
                    invitado.Id = Convert.ToInt32(reader["Id"]);
                    invitado.Correo = reader["Correos"].ToString();

                    return invitado;
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


        public void Eliminar(int id)
        {
            try
            {

                SqlCommand command = new SqlCommand("SP_lista_invitados_DeleteRow", servidor.Conectar());
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
    }


}
