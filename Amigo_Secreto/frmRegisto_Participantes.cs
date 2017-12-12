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
    public partial class frmRegisto_Participantes : Form
    {
        public frmRegisto_Participantes()
        {
            InitializeComponent();
        }

        private void frmMenu_Participantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'amigo_SecretoDataSet.SP_Evento_SelectAll' Puede moverla o quitarla según sea necesario.
            this.sP_Evento_SelectAllTableAdapter.Fill(this.amigo_SecretoDataSet.SP_Evento_SelectAll);

        }
    }
}
