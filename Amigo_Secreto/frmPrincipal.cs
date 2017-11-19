using Amigo_Secreto.Entidades;
using Amigo_Secreto.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amigo_Secreto
{
    public partial class frmPrincipal : Form
    {
        private Administrador_Logica logica_admin;

        public frmPrincipal()
        {
            InitializeComponent();
            logica_admin = new Administrador_Logica();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            Crear_Admin();

        }

        private void Crear_Admin()
        {


            Administrador admin = new Administrador();
            admin.Usuario = "pmora";
            admin.Contrasenna = "pmora";
            admin.creado = 1;
            logica_admin.Guardar(admin);



        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmEvento ofrmevento = new frmEvento();
            string usuario = txtusuario.Text;
            string contrasenna = txtContrasenna.Text;

            Administrador admin = new Administrador();
            admin.Usuario = usuario;
            admin.Contrasenna = contrasenna;
            admin.creado = 1;

            if (logica_admin.Validar(admin) == true)
            {
                MessageBox.Show("Usuario Valido");

                //ofrmevento.Show();
            }
            else
            {
                MessageBox.Show("Usuario Invalido");
                //ofrmevento.Dispose();
            }
        }
    }

}
