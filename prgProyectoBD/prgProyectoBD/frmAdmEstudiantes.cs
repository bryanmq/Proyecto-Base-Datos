﻿using System;
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
        private LNEstudiantes lnEstudiantes;

        public frmAdmEstudiantes()
        {
            InitializeComponent();
            lnEstudiantes = new LNEstudiantes();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = lnEstudiantes.listarEmpleados();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
