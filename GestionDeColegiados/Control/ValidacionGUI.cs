﻿using System;
using System.Windows.Forms;

namespace Control
{
    public class ValidacionGUI
    {

        public int EsInt(string valor)
        {
            int x = 0;
            try
            {
                x = int.Parse(valor);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public double EsDouble(string valor)
        {
            double x = 0.0;
            try
            {
                x = double.Parse(valor);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public bool validarVacios(string nombre, string numjugadores, string director, string presidente)
        {
            bool camposVacios = false;
            if (String.IsNullOrEmpty(nombre.Trim()) == true || String.IsNullOrEmpty(numjugadores.Trim()) || String.IsNullOrEmpty(director.Trim()) || String.IsNullOrEmpty(presidente.Trim()))
                camposVacios = true;

            return camposVacios;
        }

        public float EsFloat(string valor)
        {
            float x = 0;
            try
            {
                x = float.Parse(valor);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        public bool validarVacios(TextBox txtcedulaJC, TextBox txtnombreJC, TextBox txtapellidoJC,
            TextBox txtdomicilioJC, TextBox txtemailJC, TextBox txttelefonoJC)
        {
            bool vacio = true;
            if (txtcedulaJC.Text != "" && txtnombreJC.Text != "" && txtapellidoJC.Text != "" &&
                txtdomicilioJC.Text != "" && txtemailJC.Text != "" && txttelefonoJC.Text != "")
            {
                return vacio = false;
            }
            return vacio;
        }

        public bool validarnum(int idJuezCentral, int idAsistente1, int idAsistente2, int idCuartoArbitro)
        {
            bool vacio = true;
            if (idJuezCentral != 0 && idAsistente1 != 0 && idAsistente2 != 0 && idCuartoArbitro != 0)
            {
                vacio = false;
            }
            return vacio;
        }
    }
}
