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
    public partial class frmConsultar_Evento : Form
    {
        public frmConsultar_Evento()
        {
            InitializeComponent();
        }

        private void frmConsultar_Evento_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(mskCodigo.Text);

                Evento evento = Evento_Logica.ObtenerPorId(codigo);

                lstConsukltar.DisplayMember = "Nombre";
                lstConsukltar.DataSource = evento.ToString();
            }
            catch 
            {

                throw;
            }
            
        }
    }
}
