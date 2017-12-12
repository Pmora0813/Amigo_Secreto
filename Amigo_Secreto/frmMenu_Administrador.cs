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
    public partial class frmMenu_Administrador : Form
    {
        public frmMenu_Administrador()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void crearEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvento ofrm = new frmEvento();
            ofrm.Show();

        }

        private void modificarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar_Evento ofrm = new frmModificar_Evento();
            ofrm.Show();
        }

        private void consultarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar_Evento ofrm = new frmConsultar_Evento();
            ofrm.Show();
        }
    }
}
