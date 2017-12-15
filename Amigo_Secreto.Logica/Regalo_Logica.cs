using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    public class Regalo_Logica
    {
        private Regalo_Datos datos;
        public void Guardar(Regalo regalo)
        {
            if (regalo == null)
                throw new ArgumentException("No se a creado Un Regalo");
            if (regalo.Id < 0)
                throw new ArgumentException("El ID tiene que ser mayor a Cero");
            if (regalo.Nombre.Equals(" "))
                throw new ArgumentException("Ingrese el Nombre");
            if (regalo.Cantida <= 0)
                throw new ArgumentException("La cantidad tiene que ser mayor que Cero");
            if (regalo.Descripcion.Equals(" "))
                throw new ArgumentException("Ingrese una descripción");


            datos = new Regalo_Datos();

            datos.Guardar(regalo);


        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }

        public void Actualizar(Regalo regalo)
        {
            datos.Actualizar(regalo);
        }

        public static List<Regalo> ObtenerTodos()
        {
            return Regalo_Datos.ObtenerTodos();
        }

        public static Regalo ObtenerPorId(int id)
        {
            return Regalo_Datos.ObtenerPorId(id);
        }

        public int ultimo()
        {
            return Regalo_Datos.ObtenerUltimo();
        }

        public static List<Regalo> ObtenerTodos_PorParticipante(int id)
        {
            return Regalo_Datos.Obtener_Regalos_PorParticipante(id);
        }
    }
}