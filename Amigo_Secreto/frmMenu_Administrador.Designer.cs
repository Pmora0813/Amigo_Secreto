namespace Amigo_Secreto
{
    partial class frmMenu_Administrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.evetosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // evetosToolStripMenuItem
            // 
            this.evetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEventoToolStripMenuItem,
            this.modificarEventoToolStripMenuItem,
            this.consultarEventosToolStripMenuItem,
            this.eliminarEventosToolStripMenuItem});
            this.evetosToolStripMenuItem.Name = "evetosToolStripMenuItem";
            this.evetosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.evetosToolStripMenuItem.Text = "Eventos";
            // 
            // crearEventoToolStripMenuItem
            // 
            this.crearEventoToolStripMenuItem.Name = "crearEventoToolStripMenuItem";
            this.crearEventoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.crearEventoToolStripMenuItem.Text = "Crear Evento";
            this.crearEventoToolStripMenuItem.Click += new System.EventHandler(this.crearEventoToolStripMenuItem_Click);
            // 
            // modificarEventoToolStripMenuItem
            // 
            this.modificarEventoToolStripMenuItem.Name = "modificarEventoToolStripMenuItem";
            this.modificarEventoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificarEventoToolStripMenuItem.Text = "Modificar Evento";
            this.modificarEventoToolStripMenuItem.Click += new System.EventHandler(this.modificarEventoToolStripMenuItem_Click);
            // 
            // consultarEventosToolStripMenuItem
            // 
            this.consultarEventosToolStripMenuItem.Name = "consultarEventosToolStripMenuItem";
            this.consultarEventosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarEventosToolStripMenuItem.Text = "Consultar Eventos";
            this.consultarEventosToolStripMenuItem.Click += new System.EventHandler(this.consultarEventosToolStripMenuItem_Click);
            // 
            // eliminarEventosToolStripMenuItem
            // 
            this.eliminarEventosToolStripMenuItem.Name = "eliminarEventosToolStripMenuItem";
            this.eliminarEventosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarEventosToolStripMenuItem.Text = "Eliminar Eventos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmMenu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Amigo_Secreto.Properties.Resources.i_1;
            this.ClientSize = new System.Drawing.Size(361, 230);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEventosToolStripMenuItem;
    }
}