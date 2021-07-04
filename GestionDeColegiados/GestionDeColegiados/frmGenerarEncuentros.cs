﻿using Control.AdmEquipos;
using Model.Equipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionDeColegiados
{
    public partial class frmGenerarEncuentros : Form
    {
        AdmEquipo admEquipo = AdmEquipo.getEquipo();
        List<Equipo> nombreEquipo = new List<Equipo>();
        public frmGenerarEncuentros()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            nombreEquipo =admEquipo.extraerNombreEquipos();
            if (nombreEquipo.Count == 0)
            {
                MessageBox.Show("No existen Equipos registrados, primero ingrese algunos!");
            }
            else
            {
                admEquipo.llenarCamposTextos(local, 1,6);
                admEquipo.llenarCamposTextos(visitante, 6, 11);

            }
            
        }
       

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guardarDatos_Click(object sender, EventArgs e)
        {
            nombreEquipo = admEquipo.extraerNombreEquipos();
            if (nombreEquipo.Count == 0)
            {
                MessageBox.Show("No existen Equipos registrados, primero ingrese algunos!");
            }
            else
            {
               admEquipo.registrarEncuentros("estado");
            }
        }
    }
}
