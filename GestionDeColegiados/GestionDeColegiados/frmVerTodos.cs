﻿using Control.AdmEquipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmVerTodos : Form
    {
        AdmEquipo equipo = AdmEquipo.getEquipo();
        public frmVerTodos()
        {
            InitializeComponent();
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = tablaDatos.CurrentRow;
            string id = filaSeleccionada.Cells[1].Value.ToString();
            frmEditarEquipo editar= new frmEditarEquipo(id);
            editar.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            String nombre = nomEquipo.Text;
            if (nombre.CompareTo("") != 0)
            {
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                equipo.LlenaTabla(tablaDatos, nombre);
            }
            else
            {
                MessageBox.Show("Debe ingresar algún parámetro para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
