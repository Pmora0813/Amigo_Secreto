using Amigo_Secreto.Datos;
using Amigo_Secreto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Amigo_Secreto.Logica
{
    public class ListaInv_Logica
    {
        ListaInv_Datos datos;
        //Evento_Datos eDados;
        public void Guardar(Lista_Invitados l_Invidatos)
        {
            if (l_Invidatos == null)
                throw new ArgumentException("No se tiene Invidatos");
            if (l_Invidatos.Id < 0)
                throw new ArgumentException("El codigo No corresponde");

            datos = new ListaInv_Datos();

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

        public bool ComprobarFormatoEmail(string correo)
        {

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, sFormato))
            {
                if (Regex.Replace(correo, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int ultimo()
        {
            return ListaInv_Datos.ObtenerUltimo();
        }




        public void enviarInvitacion()
        {
            string micorreo = "pmora0813@hotmail.com";
            string pass = "Pablomora0813";
            string asunto = "Invitacion para el Amigo Secreto";
            string contenido = "Regitrate en el evento y Comparte con tus Amigos";

            using (SmtpClient client = new SmtpClient("smtp.live.com", 2525))
            {
                foreach (Lista_Invitados correos in ListaInv_Datos.obtenerTodos())
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(micorreo, pass);
                    MailMessage mensaje = new MailMessage(micorreo, correos.Correo, asunto, contenido);


                    try
                    {
                        client.Send(mensaje);

                    }
                    catch

                    {
                        throw;
                    }

                }
            }
        }


    }
}
