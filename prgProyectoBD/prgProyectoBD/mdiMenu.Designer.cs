namespace prgProyectoBD
{
    partial class mdiMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.administrarProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónRolesYPrivilegiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDePantallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarEstudiantesToolStripMenuItem,
            this.toolStripSeparator1,
            this.administrarProfesoresToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // administrarEstudiantesToolStripMenuItem
            // 
            this.administrarEstudiantesToolStripMenuItem.Name = "administrarEstudiantesToolStripMenuItem";
            this.administrarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.administrarEstudiantesToolStripMenuItem.Text = "Administrar Estudiantes";
            this.administrarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.administrarEstudiantesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // administrarProfesoresToolStripMenuItem
            // 
            this.administrarProfesoresToolStripMenuItem.Name = "administrarProfesoresToolStripMenuItem";
            this.administrarProfesoresToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.administrarProfesoresToolStripMenuItem.Text = "Administrar Profesores";
            this.administrarProfesoresToolStripMenuItem.Click += new System.EventHandler(this.administrarProfesoresToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciónRolesYPrivilegiosToolStripMenuItem,
            this.toolStripSeparator2,
            this.asignaciónDePantallasToolStripMenuItem,
            this.toolStripSeparator3,
            this.configuraciónPersonalToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.seguridadToolStripMenuItem.Text = "Configuración";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // creaciónRolesYPrivilegiosToolStripMenuItem
            // 
            this.creaciónRolesYPrivilegiosToolStripMenuItem.Name = "creaciónRolesYPrivilegiosToolStripMenuItem";
            this.creaciónRolesYPrivilegiosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.creaciónRolesYPrivilegiosToolStripMenuItem.Text = "Creación Roles y Privilegios";
            this.creaciónRolesYPrivilegiosToolStripMenuItem.Click += new System.EventHandler(this.creaciónRolesYPrivilegiosToolStripMenuItem_Click);
            // 
            // asignaciónDePantallasToolStripMenuItem
            // 
            this.asignaciónDePantallasToolStripMenuItem.Name = "asignaciónDePantallasToolStripMenuItem";
            this.asignaciónDePantallasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.asignaciónDePantallasToolStripMenuItem.Text = "Asignación de Pantallas";
            // 
            // configuraciónPersonalToolStripMenuItem
            // 
            this.configuraciónPersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioContraseñaToolStripMenuItem});
            this.configuraciónPersonalToolStripMenuItem.Name = "configuraciónPersonalToolStripMenuItem";
            this.configuraciónPersonalToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.configuraciónPersonalToolStripMenuItem.Text = "Configuración Personal";
            this.configuraciónPersonalToolStripMenuItem.Click += new System.EventHandler(this.configuraciónPersonalToolStripMenuItem_Click);
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            this.cambioContraseñaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cambioContraseñaToolStripMenuItem.Text = "Cambio Contraseña";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mdiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenid@s";
            this.Load += new System.EventHandler(this.mdiMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem administrarProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónRolesYPrivilegiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDePantallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}



