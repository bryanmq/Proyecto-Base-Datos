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
            if (index != 1)
            {
                estudiante = lnEstudiantes.listaEstudiante(Convert.ToString(dgvEstudiantes.CurrentRow.Cells[0].Value.ToString()));
                txtCarnet.Text = estudiante.carnet;
                txtNombre.Text = estudiante.nombre;
                txtDireccion.Text = estudiante.direccion;
                dtpFechaNacimiento.Value = estudiante.fechaNacimiento;
                mskTel.Text = estudiante.telefono;
                txtEmail.Text = estudiante.email;
                btnAceptar.Text = "Modificar";
            }
            else
            {
                txtCarnet.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validacionCampos())
            {
                estudiante = new Estudiante(txtCarnet.Text, txtNombre.Text, txtDireccion.Text, Convert.ToDateTime(dtpFechaNacimiento.Text), mskTel.Text, txtEmail.Text);
                if (index == 1)
                {
                    lnEstudiantes.agregarEstudiante(estudiante);
                    refresh();
                    this.Dispose();
                }
                else
                {
                    lnEstudiantes.modificarEstudiante(estudiante);
                    refresh();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Existen Campos Vacios");
            }
        }

        public void refresh()
        {
            dgvEstudiantes.DataSource = lnEstudiantes.listaEstudiantes();
        }

        public Boolean validacionCampos()
        {
            if (txtCarnet.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && mskTel.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
