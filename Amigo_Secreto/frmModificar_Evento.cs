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
    public partial class frmModificar_Evento : Form
    {
        public Evento evento;
        Logica.Evento_Logica logica;
        public frmModificar_Evento()
        {
            logica = new Logica.Evento_Logica();
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(npdCodigo.Value);
            evento = Evento_Logica.ObtenerPorId(id);
            if (evento == null)
            {
                MessageBox.Show("No se encontro un Evento con el codigo: " + id);
                return;
            }
            txtNombre.Text = evento.Nombre;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

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

            try
            {
                logica.Actualizar(evento);

                MessageBox.Show("Se actualizo un evento con exito...!!");
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
            rbtDesactivar_Evento.Checked = false;

        }

    }

}
