using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    public class Participante_Logica
    {
        private Participante_Datos paticipante;

        public void Guardar(Participante participante)
        {
            if (participante == null)
                throw new ArgumentException("No se a creado Un Participante");
            if (participante.id <= -1)
                throw new ArgumentException("El ID tiene que ser mayor a Cero");
            if (participante.Nombre.Equals(" "))
                throw new ArgumentException("Ingrese el Nombre");
            if (participante.Telefono <= 0)
                throw new ArgumentException("El telefono no puede ser Cero");


            paticipante = new Participante_Datos();

            paticipante.Guardar(participante);


        }

        public void Eliminar(int id)
        {
            paticipante.Eliminar(id);
        }

        public void Actualizar(Participante participante)
        {
            paticipante.Actualizar(participante);
        }

        public static List<Participante> ObtenerTodos()
        {
            return Participante_Datos.ObtenerTodos();
        }

        public static Participante ObtenerPorId(int id)
        {
            return Participante_Datos.ObtenerPorId(id);
        }

        public int ultimo()
        {
            return Participante_Datos.ObtenerUltimo();
        }

        

    }
}