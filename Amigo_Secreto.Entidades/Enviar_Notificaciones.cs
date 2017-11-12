using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Entidades
{
    public class Enviar_Notificaciones
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool General { get; set; }
        public string Id_Participante { get; set; }
    }
}
