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

        char[] delimitador_cc = { ',' };
        char[] delimitador_adjunto = { '|' };
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

        
        public void enviar_correo()
        {
            string host = "smtp-mail.outlook.com";
            int puerto = 587;
            string remitente = "pmora0813@hotmail.com";
            string contraseña = "Pablomora0813";
            string nombre = "Pablo";
            foreach (Lista_Invitados invitados in Logica.ListaInv_Logica.ObtenerTodos())
            {
                string destinatarios = invitados.Correo;
                string cc = "";
                string asunto = "Invitacion al Evento";
                string adjuntos= "";
                string cuerpo = "Registrate en el evento y comparte con tus Amigos";
                try
                {
                    SmtpClient cliente = new SmtpClient(host, puerto);
                    MailMessage correo = new MailMessage();

                    correo.From = new MailAddress(remitente, nombre);
                    correo.Body = cuerpo;
                    correo.Subject = asunto;
                    if (destinatarios == "") { }
                    else
                    {
                        string[] cadena = destinatarios.Split();
                        foreach (string word in cadena)
                            correo.To.Add(word.Trim());
                    }
                    if (cc == "") { }
                    else
                    {
                        string[] cadena1 = cc.Split();
                        foreach (string word in cadena1) correo.CC.Add(word.Trim());
                    }
                    if (adjuntos == "") { }
                    else
                    {
                        string[] cadena2 = adjuntos.Split();
                        foreach (string word in cadena2) correo.Attachments.Add(new Attachment(word));
                    }
                    cliente.Credentials = new NetworkCredential(remitente, contraseña);
                    cliente.EnableSsl = true;
                    cliente.Send(correo);
                    
                }
                catch 
                {
                    throw;
                }
            }

        }
    }
}
