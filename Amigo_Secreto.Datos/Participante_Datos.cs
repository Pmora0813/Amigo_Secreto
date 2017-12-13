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
    public class Participante_Datos
    {
        Servidor servidor;
        private SqlDataReader cargar;

        public Participante_Datos()
        {
            servidor = new Servidor();

        }
        public void Guardar(Participante participante)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Participante_Insert", servidor.Conectar());

                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("id",participante.id),
                    new SqlParameter("correo",participante.Correo),
                    new SqlParameter("nombre",participante.Nombre),
                    new SqlParameter("genero",participante.Genero),
                    new SqlParameter("telefono",participante.Telefono),
                    new SqlParameter("foto",participante.Foto),
                    new SqlParameter("registrado",participante.Registrado),
                    new SqlParameter("id_Rol",participante.Id_Rol),
                    new SqlParameter("id_Regalo",participante.Id_Regalo),
                    new SqlParameter("id_Evento",participante.Id_Evento)

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

                SqlCommand command = new SqlCommand("SP_Participante_Ultimo", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlDataReader reader = command.ExecuteReader();
                object valor = command.ExecuteScalar();
                ultimo = Convert.ToInt32(valor);
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

        public void Actualizar(Participante participante)
        {

            try
            {

                SqlCommand command = new SqlCommand("SP_Participante_Update", servidor.Conectar());
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter[] parameters = new SqlParameter[]
               {
                    new SqlParameter("id",participante.id),
                    new SqlParameter("correo",participante.Correo),
                    new SqlParameter("nombre",participante.Nombre),
                    new SqlParameter("genero",participante.Genero),
                    new SqlParameter("telefono",participante.Telefono),
                    new SqlParameter("foto",participante.Foto),
                    new SqlParameter("registrado",participante.Registrado),
                    new SqlParameter("id_Rol",participante.Id_Rol),
                    new SqlParameter("id_Regalo",participante.Id_Regalo),
                    new SqlParameter("id_Evento",participante.Id_Evento)
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

        public static List<Participante> ObtenerTodos()
        {
            List<Participante> lista = new List<Participante>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Participante_SelectAll", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Participante participante = new Participante();
                    participante.id = Convert.ToInt32(reader["id"]);
                    participante.Correo = reader["correo"].ToString();
                    participante.Nombre = reader["Nombre"].ToString();
                    participante.Genero = Convert.ToChar(reader["genero"]);
                    participante.Telefono = Convert.ToInt32(reader["telefono"]);
                    //participante.Foto = Convert.ToSByte(reader["foto"].ToString());
                    participante.Registrado = Convert.ToBoolean(reader["registrado"]);
                    participante.Id_Rol = Convert.ToInt32(reader["id_Rol"]);
                    participante.Id_Regalo = Convert.ToInt32(reader["id_Regalo"]);
                    participante.Id_Evento = Convert.ToInt32(reader["id_Evento"]);

                    foreach (Regalo regalo in Regalo_Datos.Obtener_Regalos_PorParticipante(participante.id))
                    {
                        if (regalo.Deseado == true)
                        {
                            participante.regalos_Deseados = Regalo_Datos.Obtener_Regalos_PorParticipante(participante.id);
                        }
                        else
                        {
                            participante.regalos_No_Deseados = Regalo_Datos.Obtener_Regalos_PorParticipante(participante.id);
                        }
                    }

                    lista.Add(participante);
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

                SqlCommand command = new SqlCommand("SP_Participante_DeleteRow", servidor.Conectar());
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

        public static Participante ObtenerPorId(int id)
        {
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Participante_SelectRow", oservidor.Conectar());
                command.Parameters.AddWithValue("@Id", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Participante participante = new Participante();
                    participante.id = Convert.ToInt32(reader["id"]);
                    participante.Correo = reader["correo"].ToString();
                    participante.Nombre = reader["Nombre"].ToString();
                    participante.Genero = Convert.ToChar(reader["genero"]);
                    participante.Telefono = Convert.ToInt32(reader["telefono"]);
                    //participante.Foto = Convert.ToSByte(reader["foto"].ToString());
                    participante.Registrado = Convert.ToBoolean(reader["registrado"]);
                    participante.Id_Rol = Convert.ToInt32(reader["id_Rol"]);
                    participante.Id_Regalo = Convert.ToInt32(reader["id_Regalo"]);
                    participante.Id_Evento = Convert.ToInt32(reader["id_Evento"]);

                    foreach (Regalo item in Regalo_Datos.ObtenerTodos())
                    {
                        if (item.Deseado == true)
                        {
                            participante.regalos_Deseados = Regalo_Datos.Obtener_Regalos_PorParticipante(participante.id);
                        }
                        else
                        {
                            participante.regalos_No_Deseados = Regalo_Datos.Obtener_Regalos_PorParticipante(participante.id);
                        }
                    }


                    return participante;
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

        public static List<Participante> ObtenerPaticipantes_PorEvento(int id)
        {
            List<Participante> lista = new List<Participante>();
            Servidor oservidor = new Servidor();

            try
            {

                SqlCommand command = new SqlCommand("SP_Participante_Select_PorEvento", oservidor.Conectar());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Participante participante = new Participante();

                    participante.id = Convert.ToInt32(reader["id"]);
                    participante.Correo = reader["correo"].ToString();
                    participante.Nombre = reader["Nombre"].ToString();
                    participante.Genero = Convert.ToChar(reader["genero"]);
                    participante.Telefono = Convert.ToInt32(reader["telefono"]);
                    //participante.Foto = Convert.ToSByte(reader["foto"].ToString());
                    participante.Registrado = Convert.ToBoolean(reader["registrado"]);
                    participante.Id_Rol = Convert.ToInt32(reader["id_Rol"]);
                    participante.Id_Regalo = Convert.ToInt32(reader["id_Regalo"]);
                    participante.Id_Evento = Convert.ToInt32(reader["id_Evento"]);

                    lista.Add(participante);
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



    }
}