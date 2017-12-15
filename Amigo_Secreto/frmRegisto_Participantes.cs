using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AForge.Video;
//using AForge.Video.DirectShow;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using AForge.Video.DirectShow;
using AForge.Video;
using Amigo_Secreto.Logica;
using Amigo_Secreto.Entidades;


namespace Amigo_Secreto
{
    public partial class frmRegisto_Participantes : Form
    {
        public Participante_Logica logica_Parti;
        public Regalo_Logica logica_Regalo;
        public Rol_Logica logica_Roles;
        public Participante participante;
        public Regalo regalo;
        //CODIGO PARA VER WEBCAM
        private bool ExisteDispositivo = false;
        public FilterInfoCollection camara;
        private VideoCaptureDevice FuenteDeVideo = null;

        public frmRegisto_Participantes()
        {
            InitializeComponent();
            BuscarDispositivos();
            logica_Parti = new Participante_Logica();
            logica_Regalo = new Regalo_Logica();
        }

        private void frmMenu_Participantes_Load(object sender, EventArgs e)
        {

            refresecar_Eventos();
           
        }

        private void refresecar_Eventos()
        {
            foreach (Evento evento in Evento_Logica.ObtenerTodos())
            {
                cmbevento.Items.Add(evento);
            }
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cmbCamara.Items.Add(Dispositivos[0].Name.ToString());
            cmbCamara.Text = cmbCamara.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            camara = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (camara.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(camara);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctCamara.Image = Imagen;
        }

        //Boton para iniciar la captura
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")

            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(camara[cmbCamara.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Capturar";
                    cmbCamara.Enabled = false;
                }
                else
                {
                    pctCamara.Image = Amigo_Secreto.Properties.Resources.i_1;
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar";
                    cmbCamara.Enabled = true;
                }
            }
        }
        //Buscar una imagen para el regalo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog menu_abrir = new OpenFileDialog();
            menu_abrir.Filter = "Todos los archivos|*.*";
            menu_abrir.Title = "Abrir...";
            menu_abrir.InitialDirectory = @"C:\";
            if (menu_abrir.ShowDialog() == DialogResult.OK)
            {
                if (txtadjuntos.Text == "" || txtadjuntos.Text == null) txtadjuntos.Text = menu_abrir.FileName;
                else txtadjuntos.Text += @"|" + menu_abrir.FileName;
            }
        }

        //Guardar todos los regalos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                regalo = new Regalo();
                regalo.Id = logica_Regalo.ultimo();
                regalo.Nombre = txtNombre_Regalo.Text;
                regalo.Cantida = Convert.ToInt32(npdCantidad.Value);

                if (rbtnSi.Checked)
                {
                    regalo.Deseado = true;
                }
                else
                {
                    if (rbtnNo.Checked)
                    {
                        regalo.Deseado = false;
                    }
                }
                regalo.Descripcion = txtDescripcion.Text;
                regalo.Enlace = txtEnlace.Text;
                regalo.Id_Participante = 1;

                logica_Regalo.Guardar(regalo);
            }
            catch
            {

                throw;
            }
            Refrescar(1);
        }

        //Obtener todos los regalos 
        private void Refrescar(int id)
        {
            dtgRegalos.DataSource=Regalo_Logica.ObtenerTodos_PorParticipante(id);
        }
        //Boton para guardar el participante
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Participante participante = new Participante();
                participante.id = logica_Parti.ultimo();
                participante.Correo = txtCorreo.Text;
                participante.Nombre = txtNombre.Text;

                if (rbtnMasc.Checked)
                {
                    participante.Genero = 'M';
                }
                else
                {
                    if (rbnFemenino.Checked)
                    {
                        participante.Genero = 'F';
                    }
                }

                participante.Telefono = Convert.ToInt32(mskTelefo.Text);
                conv_photo();
                participante.Foto = pctCamara.Image;
                Evento evento = (Evento)cmbevento.SelectedItem;

                //int Id = (int)cmbevento.SelectedIndex;
                participante.Id_Evento = evento.Id;
                participante.Id_Rol = 3;
                
                             
                logica_Parti.Guardar(participante);


            }
            catch
            {

                throw;
            }
        }

        public void conv_photo()
        {
            //SqlCommand cmd;
            if (pctCamara.Image != null)
            {
                
                MemoryStream ms = new MemoryStream();
                pctCamara.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                //cmd.Parameters.AddWithValue("@foto", photo_aray);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgRegalos.SelectedCells[0].Value);

            logica_Regalo.Eliminar(id);
        }
    }
}
