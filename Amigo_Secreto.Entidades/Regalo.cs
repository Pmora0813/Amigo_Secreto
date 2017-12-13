using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Entidades
{
    public class Regalo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantida { get; set; }
        public bool Deseado { get; set; }
        public string Descripcion { get; set; }      
        public string Enlace { get; set; }
        public int Id_Participante { get; set; }

    }
}
