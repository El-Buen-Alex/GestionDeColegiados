namespace Model.Colegiados
{
    /// <summary>
    /// Clase Juez Central que hereda los atributos de arbitro.
    /// </summary>
    public class JuezCentral : Arbitro
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public JuezCentral () {
        }

        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="idArbitro">ID del Juez Central.</param>
        /// <param name="cedula">Cedula del Juez Central.</param>
        /// <param name="nombre">Nombre del Juez Central.</param>
        /// <param name="apellidos">Apellido del Juez Central.</param>
        /// <param name="domicilio">Domicilio del Juez Central.</param>
        /// <param name="email">Email del Juez Central.</param>
        /// <param name="telefono">Telefono del Juez Central.</param>
        public JuezCentral (int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono) : base(idArbitro, cedula, nombre, apellidos,
                domicilio, email, telefono)
        {
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