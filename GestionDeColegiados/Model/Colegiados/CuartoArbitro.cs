namespace Model.Colegiados
{
    /// <summary>
    /// Clase Cuarto Arbitro que hereda los atributos de arbitro.
    /// </summary>
    public class CuartoArbitro : Arbitro
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public CuartoArbitro () {
        }

        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="idArbitro">ID del Cuarto Arbitro.</param>
        /// <param name="cedula">Cedula del Cuarto Arbitro.</param>
        /// <param name="nombre">Nombre del Cuarto Arbitro.</param>
        /// <param name="apellidos">Apellido del Cuarto Arbitro.</param>
        /// <param name="domicilio">Domicilio del Cuarto Arbitro.</param>
        /// <param name="email">Email del Cuarto Arbitro.</param>
        /// <param name="telefono">Telefono del Cuarto Arbitro.</param>
        public CuartoArbitro (int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono) : base(idArbitro, cedula, nombre, apellidos,
                domicilio, email, telefono) {
        }

        /// <summary>
        /// Método que “convierte” el objeto a mostrar en texto.
        /// </summary>
        /// <returns>Devuelve una cadena de texto.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}