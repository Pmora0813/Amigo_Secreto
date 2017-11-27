using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amigo_Secreto
{
    public partial class frmEnviar_Invitaciones : Form
    {

        public frmEnviar_Invitaciones()
        {
            InitializeComponent();
        }


        public static bool ComprobarFormatoEmail(string correo)
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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            int codigo = Convert.ToInt32(npdCodigo.Value);
            if (ComprobarFormatoEmail(correo) == false)
            {
                txtCorreo.Text = "Dirección no valida";
                txtCorreo.ForeColor = Color.Red;


            }
            else
            {
                txtCorreo.Text = "Dirección valida";
                txtCorreo.ForeColor = Color.Green;

                dgvInvitaciones.Rows[0].(correo);

            }
            tmr_txtCorreo.Start();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCorreo.Text = "";

            tmr_txtCorreo.Stop();
            txtCorreo.ForeColor = Color.Black;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ////La cadena "servidor" es el servidor de correo que enviará tu mensaje
            //string servidor = "smtp.gmail.com";
            //// Crea el mensaje estableciendo quién lo manda y quién lo recibe
            //MailMessage mensaje = new MailMessage(
            //   emisor.Text,
            //   receptor.Text,
            //   asunto.Text,
            //   mensajazo.Text);

            ////Envía el mensaje.
            //SmtpClient cliente = new SmtpClient(servidor);
            ////Añade credenciales si el servidor lo requiere.
            //cliente.Credentials = CredentialCache.DefaultNetworkCredentials;
            //cliente.Send(mensaje);




            for (int i = 1; i < dgvInvitaciones.SelectedRows.Count; i++)
            {

                var corr = (String)dgvInvitaciones.SelectedRows[i].DataBoundItem;
                MessageBox.Show(corr.ToString());
            }
        }
    }
}
