using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Datos
{
    public class Evento_Datos
    {
        private Servidor servidor;
        

        public Evento_Datos()
        {
            servidor = new Servidor();
            
        }
        public void Crear_Evento(Evento evento)
        {
            try
            {


                //string sql = "SP_Evento_Insert";
                SqlCommand command = new SqlCommand("SP_Evento_Insert",servidor.Conectar());


                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", evento.Id);
                command.Parameters.AddWithValue("@nombre", evento.Nombre);
                command.Parameters.AddWithValue("@f_limite", evento.F_Limite);
                command.Parameters.AddWithValue("@f_entrega", evento.F_Entrega);
                command.Parameters.AddWithValue("@cupo", evento.Cupo);
                command.Parameters.AddWithValue("@localizacion", evento.Localizacion);
                command.Parameters.AddWithValue("@activo", evento.Activo);
                command.Parameters.AddWithValue("@p_minimo_regalo", evento.P_Minimo_Regalo);
                command.Parameters.AddWithValue("@p_maximo_regalo", evento.P_Maximo_Regalo);
                command.Parameters.AddWithValue("@grupo", evento.Grupo);



                command.BeginExecuteNonQuery();
                servidor.Desconectar();

            }
            catch
            {
                throw;
            }
        }
    }
}
