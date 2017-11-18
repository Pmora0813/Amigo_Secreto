using Amigo_Secreto.Entidades;
using System;
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

                servidor.Desconectar();

            }
            catch
            {
                throw;
            }
        }

        public void Actialir(Evento evento)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_Evento_Insert", servidor.Conectar());

                SqlParameter[] parametros = new SqlParameter[]
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

                command.Parameters.AddRange(parametros);

                cargar = command.ExecuteReader();
            }
            catch
            {
                throw;
            }

        }
    }
}
