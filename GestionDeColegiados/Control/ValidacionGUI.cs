using System;
using System.Windows.Forms;

namespace Control
{
    /// <summary>
    /// Clase para validar datos.
    /// </summary>
    public class ValidacionGUI
    {
        /// <summary>
        /// Convierte un string en entero.
        /// </summary>
        /// <param name="valor">Cadena para convertir.</param>
        /// <returns>Devuelve el numero como entero.</returns>
        public int AInt(string valor)
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

        /// <summary>
        /// Convierte un string en double.
        /// </summary>
        /// <param name="valor">Cadena para convertir.</param>
        /// <returns>Devuelve el numero como double.</returns>
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

        /// <summary>
        /// Convierte un string en float.
        /// </summary>
        /// <param name="valor">Cadena para convertir.</param>
        /// <returns>Devuelve el numero como float.</returns>
        public float EsFloat (string valor) {
            float x = 0;
            try {
                x = float.Parse(valor);
            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
            return x;
        }

        /// <summary>
        /// Valida TexBox vacios de árbitros.
        /// </summary>
        /// <param name="txtcedula">Cedula recogida.</param>
        /// <param name="txtnombre">Nombre recogido.</param>
        /// <param name="txtapellido">Apellido recogido.</param>
        /// <param name="txtdomicilio">Domicilio recogido.</param>
        /// <param name="txtemail">Email recogido.</param>
        /// <param name="txttelefono">Telefono recogido.</param>
        /// <returns>Devuelve true si hay espacios vacios o false si no los hay.</returns>
        public bool validarVacios(TextBox txtcedula, TextBox txtnombre, TextBox txtapellido,
            TextBox txtdomicilio, TextBox txtemail, TextBox txttelefono)
        {
            bool vacio = true;
            if (txtcedula.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" &&
                txtdomicilio.Text != "" && txtemail.Text != "" && txttelefono.Text != "")
            {
                return vacio = false;
            }
            return vacio;
        }

        /// <summary>
        /// Valida que los id de los árbitros no sean 0.
        /// </summary>
        /// <param name="idJuezCentral">ID Juez Central.</param>
        /// <param name="idAsistente1">ID Asistente 1.</param>
        /// <param name="idAsistente2">ID Asistente 2.</param>
        /// <param name="idCuartoArbitro">ID Cuarto Árbitro.</param>
        /// <returns>Devuelve true si cualquiera de los campos son 0 o false si son diferentes de 0.</returns>
        public bool validarnum(int idJuezCentral, int idAsistente1, int idAsistente2, int idCuartoArbitro)
        {
            bool vacio = true;
            if (idJuezCentral != 0 && idAsistente1 != 0 && idAsistente2 != 0 && idCuartoArbitro != 0)
            {
                vacio = false;
            }
            return vacio;
        }

        /// <summary>
        /// Valida los campos vacios de Equipo.
        /// </summary>
        /// <param name="nombre">Nombre recogido.</param>
        /// <param name="numjugadores">Numero de jugadores recogido.</param>
        /// <param name="director">Director recogido.</param>
        /// <param name="presidente">Presidente recogido.</param>
        /// <returns>Devuelve true si existe algún campo vacio o false si no los hay.</returns>
        public bool validarVacios (string nombre, string numjugadores, string director, string presidente) {
            bool camposVacios = false;
            if (String.IsNullOrEmpty(nombre.Trim()) == true || String.IsNullOrEmpty(numjugadores.Trim()) || String.IsNullOrEmpty(director.Trim()) || String.IsNullOrEmpty(presidente.Trim()))
                camposVacios = true;

            return camposVacios;
        }

        /// <summary>
        /// Validar fecha elegida.
        /// </summary>
        /// <param name="fechaElegida">Fecha recogida.</param>
        /// <returns>Devuelve false si la <c>fechaElegida</c> es menor a la fecha actual o true si es mayor.</returns>
        public bool ValidarFecha(DateTime fechaElegida)
        {
            bool respuesta = true;
            if (fechaElegida <= DateTime.Now)
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}