namespace Amigo_Secreto
{
    partial class frmModificar_Evento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCan_Invitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscar);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // dtpFecha_Lim_Inscrip
            // 
            this.dtpFecha_Lim_Inscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Lim_Inscrip.Location = new System.Drawing.Point(167, 284);
            this.dtpFecha_Lim_Inscrip.Name = "dtpFecha_Lim_Inscrip";
            this.dtpFecha_Lim_Inscrip.Size = new System.Drawing.Size(119, 26);
            this.dtpFecha_Lim_Inscrip.TabIndex = 121;
            this.dtpFecha_Lim_Inscrip.Tag = "6";
            // 
            // dtpFecha_Evento
            // 
            this.dtpFecha_Evento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Evento.Location = new System.Drawing.Point(167, 231);
            this.dtpFecha_Evento.Name = "dtpFecha_Evento";
            this.dtpFecha_Evento.Size = new System.Drawing.Size(119, 26);
            this.dtpFecha_Evento.TabIndex = 120;
            this.dtpFecha_Evento.Tag = "5";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(167, 160);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(119, 26);
            this.txtLugar.TabIndex = 118;
            this.txtLugar.Tag = "4";
            // 
            // npdCan_Invitados
            // 
            this.npdCan_Invitados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCan_Invitados.Location = new System.Drawing.Point(248, 121);
            this.npdCan_Invitados.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdCan_Invitados.Name = "npdCan_Invitados";
            this.npdCan_Invitados.Size = new System.Drawing.Size(38, 22);
            this.npdCan_Invitados.TabIndex = 116;
            this.npdCan_Invitados.Tag = "3";
            this.npdCan_Invitados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(167, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 26);
            this.txtNombre.TabIndex = 114;
            this.txtNombre.Tag = "2";
            // 
            // npdCodigo
            // 
            this.npdCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCodigo.Location = new System.Drawing.Point(136, 20);
            this.npdCodigo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdCodigo.Name = "npdCodigo";
            this.npdCodigo.Size = new System.Drawing.Size(38, 22);
            this.npdCodigo.TabIndex = 112;
            this.npdCodigo.Tag = "1";
            this.npdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.rbtDesactivar_Evento);
            this.groupBox3.Controls.Add(this.rbtActivar_Evento);
            this.groupBox3.Location = new System.Drawing.Point(327, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 73);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activar Evento";
            // 
            // rbtDesactivar_Evento
            // 
            this.rbtDesactivar_Evento.AutoSize = true;
            this.rbtDesactivar_Evento.Location = new System.Drawing.Point(27, 47);
            this.rbtDesactivar_Evento.Name = "rbtDesactivar_Evento";
            this.rbtDesactivar_Evento.Size = new System.Drawing.Size(49, 24);
            this.rbtDesactivar_Evento.TabIndex = 11;
            this.rbtDesactivar_Evento.TabStop = true;
            this.rbtDesactivar_Evento.Tag = "10";
            this.rbtDesactivar_Evento.Text = "No";
            this.rbtDesactivar_Evento.UseVisualStyleBackColor = true;
            // 
            // rbtActivar_Evento
            // 
            this.rbtActivar_Evento.AutoSize = true;
            this.rbtActivar_Evento.Location = new System.Drawing.Point(27, 23);
            this.rbtActivar_Evento.Name = "rbtActivar_Evento";
            this.rbtActivar_Evento.Size = new System.Drawing.Size(43, 24);
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
            this.groupBox2.Location = new System.Drawing.Point(327, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 80);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precios para el Regalo";
            // 
            // mtbPrecio_Maximo
            // 
            this.mtbPrecio_Maximo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecio_Maximo.Location = new System.Drawing.Point(159, 49);
            this.mtbPrecio_Maximo.Mask = "0000000000";
            this.mtbPrecio_Maximo.Name = "mtbPrecio_Maximo";
            this.mtbPrecio_Maximo.Size = new System.Drawing.Size(84, 22);
            this.mtbPrecio_Maximo.TabIndex = 9;
            this.mtbPrecio_Maximo.Tag = "8";
            // 
            // mtbPrecio_Minimo
            // 
            this.mtbPrecio_Minimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecio_Minimo.Location = new System.Drawing.Point(159, 21);
            this.mtbPrecio_Minimo.Mask = "0000000000";
            this.mtbPrecio_Minimo.Name = "mtbPrecio_Minimo";
            this.mtbPrecio_Minimo.Size = new System.Drawing.Size(84, 22);
            this.mtbPrecio_Minimo.TabIndex = 8;
            this.mtbPrecio_Minimo.Tag = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio minimo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio Maximo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 122;
            this.label6.Text = "Fecha de Realización :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Lugar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Fecha limite de inscripciones :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 113;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Cantidad de invitados :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 126;
            this.label1.Text = "Codigo :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(207, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 26);
            this.btnBuscar.TabIndex = 127;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(172, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 128;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(327, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 37);
            this.btnSalir.TabIndex = 129;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmModificar_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 429);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModificar_Evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Evento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCan_Invitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha_Lim_Inscrip;
        private System.Windows.Forms.DateTimePicker dtpFecha_Evento;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.NumericUpDown npdCan_Invitados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown npdCodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtDesactivar_Evento;
        private System.Windows.Forms.RadioButton rbtActivar_Evento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbPrecio_Maximo;
        private System.Windows.Forms.MaskedTextBox mtbPrecio_Minimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
    }
}