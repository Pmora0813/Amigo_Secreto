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

        private SqlConnection conn;
        private string cadena;

        public void Conectar()
        {
            cadena = System.Configuration.ConfigurationManager.ConnectionStrings["Amigo_Secreto.Properties.Settings.Conneccion"].ConnectionString;
            conn = new SqlConnection(cadena);

            try
            {
                conn.Open();

            }
            catch
            {
                throw;
            }

            finally
            {
                conn.Close();
            }
        }

    }
}





