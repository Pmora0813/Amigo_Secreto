using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Datos
{
    public class Servidor
    {

        protected SqlConnection conn;
        protected string cadena;      

        public  SqlConnection Conectar()
        {
            cadena = System.Configuration.ConfigurationManager.ConnectionStrings["Amigo_Secreto.Properties.Settings.Conneccion"].ConnectionString;

            conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                return conn;
            }
            catch 
            {
                throw ;
            }
        }

        public void Desconectar()
        {
            conn.Close();            
        }
    }

}






