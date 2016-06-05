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
        public LNUsuarios lnUsuarios;
        public Usuario uUsuario;
  
        public frmAcceso()
        {
            InitializeComponent();
            lnUsuarios = new LNUsuarios();
            uUsuario = new Usuario();
 
        }


        private Boolean validarCamposVacios()
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" )
            {
                return true;
            }
            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios()) { 
            if (lnUsuarios.verifiarUsuario(txtUsuario.Text, txtClave.Text))
            {
                mdi = new mdiMenu();
                mdi.Show();
                txtUsuario.Text = "";
                txtClave.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }else 
        {
                MessageBox.Show("Llene todos los campos para seguir");
        }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
