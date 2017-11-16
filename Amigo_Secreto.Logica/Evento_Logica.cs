using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    public class Evento_Logica
    {

        public void Guardar(Evento evento)
        {
            if (evento == null)
                throw new ArgumentException("No se a creado Un Evento");
            if (evento.Id <= 0)
                throw new ArgumentException("El ID tiene que ser mayor a Cero");
            if (evento.Nombre.Length == 0)
                throw new ArgumentException("Ingrese el Nombre");
            if (evento.F_Limite.Date == null)
                throw new ArgumentException("Ingrese la fecha limite para Registrarse en el Evento");
            if (evento.F_Entrega.Date == null)
                throw new ArgumentException("Ingrese la Fecha para la entrega del Regalo");
            if (evento.Cupo == 0)
                throw new ArgumentException("Ingrese la cantidad de Participantes");
            if (evento.Localizacion.Length == 0)
                throw new ArgumentException("Ingrese el Lugar donde se realizara el Evento");
            if (evento.P_Minimo_Regalo == 0)
                throw new ArgumentException("Ingrese el costo Minimo para el Regalo");
            if (evento.P_Maximo_Regalo == 0)
                throw new ArgumentException("Ingrese el costo Maximo para el Regalo");

            Evento_Datos datos = new Evento_Datos();

            datos.Crear_Evento(evento);


        }


        

    }
}
