using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;
using Entidades;
using DAL;

namespace prgProyectoBD
{
    public partial class frmAdmProfesores : Form
    {
        public LNProfesores lnProfesores;
        public frmAdmProfesores()
        {
            InitializeComponent();
            lnProfesores = new LNProfesores();
        }


        private void frmAdmProfesores_Load(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = lnProfesores.listaProfesores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProfesores frmProf = new frmProfesores(1, lnProfesores, this.dgvProfesores);
            frmProf.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProfesores frmProf = new frmProfesores(2, lnProfesores, this.dgvProfesores);
            frmProf.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar al Profesor: \"" + dgvProfesores.CurrentRow.Cells[1].Value.ToString() + "\"?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                lnProfesores.eliminarProfesor(Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value.ToString()));
                dgvProfesores.DataSource = lnProfesores.listaProfesores();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
