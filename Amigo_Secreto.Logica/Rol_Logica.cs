using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    
    public class Rol_Logica
    {
        public static Roles ObtenerPorId(int id)
        {
            return Roles_Datos.ObtenerPorId(id);
        }
    }
}
