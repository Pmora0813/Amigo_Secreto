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


        public void Enviar_Invitaciones(int idEvento)
        {


            Evento evento = Evento_Datos.ObtenerPorId(idEvento);
            ////La cadena "servidor" es el servidor de correo que enviará tu mensaje

            // Creando objeto MailMessage

            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("pablomora25@gmail.com"));

            foreach (Lista_Invitados correos1 in ListaInv_Datos.obtenerTodos())
            {
                email.From = new MailAddress(correos1.Correo);
                email.Subject = "Asunto ( Invitacion " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
                email.Body = "Registrarte al Evento y comparte con tus amigos";
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 2525;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pablomora25@gmail.com", "**********");

                string output = null;


                try
                {
                    smtp.Send(email);
                    email.Dispose();
                    output = "Corre electrónico fue enviado satisfactoriamente.";
                }
                catch (Exception ex)
                {
                    output = "Error enviando correo electrónico: " + ex.Message;
                }

                Console.WriteLine(output);
            }


        }

    
}
}
