using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Entidades
{
    public class Participante
    {
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public char Genero { get; set; }
        public int Telefono { get; set; }
        public Image Foto { get; set; }
        public bool Registrado { get; set; }
        public int I { get; set; }

    }
}
