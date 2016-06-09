using System;
using System.Windows.Forms;
using Entidades;
using Lógica;

namespace prgProyectoBD
{
    public partial class frmProfesores : Form
    {
        private int index;
        private Profesor profesor;
        private LNProfesores lnProfesores;
        private DataGridView dgvProfesores;

        public frmProfesores(int index, LNProfesores lnProfesores, DataGridView dgvProfesores)
        {
            InitializeComponent();
            this.index = index;
            this.dgvProfesores = dgvProfesores;
            this.lnProfesores = lnProfesores;
        }

        public frmProfesores(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            if (index != 1)
            {
                profesor = lnProfesores.listaProfesores(Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value.ToString()));
                txtIDProfesor.Text =Convert.ToString(profesor.idProfesor);
                txtNombre.Text = profesor.nombre;
                dtpFechaNacimiento.Value = profesor.fechaNacimiento;
                txtDireccion.Text = profesor.direccion;
                mskTel.Text = profesor.telefono;
                txtEmail.Text = profesor.email;
                btnAceptar.Text = "Modificar";
            }
            else
            {
                txtIDProfesor.Enabled = true;
            }
        }
   //******************************************************************************************
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
   //******************************************************************************************
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validacionCampos())
            {
                profesor = new Profesor(Convert.ToInt32( txtIDProfesor.Text), txtNombre.Text, txtDireccion.Text, Convert.ToDateTime(dtpFechaNacimiento.Text), mskTel.Text, txtEmail.Text);
                if (index == 1)
                {
                    lnProfesores.agregarProfesor(profesor);
                    refresh();
                    this.Dispose();
                }
                else
                {
                    lnProfesores.modificarProfesor(profesor);
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
            dgvProfesores.DataSource = lnProfesores.listaProfesores();
        }

        public Boolean validacionCampos()
        {
            if (txtIDProfesor.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && mskTel.Text != "" && txtEmail.Text != "")
            {
                return true;
            }
            return false;
        }

    }
}
