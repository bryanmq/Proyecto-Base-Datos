namespace Practica_1
{
    partial class frmAdmEstudiantes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmEstudiantes));
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.dgvEstudiantes, "dgvEstudiantes");
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Image = global::prgProyectoBD.Properties.Resources.Cubo_de_basura2;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.botonEliminar, "botonEliminar");
            this.botonEliminar.FlatAppearance.BorderSize = 0;
            this.botonEliminar.Image = global::prgProyectoBD.Properties.Resources.Lápiz_de_rayas_símbolo_para_interfaz_de_botones_de_editar;
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = global::prgProyectoBD.Properties.Resources.magnifier13_1_;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::prgProyectoBD.Properties.Resources.Flecha_de_actualización2;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = global::prgProyectoBD.Properties.Resources.Nuevo_usuario;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmAdmEstudiantes
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvEstudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmEstudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

