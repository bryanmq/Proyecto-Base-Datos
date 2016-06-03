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

namespace prgProyectoBD
{
    public partial class frmEstudiantes : Form
    {
        private int index;
        private Estudiante estudiante;
        private LNEstudiantes lnEstudiantes;
        private DataGridView dgvEstudiantes;

        public frmEstudiantes(int index, LNEstudiantes lnEstudiantes, DataGridView dgvEstudiantes)
        {

            InitializeComponent();
            this.index = index;
            this.dgvEstudiantes = dgvEstudiantes;
            this.lnEstudiantes = lnEstudiantes;

        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            estudiante = lnEstudiantes.listaEstudiante(Convert.ToString(dgvEstudiantes.CurrentRow.Cells[0].Value.ToString()));
            txtCarnet.Text = estudiante.carnet;
            txtNombre.Text = estudiante.nombre;
            txtDireccion.Text = estudiante.direccion;
            dtpFechaNacimiento.Value = estudiante.fechaNacimiento;
            mskTel.Text = estudiante.telefono;
            txtEmail.Text = estudiante.email;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
