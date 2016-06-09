using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Lógica;
using DAL;

namespace prgProyectoBD
{
    public partial class frmAdmUsuarios : Form
    {
        public frmAdmUsuarios()
        {
            InitializeComponent();
        }

        private void admUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxTipo.Text=="profesor")
            {
                frmProfesores frm = new frmProfesores(1);
                frm.Show();
            }
            else
            {
                if (cbxTipo.Text == "estudiante")
                {
                    frmEstudiantes frm = new frmEstudiantes(1);
                    frm.Show();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
