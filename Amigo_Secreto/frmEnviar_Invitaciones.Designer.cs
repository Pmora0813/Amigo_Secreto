namespace Amigo_Secreto
{
    partial class frmEnviar_Invitaciones
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgvInvitaciones = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tmr_txtCorreo = new System.Windows.Forms.Timer(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.npdCodigo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(291, 37);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(86, 25);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(68, 35);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(205, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // dgvInvitaciones
            // 
            this.dgvInvitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Correo});
            this.dgvInvitaciones.Location = new System.Drawing.Point(16, 112);
            this.dgvInvitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInvitaciones.Name = "dgvInvitaciones";
            this.dgvInvitaciones.RowTemplate.Height = 24;
            this.dgvInvitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvitaciones.Size = new System.Drawing.Size(359, 126);
            this.dgvInvitaciones.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(68, 250);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(195, 27);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar ";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(291, 253);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 24);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tmr_txtCorreo
            // 
            this.tmr_txtCorreo.Interval = 2000;
            this.tmr_txtCorreo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // npdCodigo
            // 
            this.npdCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.npdCodigo.Location = new System.Drawing.Point(68, 70);
            this.npdCodigo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.npdCodigo.Name = "npdCodigo";
            this.npdCodigo.Size = new System.Drawing.Size(37, 20);
            this.npdCodigo.TabIndex = 7;
            this.npdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEnviar_Invitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 288);
            this.Controls.Add(this.npdCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dgvInvitaciones);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEnviar_Invitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Invitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvInvitaciones;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer tmr_txtCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown npdCodigo;
    }
}