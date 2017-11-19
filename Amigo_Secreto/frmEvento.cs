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
        public frmEvento()
        {
            logica = new Evento_Logica();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Id = 1;
            evento.Nombre = "Prueva";
            DateTime limite = new DateTime(2018, 3, 15);
            evento.F_Limite = limite;
            evento.F_Entrega = new DateTime(2020,3,20);
            evento.Cupo = 10;
            evento.Localizacion = "SJ-CR";
            evento.Activo = true;
            evento.P_Minimo_Regalo = 500;
            evento.P_Maximo_Regalo = 1000;

            Grupos grupos = new Grupos();
            grupos.Id = 1;
            try
            {
                logica.Guardar(evento);
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void rbtCrear_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            btnCrear_Grupos.Enabled = true;
        }

        private void rbtNo_Crear_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            btnCrear_Grupos.Enabled = false;
        }
    }
    }

