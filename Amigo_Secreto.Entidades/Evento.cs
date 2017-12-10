using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime F_Limite { get; set; }
        public DateTime F_Entrega { get; set; }
        public int Cupo { get; set; }
        public string Localizacion { get; set; }
        public bool Activo { get; set; }
        public decimal P_Minimo_Regalo { get; set; }
        public decimal P_Maximo_Regalo { get; set; }
        public bool Grupo { get; set; }

        public List<Lista_Invitados> lista_invitados { get; set; }

        public List<Grupos> grupos { get; set; }

        public override string ToString()
        {
            return "Tienes una invitación al evento "+Nombre;
        }
    }
}
