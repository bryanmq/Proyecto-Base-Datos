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
    public partial class frmAcceso : Form
    {
        private mdiMenu mdi;
  
        public frmAcceso()
        {
            InitializeComponent();
 
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mdi = new mdiMenu();
            mdi.Show();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
