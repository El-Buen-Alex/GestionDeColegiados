﻿using Data;
using Model.Colegiados;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmColegiado
    {
        List<Colegiado> listaColegiado = new List<Colegiado>();
        Colegiado colegiado = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();
        private List<IntegrantesColegiados> listaintegColeg;
        private static AdmColegiado admCol = null;

        public List<Colegiado> ListaColegiado { get => listaColegiado; set => listaColegiado = value; }
        public List<IntegrantesColegiados> ListaintegColeg { get => listaintegColeg; set => listaintegColeg = value; }

        private AdmColegiado()
        {
            listaColegiado = new List<Colegiado>();
        }

        public static AdmColegiado getAdmCol()
        {
            if (admCol == null)
                admCol = new AdmColegiado();
            return admCol;
        }

        public void LlenarColegiadosCmb(ComboBox cmbGrupoColegiado)
        {
            listaintegColeg = new List<IntegrantesColegiados>();
            listaintegColeg = datos.ConsultarColegiado();
            cmbGrupoColegiado.DisplayMember = "NombrejuezCentral";
            cmbGrupoColegiado.DataSource = listaintegColeg;

        }

        public void Guardar(int idjuezcentral, int idasistente1, int idasistente2, int idcuartoarbitro)
        {
            colegiado = new Colegiado(0, idjuezcentral, idasistente1, idasistente2, idcuartoarbitro);

            if (colegiado != null)
            {
                listaColegiado.Add(colegiado);
                GuardarColegiadoBD(colegiado); //Guardar BD
            }
        }

        private void GuardarColegiadoBD(Colegiado colegiado)
        {
            string mensaje = "";
            try {
                datos.InsertarColegiado(colegiado);
            } catch (insertarFallidoBDException ex) {
                mensaje = ex.Message;
            }
            if (mensaje != "") {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("No se ha guardado el colegiado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Se ha guardado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Listar
        public void llenarDatos(DataGridView dgvListarColegiados)
        {
            listaintegColeg = datos.ConsultarColegiado();
            foreach (IntegrantesColegiados integrantescol in listaintegColeg)
            {
                dgvListarColegiados.Rows.Add(integrantescol.NombrejuezCentral, integrantescol.Nombreasistente1, integrantescol.Nombreasistente2, integrantescol.NombrecuartoArbitro);
            }
        }

        public string ObtenerNombreDeColegiados(int idColegiado)
        {
            string nombres = "0";
            nombres = datos.ObtenerNombreDeColegiados(idColegiado);
            return nombres;
        }

        public int obtenerCantidadColegiado()
        {
            listaintegColeg = datos.ConsultarColegiado();
            return listaintegColeg.Count;
        }


        public bool validarCedula (TextBox txtcedula) 
        {
            string cedula = txtcedula.Text;
            bool repetido = false;
            listaintegColeg = datos.ConsultarCedulaColegiado();
            foreach(IntegrantesColegiados integ in listaintegColeg) 
            {
                if(integ.NombrejuezCentral == cedula || integ.Nombreasistente1 == cedula || 
                    integ.Nombreasistente2 == cedula || integ.NombrecuartoArbitro == cedula) 
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }
    }
} 