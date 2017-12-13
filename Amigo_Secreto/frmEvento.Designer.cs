namespace Amigo_Secreto
{
    partial class frmEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCrear_Grupos = new System.Windows.Forms.Button();
            this.rbtNo_Crear_Grupo = new System.Windows.Forms.RadioButton();
            this.rbtCrear_Grupo = new System.Windows.Forms.RadioButton();
            this.dtpFecha_Lim_Inscrip = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Evento = new System.Windows.Forms.DateTimePicker();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.npdCan_Invitados = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.npdCodigo = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtDesactivar_Evento = new System.Windows.Forms.RadioButton();
            this.rbtActivar_Evento = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbPrecio_Maximo = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrecio_Minimo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrear_Evento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInvitaciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCan_Invitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "i_1.png");
            this.imageList1.Images.SetKeyName(1, "i_2.png");
            this.imageList1.Images.SetKeyName(2, "i_3.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Codigo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de invitados :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dtpFecha_Lim_Inscrip);
            this.groupBox1.Controls.Add(this.dtpFecha_Evento);
            this.groupBox1.Controls.Add(this.txtLugar);
            this.groupBox1.Controls.Add(this.npdCan_Invitados);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.npdCodigo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evento";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.btnCrear_Grupos);
            this.groupBox4.Controls.Add(this.rbtNo_Crear_Grupo);
            this.groupBox4.Controls.Add(this.rbtCrear_Grupo);
            this.groupBox4.Location = new System.Drawing.Point(324, 234);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(251, 90);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Crear Grupos";
            // 
            // btnCrear_Grupos
            // 
            this.btnCrear_Grupos.Enabled = false;
            this.btnCrear_Grupos.Location = new System.Drawing.Point(149, 36);
            this.btnCrear_Grupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear_Grupos.Name = "btnCrear_Grupos";
            this.btnCrear_Grupos.Size = new System.Drawing.Size(85, 34);
            this.btnCrear_Grupos.TabIndex = 13;
            this.btnCrear_Grupos.Text = "Crear";
            this.btnCrear_Grupos.UseVisualStyleBackColor = true;
            // 
            // rbtNo_Crear_Grupo
            // 
            this.rbtNo_Crear_Grupo.AutoSize = true;
            this.rbtNo_Crear_Grupo.Location = new System.Drawing.Point(36, 58);
            this.rbtNo_Crear_Grupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtNo_Crear_Grupo.Name = "rbtNo_Crear_Grupo";
            this.rbtNo_Crear_Grupo.Size = new System.Drawing.Size(52, 24);
            this.rbtNo_Crear_Grupo.TabIndex = 12;
            this.rbtNo_Crear_Grupo.TabStop = true;
            this.rbtNo_Crear_Grupo.Tag = "12";
            this.rbtNo_Crear_Grupo.Text = "No";
            this.rbtNo_Crear_Grupo.UseVisualStyleBackColor = true;
            this.rbtNo_Crear_Grupo.CheckedChanged += new System.EventHandler(this.rbtNo_Crear_Grupo_CheckedChanged);
            // 
            // rbtCrear_Grupo
            // 
            this.rbtCrear_Grupo.AutoSize = true;
            this.rbtCrear_Grupo.Location = new System.Drawing.Point(36, 28);
            this.rbtCrear_Grupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtCrear_Grupo.Name = "rbtCrear_Grupo";
            this.rbtCrear_Grupo.Size = new System.Drawing.Size(45, 24);
            this.rbtCrear_Grupo.TabIndex = 11;
            this.rbtCrear_Grupo.TabStop = true;
            this.rbtCrear_Grupo.Tag = "11";
            this.rbtCrear_Grupo.Text = "Si";
            this.rbtCrear_Grupo.UseVisualStyleBackColor = true;
            this.rbtCrear_Grupo.CheckedChanged += new System.EventHandler(this.rbtCrear_Grupo_CheckedChanged);
            // 
            // dtpFecha_Lim_Inscrip
            // 
            this.dtpFecha_Lim_Inscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Lim_Inscrip.Location = new System.Drawing.Point(108, 258);
            this.dtpFecha_Lim_Inscrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha_Lim_Inscrip.Name = "dtpFecha_Lim_Inscrip";
            this.dtpFecha_Lim_Inscrip.Size = new System.Drawing.Size(157, 26);
            this.dtpFecha_Lim_Inscrip.TabIndex = 7;
            this.dtpFecha_Lim_Inscrip.Tag = "6";
            // 
            // dtpFecha_Evento
            // 
            this.dtpFecha_Evento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Evento.Location = new System.Drawing.Point(107, 193);
            this.dtpFecha_Evento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha_Evento.Name = "dtpFecha_Evento";
            this.dtpFecha_Evento.Size = new System.Drawing.Size(157, 26);
            this.dtpFecha_Evento.TabIndex = 6;
            this.dtpFecha_Evento.Tag = "5";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(109, 128);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(157, 26);
            this.txtLugar.TabIndex = 4;
            this.txtLugar.Tag = "4";
            // 
            // npdCan_Invitados
            // 
            this.npdCan_Invitados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCan_Invitados.Location = new System.Drawing.Point(215, 94);
            this.npdCan_Invitados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdCan_Invitados.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdCan_Invitados.Name = "npdCan_Invitados";
            this.npdCan_Invitados.Size = new System.Drawing.Size(51, 26);
            this.npdCan_Invitados.TabIndex = 3;
            this.npdCan_Invitados.Tag = "3";
            this.npdCan_Invitados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "2";
            // 
            // npdCodigo
            // 
            this.npdCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCodigo.Location = new System.Drawing.Point(97, 20);
            this.npdCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npdCodigo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdCodigo.Name = "npdCodigo";
            this.npdCodigo.Size = new System.Drawing.Size(51, 26);
            this.npdCodigo.TabIndex = 1;
            this.npdCodigo.Tag = "1";
            this.npdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.rbtDesactivar_Evento);
            this.groupBox3.Controls.Add(this.rbtActivar_Evento);
            this.groupBox3.Location = new System.Drawing.Point(324, 130);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(251, 90);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activar Evento";
            // 
            // rbtDesactivar_Evento
            // 
            this.rbtDesactivar_Evento.AutoSize = true;
            this.rbtDesactivar_Evento.Location = new System.Drawing.Point(36, 58);
            this.rbtDesactivar_Evento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtDesactivar_Evento.Name = "rbtDesactivar_Evento";
            this.rbtDesactivar_Evento.Size = new System.Drawing.Size(52, 24);
            this.rbtDesactivar_Evento.TabIndex = 11;
            this.rbtDesactivar_Evento.TabStop = true;
            this.rbtDesactivar_Evento.Tag = "10";
            this.rbtDesactivar_Evento.Text = "No";
            this.rbtDesactivar_Evento.UseVisualStyleBackColor = true;
            // 
            // rbtActivar_Evento
            // 
            this.rbtActivar_Evento.AutoSize = true;
            this.rbtActivar_Evento.Location = new System.Drawing.Point(36, 28);
            this.rbtActivar_Evento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtActivar_Evento.Name = "rbtActivar_Evento";
            this.rbtActivar_Evento.Size = new System.Drawing.Size(45, 24);
            this.rbtActivar_Evento.TabIndex = 10;
            this.rbtActivar_Evento.TabStop = true;
            this.rbtActivar_Evento.Tag = "9";
            this.rbtActivar_Evento.Text = "Si";
            this.rbtActivar_Evento.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbPrecio_Maximo);
            this.groupBox2.Controls.Add(this.mtbPrecio_Minimo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(324, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(324, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precios para el Regalo";
            // 
            // mtbPrecio_Maximo
            // 
            this.mtbPrecio_Maximo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecio_Maximo.Location = new System.Drawing.Point(185, 60);
            this.mtbPrecio_Maximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbPrecio_Maximo.Mask = "0000000000";
            this.mtbPrecio_Maximo.Name = "mtbPrecio_Maximo";
            this.mtbPrecio_Maximo.Size = new System.Drawing.Size(111, 26);
            this.mtbPrecio_Maximo.TabIndex = 9;
            this.mtbPrecio_Maximo.Tag = "8";
            // 
            // mtbPrecio_Minimo
            // 
            this.mtbPrecio_Minimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecio_Minimo.Location = new System.Drawing.Point(185, 26);
            this.mtbPrecio_Minimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbPrecio_Minimo.Mask = "0000000000";
            this.mtbPrecio_Minimo.Name = "mtbPrecio_Minimo";
            this.mtbPrecio_Minimo.Size = new System.Drawing.Size(111, 26);
            this.mtbPrecio_Minimo.TabIndex = 8;
            this.mtbPrecio_Minimo.Tag = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio minimo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio Maximo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Realización :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lugar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha limite de inscripciones :";
            // 
            // btnCrear_Evento
            // 
            this.btnCrear_Evento.Location = new System.Drawing.Point(44, 386);
            this.btnCrear_Evento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear_Evento.Name = "btnCrear_Evento";
            this.btnCrear_Evento.Size = new System.Drawing.Size(179, 39);
            this.btnCrear_Evento.TabIndex = 1;
            this.btnCrear_Evento.Text = "Crear Evento";
            this.btnCrear_Evento.UseVisualStyleBackColor = true;
            this.btnCrear_Evento.Click += new System.EventHandler(this.btnCrear_Evento_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 461);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInvitaciones
            // 
            this.btnInvitaciones.Location = new System.Drawing.Point(255, 388);
            this.btnInvitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvitaciones.Name = "btnInvitaciones";
            this.btnInvitaciones.Size = new System.Drawing.Size(171, 38);
            this.btnInvitaciones.TabIndex = 3;
            this.btnInvitaciones.Text = "Selecionar Invitados";
            this.btnInvitaciones.UseVisualStyleBackColor = true;
            this.btnInvitaciones.Click += new System.EventHandler(this.btnInvitaciones_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar Invitaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(716, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInvitaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear_Evento);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de los Eventos";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCan_Invitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtDesactivar_Evento;
        private System.Windows.Forms.RadioButton rbtActivar_Evento;
        private System.Windows.Forms.DateTimePicker dtpFecha_Lim_Inscrip;
        private System.Windows.Forms.DateTimePicker dtpFecha_Evento;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.NumericUpDown npdCan_Invitados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown npdCodigo;
        private System.Windows.Forms.MaskedTextBox mtbPrecio_Maximo;
        private System.Windows.Forms.MaskedTextBox mtbPrecio_Minimo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtNo_Crear_Grupo;
        private System.Windows.Forms.RadioButton rbtCrear_Grupo;
        private System.Windows.Forms.Button btnCrear_Grupos;
        private System.Windows.Forms.Button btnCrear_Evento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInvitaciones;
        private System.Windows.Forms.Button button1;
    }
}