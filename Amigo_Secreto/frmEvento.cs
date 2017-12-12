using Amigo_Secreto.Entidades;
using Amigo_Secreto.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amigo_Secreto
{
    public partial class frmEvento : Form
    {
        private Evento_Logica logica;
        private ListaInv_Logica list_Logica;
        private Evento evento;
        public frmEvento()
        {
            logica = new Evento_Logica();
            list_Logica = new ListaInv_Logica();

            InitializeComponent();
        }
        private void btnCrear_Evento_Click(object sender, EventArgs e)
        {
            evento = new Evento();
            evento.Id = (int)npdCodigo.Value;
            evento.Nombre = txtNombre.Text;
            evento.F_Entrega = dtpFecha_Evento.Value;
            evento.F_Limite = dtpFecha_Lim_Inscrip.Value;

            evento.Cupo = (int)npdCan_Invitados.Value;
            evento.Localizacion = txtLugar.Text;
            if (rbtActivar_Evento.Checked == true)
            {
                evento.Activo = true;
            }
            else
            {
                if (rbtDesactivar_Evento.Checked == false)
                {
                    evento.Activo = false;
                }
            }

            if (mtbPrecio_Maximo.Text.Equals(""))
                throw new ArgumentException("El Precio tiene que ser mayor a Cero");

            if (mtbPrecio_Minimo.Text.Equals(""))
                throw new ArgumentException("El Precio tiene que ser mayor a Cero");

            evento.P_Minimo_Regalo = Convert.ToInt32(mtbPrecio_Minimo.Text);

            evento.P_Maximo_Regalo = Convert.ToInt64(mtbPrecio_Maximo.Text);

            

            if (rbtCrear_Grupo.Checked == true)
            {
                evento.Grupo = true;
            }
            else
            {
                if (rbtNo_Crear_Grupo.Checked == false)
                {
                    evento.Grupo = false;
                }
            }
            try
            {
                logica.Guardar(evento);

                MessageBox.Show("Se creo un Evento con Exito...!!");
            }
            catch
            {

                throw;
            }

            limpiar_Componentes();

        }

        private void limpiar_Componentes()
        {
            npdCodigo.Value = 0;
            txtNombre.Text = "";
            npdCan_Invitados.Value = 0;
            txtLugar.Text = "";
            mtbPrecio_Maximo.Text = "";
            mtbPrecio_Minimo.Text = "";
            rbtActivar_Evento.Checked = false;
            rbtCrear_Grupo.Checked = false;
            rbtDesactivar_Evento.Checked = false;
            rbtNo_Crear_Grupo.Checked = false;

        }

        private void rbtCrear_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            btnCrear_Grupos.Enabled = true;
        }

        private void rbtNo_Crear_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            btnCrear_Grupos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnInvitaciones_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnviar_Invitaciones ofrm = new frmEnviar_Invitaciones();

                //if (evento == null)
                //throw new Exception("No se ha encontrado un Evento Relacionado");


                ofrm.Show();
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        private void frmEvento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_Logica.enviarInvitacion();
        }
    }
}

