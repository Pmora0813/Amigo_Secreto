using Amigo_Secreto.Entidades;
using Amigo_Secreto.Logica;
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
        private ListaInv_Logica logica;

        public int evento { get; set; }

        public frmEnviar_Invitaciones()
        {
            logica = new ListaInv_Logica();
            InitializeComponent();
        }




        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            if (logica.ComprobarFormatoEmail(correo) == false)
            {
                txtCorreo.Text = "Dirección no valida";
                txtCorreo.ForeColor = Color.Red;


            }
            else
            {
                txtCorreo.Text = "Dirección valida";
                txtCorreo.ForeColor = Color.Green;
                Lista_Invitados invitados = new Lista_Invitados();

                invitados.Id = logica.ultimo();
                invitados.Correo = correo;
                logica.Guardar(invitados);



            }
            tmr_txtCorreo.Start();
            Refrescar();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCorreo.Text = "";

            tmr_txtCorreo.Stop();
            txtCorreo.ForeColor = Color.Black;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            logica.enviarInvitacion();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void Refrescar()
        {
            dgvInvitaciones.DataSource = ListaInv_Logica.ObtenerTodos();
        }

        private void frmEnviar_Invitaciones_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvitaciones.SelectedRows.Count > 0)
                {
                    Lista_Invitados invidato = (Lista_Invitados)dgvInvitaciones.SelectedRows[0].DataBoundItem;

                    var result = MessageBox.Show("Seguro?", "Elminar Invitación", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        logica.Eliminar(invidato.Id);

                        Refrescar();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
