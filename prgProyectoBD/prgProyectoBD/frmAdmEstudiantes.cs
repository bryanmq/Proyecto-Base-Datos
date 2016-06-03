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
    public partial class frmAdmEstudiantes : Form
    {
        public LNEstudiantes lnEstudiantes;

        public frmAdmEstudiantes()
        {
            InitializeComponent();
            lnEstudiantes = new LNEstudiantes();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = lnEstudiantes.listaEstudiantes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEstudiantes frmEst = new frmEstudiantes(1, lnEstudiantes, this.dgvEstudiantes);
            frmEst.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
