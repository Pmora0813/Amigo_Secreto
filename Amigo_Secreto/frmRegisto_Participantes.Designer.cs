namespace Amigo_Secreto
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
            this.cmbevento = new System.Windows.Forms.ComboBox();
            this.sPEventoSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amigo_SecretoDataSet = new Amigo_Secreto.Amigo_SecretoDataSet();
            this.mskTelefo = new System.Windows.Forms.MaskedTextBox();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_Evento_SelectAllTableAdapter = new Amigo_Secreto.Amigo_SecretoDataSetTableAdapters.SP_Evento_SelectAllTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPEventoSelectAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigo_SecretoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbevento);
            this.groupBox1.Controls.Add(this.mskTelefo);
            this.groupBox1.Controls.Add(this.rbnFemenino);
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participante";
            // 
            // cmbevento
            // 
            this.cmbevento.DataSource = this.sPEventoSelectAllBindingSource;
            this.cmbevento.DisplayMember = "nombre";
            this.cmbevento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbevento.FormattingEnabled = true;
            this.cmbevento.Location = new System.Drawing.Point(122, 38);
            this.cmbevento.Name = "cmbevento";
            this.cmbevento.Size = new System.Drawing.Size(203, 28);
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
            this.mskTelefo.Location = new System.Drawing.Point(122, 242);
            this.mskTelefo.Mask = "0000-00-00";
            this.mskTelefo.Name = "mskTelefo";
            this.mskTelefo.Size = new System.Drawing.Size(106, 26);
            this.mskTelefo.TabIndex = 12;
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Location = new System.Drawing.Point(126, 210);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(106, 24);
            this.rbnFemenino.TabIndex = 11;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "Femenino";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(126, 180);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(107, 24);
            this.rbtnMasc.TabIndex = 10;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(122, 87);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(207, 26);
            this.txtCorreo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fotografia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo";
            // 
            // sP_Evento_SelectAllTableAdapter
            // 
            this.sP_Evento_SelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenu_Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 498);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu_Participantes";
            this.Text = "Registro de Participantes";
            this.Load += new System.EventHandler(this.frmMenu_Participantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPEventoSelectAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigo_SecretoDataSet)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Amigo_SecretoDataSet amigo_SecretoDataSet;
        private System.Windows.Forms.BindingSource sPEventoSelectAllBindingSource;
        private Amigo_SecretoDataSetTableAdapters.SP_Evento_SelectAllTableAdapter sP_Evento_SelectAllTableAdapter;
    }
}