﻿using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class AdmAsistente2 {
        List<Asistente> listaAsistente2 = new List<Asistente>();
        Asistente asistente2 = null;
        ValidacionGUI v = new ValidacionGUI();
        Datos datos = new Datos();

        private static AdmAsistente2 admA2 = null;

        public List<Asistente> ListaAsistente2 { get => listaAsistente2; set => listaAsistente2 = value; }

        private AdmAsistente2 () {
            listaAsistente2 = new List<Asistente>();
        }

        public static AdmAsistente2 getAdmA2 () {
            if (admA2 == null)
                admA2 = new AdmAsistente2();
            return admA2;
        }

        //Agregar
        public int Guardar (TextBox txtcedulaAs2, TextBox txtnombreAs2, TextBox txtapellidoAs2,
            TextBox txtdomicilioAs2, TextBox txtemailAs2, TextBox txttelefonoAs2) {
            string cedula = txtcedulaAs2.Text,
                nombre = txtnombreAs2.Text,
                apellidos = txtapellidoAs2.Text,
                domicilio = txtdomicilioAs2.Text,
                email = txtemailAs2.Text,
                telefono = txttelefonoAs2.Text;
            int id = 0;

            asistente2 = new Asistente(0, cedula, nombre, apellidos, domicilio, email, telefono, "Izquierda");

            if (asistente2 != null) {
                listaAsistente2.Add(asistente2);
                id = GuardarAsistente2(asistente2); //Guardar BD
            }
            return id;
        }

        private int GuardarAsistente2 (Asistente asistente2) {
            int id = 0;
            
            id = datos.InsertarAsistente2(asistente2);
            if (id == 0) {
                MessageBox.Show("No se ha podido comunicar con la BD");
            }
            return id;
        }
    }
}