﻿using Data;
using Model.Colegiados;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control.AdmColegiados
{
    public class AdmJuezCentral : IAdm
    {
        List<JuezCentral> listaJuezCentral = new List<JuezCentral>();
        JuezCentral juezCentral = null;
        ValidacionGUI v = new ValidacionGUI();
        DatosColegiados datos = new DatosColegiados();

        private static AdmJuezCentral admJ = null;

        public List<JuezCentral> ListaJuezCentral { get => listaJuezCentral; set => listaJuezCentral = value; }

        private AdmJuezCentral()
        {
            listaJuezCentral = new List<JuezCentral>();
        }

        public static AdmJuezCentral getAdmJ()
        {
            if (admJ == null)
                admJ = new AdmJuezCentral();
            return admJ;
        }

        //Agregar
        public int guardar(TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC,
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC)
        {
            string cedula = txtcedulaJC.Text,
                nombre = txtnombreJC.Text,
                apellidos = txtapellidoJC.Text,
                domicilio = txtdomicilioJC.Text,
                email = txtemailJC.Text,
                telefono = txttelefonoJC.Text;
            int id = 0;

            juezCentral = new JuezCentral(0, cedula, nombre, apellidos, domicilio, email, telefono);

            if (juezCentral != null)
            {
                listaJuezCentral.Add(juezCentral);
                id = GuardarJuezCentralBD(juezCentral); //Guardar BD
            }
            return id;
        }

        private int GuardarJuezCentralBD(JuezCentral juezCentral)
        {
            int id = 0;

            id = datos.InsertarJuezCentral(juezCentral);
            if (id == 0)
            {
                MessageBox.Show("No se ha podido comunicar con la BD");
            }
            return id;
        }
    }
}
