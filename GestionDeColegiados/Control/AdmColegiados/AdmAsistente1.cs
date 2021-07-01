using Data;
using Model.Colegiados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control.AdmColegiados {
    public class AdmAsistente1 : IAdm{
        List<Asistente> listaAsistente1 = new List<Asistente>();
        Asistente asistente1 = null;
        ValidacionGUI v = new ValidacionGUI();
        Datos datos = new Datos();

        private static AdmAsistente1 admA1 = null;

        public List<Asistente> ListaAsistente1 { get => listaAsistente1; set => listaAsistente1 = value; }

        private AdmAsistente1 () {
            listaAsistente1 = new List<Asistente>();
        }

        public static AdmAsistente1 getAdmA1 () {
            if (admA1 == null)
                admA1 = new AdmAsistente1();
            return admA1;
        }

        //Agregar
        public int guardar (TextBox txtcedulaAs1, TextBox txtnombreAs1, TextBox txtapellidoAs1, 
            TextBox txtdomicilioAs1, TextBox txtemailAs1, TextBox txttelefonoAs1) {
            string cedula = txtcedulaAs1.Text,
                nombre = txtnombreAs1.Text,
                apellidos = txtapellidoAs1.Text,
                domicilio = txtdomicilioAs1.Text,
                email = txtemailAs1.Text,
                telefono = txttelefonoAs1.Text;
            int id = 0;

            asistente1 = new Asistente(0, cedula, nombre, apellidos, domicilio, email, telefono, "Derecha");

            if (asistente1 != null) {
                listaAsistente1.Add(asistente1);
                id = GuardarAsistente1BD(asistente1); //Guardar BD
            }
            return id;
        }

        private int GuardarAsistente1BD (Asistente asistente1) {
            int id = 0;

            id = datos.InsertarAsistente1(asistente1);
            if (id == 0) {
                MessageBox.Show("No se ha podido comunicar con la BD");
            }
            return id;
        }
    }
}
