﻿namespace Amigo_Secreto
{
    partial class frmRegisto_Participantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEnlace = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtadjuntos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.npdCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombre_Regalo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pctCamara = new System.Windows.Forms.PictureBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cmbevento = new System.Windows.Forms.ComboBox();
            this.sPEventoSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigo_SecretoDataSet = new Amigo_Secreto.Amigo_SecretoDataSet();
            this.mskTelefo = new System.Windows.Forms.MaskedTextBox();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_Evento_SelectAllTableAdapter = new Amigo_Secreto.Amigo_SecretoDataSetTableAdapters.SP_Evento_SelectAllTableAdapter();
            this.dtgRegalos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deasado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPEventoSelectAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigo_SecretoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegalos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pctCamara);
            this.groupBox1.Controls.Add(this.lblCamera);
            this.groupBox1.Controls.Add(this.cmbCamara);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cmbevento);
            this.groupBox1.Controls.Add(this.mskTelefo);
            this.groupBox1.Controls.Add(this.rbnFemenino);
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1057, 837);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgRegalos);
            this.groupBox2.Controls.Add(this.txtEnlace);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtadjuntos);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.npdCantidad);
            this.groupBox2.Controls.Add(this.txtNombre_Regalo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(506, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 640);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Regalos";
            // 
            // txtEnlace
            // 
            this.txtEnlace.Location = new System.Drawing.Point(355, 193);
            this.txtEnlace.Name = "txtEnlace";
            this.txtEnlace.Size = new System.Drawing.Size(183, 30);
            this.txtEnlace.TabIndex = 15;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(355, 264);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(148, 71);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar Regalo";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(156, 250);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 33);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtadjuntos
            // 
            this.txtadjuntos.Location = new System.Drawing.Point(109, 212);
            this.txtadjuntos.Name = "txtadjuntos";
            this.txtadjuntos.Size = new System.Drawing.Size(165, 30);
            this.txtadjuntos.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Enlace";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Imagen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnNo);
            this.groupBox3.Controls.Add(this.rbtnSi);
            this.groupBox3.Location = new System.Drawing.Point(18, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 79);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desea el Regalo";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(91, 38);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(60, 29);
            this.rbtnNo.TabIndex = 5;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(12, 38);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(53, 29);
            this.rbtnSi.TabIndex = 4;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(303, 75);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 78);
            this.txtDescripcion.TabIndex = 6;
            // 
            // npdCantidad
            // 
            this.npdCantidad.Location = new System.Drawing.Point(122, 80);
            this.npdCantidad.Name = "npdCantidad";
            this.npdCantidad.Size = new System.Drawing.Size(63, 30);
            this.npdCantidad.TabIndex = 3;
            this.npdCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre_Regalo
            // 
            this.txtNombre_Regalo.Location = new System.Drawing.Point(124, 40);
            this.txtNombre_Regalo.Name = "txtNombre_Regalo";
            this.txtNombre_Regalo.Size = new System.Drawing.Size(150, 30);
            this.txtNombre_Regalo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // pctCamara
            // 
            this.pctCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctCamara.Location = new System.Drawing.Point(45, 426);
            this.pctCamara.Margin = new System.Windows.Forms.Padding(4);
            this.pctCamara.Name = "pctCamara";
            this.pctCamara.Size = new System.Drawing.Size(393, 265);
            this.pctCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCamara.TabIndex = 42;
            this.pctCamara.TabStop = false;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(40, 357);
            this.lblCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(214, 25);
            this.lblCamera.TabIndex = 39;
            this.lblCamera.Text = "Seleccione Camera :";
            // 
            // cmbCamara
            // 
            this.cmbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(205, 385);
            this.cmbCamara.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(233, 33);
            this.cmbCamara.TabIndex = 40;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(307, 699);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 34);
            this.btnIniciar.TabIndex = 41;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cmbevento
            // 
            this.cmbevento.DataSource = this.sPEventoSelectAllBindingSource;
            this.cmbevento.DisplayMember = "nombre";
            this.cmbevento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbevento.FormattingEnabled = true;
            this.cmbevento.Location = new System.Drawing.Point(163, 47);
            this.cmbevento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbevento.Name = "cmbevento";
            this.cmbevento.Size = new System.Drawing.Size(269, 33);
            this.cmbevento.TabIndex = 13;
            // 
            // sPEventoSelectAllBindingSource
            // 
            this.sPEventoSelectAllBindingSource.DataMember = "SP_Evento_SelectAll";
            this.sPEventoSelectAllBindingSource.DataSource = this.amigo_SecretoDataSet;
            // 
            // amigo_SecretoDataSet
            // 
            this.amigo_SecretoDataSet.DataSetName = "Amigo_SecretoDataSet";
            this.amigo_SecretoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mskTelefo
            // 
            this.mskTelefo.Location = new System.Drawing.Point(163, 298);
            this.mskTelefo.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefo.Mask = "0000-00-00";
            this.mskTelefo.Name = "mskTelefo";
            this.mskTelefo.Size = new System.Drawing.Size(140, 30);
            this.mskTelefo.TabIndex = 12;
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Location = new System.Drawing.Point(168, 258);
            this.rbnFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(128, 29);
            this.rbnFemenino.TabIndex = 11;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "Femenino";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(168, 222);
            this.rbtnMasc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(131, 29);
            this.rbtnMasc.TabIndex = 10;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 159);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(163, 107);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(275, 30);
            this.txtCorreo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // sP_Evento_SelectAllTableAdapter
            // 
            this.sP_Evento_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // dtgRegalos
            // 
            this.dtgRegalos.AllowUserToAddRows = false;
            this.dtgRegalos.AllowUserToDeleteRows = false;
            this.dtgRegalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Deasado});
            this.dtgRegalos.Location = new System.Drawing.Point(24, 373);
            this.dtgRegalos.Name = "dtgRegalos";
            this.dtgRegalos.ReadOnly = true;
            this.dtgRegalos.RowTemplate.Height = 24;
            this.dtgRegalos.Size = new System.Drawing.Size(495, 239);
            this.dtgRegalos.TabIndex = 16;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Deasado
            // 
            this.Deasado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deasado.HeaderText = "Deasado";
            this.Deasado.Name = "Deasado";
            this.Deasado.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(498, 744);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(176, 59);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegisto_Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 875);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegisto_Participantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Participantes";
            this.Load += new System.EventHandler(this.frmMenu_Participantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPEventoSelectAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigo_SecretoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegalos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbevento;
        private System.Windows.Forms.MaskedTextBox mskTelefo;
        private System.Windows.Forms.RadioButton rbnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Amigo_SecretoDataSet amigo_SecretoDataSet;
        private System.Windows.Forms.BindingSource sPEventoSelectAllBindingSource;
        private Amigo_SecretoDataSetTableAdapters.SP_Evento_SelectAllTableAdapter sP_Evento_SelectAllTableAdapter;
        private System.Windows.Forms.PictureBox pctCamara;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown npdCantidad;
        private System.Windows.Forms.TextBox txtNombre_Regalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtadjuntos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtEnlace;
        private System.Windows.Forms.DataGridView dtgRegalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deasado;
        private System.Windows.Forms.Button btnRegistrar;
    }
}