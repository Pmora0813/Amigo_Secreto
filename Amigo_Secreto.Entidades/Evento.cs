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

        public List<Participante> Participante { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder evento = new StringBuilder();
        //    evento.Append("\nCodido: " + Id+"\n");
        //    evento.Append("\nNombre: " + Nombre);
        //    evento.Append("\nFecha limite de inscripciones: " + F_Limite);
        //    evento.Append("\nFecha de entrega del regalo: " + F_Entrega);
        //    evento.Append("\nCantidad de personas: " + Cupo);
        //    evento.Append("\nLugar de realización del evento: " + Localizacion);
        //    if (Activo == true)
        //    {
        //        evento.Append("\nEvento avtivo: si");
        //    }
        //    else
        //    {
        //        evento.Append("\nEvento avtivo: no");
        //    }
        //    evento.Append("\nPrecio minimo del regalo: " + P_Minimo_Regalo);
        //    evento.Append("\nPrecio maximo del regalo: " + P_Maximo_Regalo);

        //    if (Grupo == true)
        //    {
        //        evento.Append("\nSegrearon grupos: Si");
        //    }
        //    else
        //    {

        //        evento.Append("Segrearon grupos: No");
        //    }
        //        return evento.ToString();
        //    }

        //public override string ToString()
        //{
        //    return Nombre;
        //}
    }
    }
