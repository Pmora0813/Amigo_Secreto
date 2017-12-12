﻿using Amigo_Secreto.Entidades;
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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal ofrmPrincipal = new frmPrincipal(); ;
            frmMenu_Administrador ofrm = new frmMenu_Administrador();
            string usuario = txtusuario.Text;
            string contrasenna = txtContrasenna.Text;

            //Administrador admin = new Administrador();
            //admin.Usuario = usuario;
            //admin.Contrasenna = contrasenna;
            //admin.creado = 1;

            //if (logica_admin.Validar(usuario, contrasenna))
            //{
            //    MessageBox.Show("Usuario Valido");

            //    ofrmevento.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario Invalido");
            //    ofrmevento.Dispose();
            //}


            ofrm.Show();
            txtContrasenna.Text = "";
            // Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegisto_Participantes ofrm = new frmRegisto_Participantes();
            ofrm.Show();
        }
    }

}
