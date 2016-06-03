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

namespace prgProyectoBD
{
    public partial class mdiMenu : Form
    {
        private frmAdmEstudiantes frmAdmEst;


        public mdiMenu()
        {
            InitializeComponent();
   
        }

        private void mdiMenu_Load(object sender, EventArgs e)
        {

        }

        private void administrarEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmEst= new frmAdmEstudiantes();
            frmAdmEst.Show();

        }
    }
}
