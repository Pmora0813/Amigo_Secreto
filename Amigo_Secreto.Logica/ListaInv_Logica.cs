using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    class ListaInv_Logica
    {

        public void Guardar(Lista_Invitados l_Invidatos)
        {
            if (l_Invidatos == null)
                throw new ArgumentException("No se tiene Invidatos");
            if (l_Invidatos.Id < 0)
                throw new ArgumentException("El codigo No corresponde");

            ListaInv_Datos datos = new ListaInv_Datos();

            datos.Guardar(l_Invidatos);
        }

        public void Eliminar(int id)
        {
            ListaInv_Datos datos = new ListaInv_Datos();
            datos.Eliminar(id);
        }
        public static List<Lista_Invitados> ObtenerTodos()
        {
            return ListaInv_Datos.obtenerTodos();
        }
        public static Lista_Invitados ObtenerPorId(int id)
        {
            return ListaInv_Datos.ObtenerPorId(id);
        }
    }
}
