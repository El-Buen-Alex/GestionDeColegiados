namespace Model.Colegiados
{
    /// <summary>
    /// Clase Asistente que hereda los atributos de arbitro.
    /// </summary>
    public class Asistente : Arbitro
    {
        private string banda;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Asistente () {
        }

        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="idArbitro">ID del Asitente.</param>
        /// <param name="cedula">Cedula del Asitente.</param>
        /// <param name="nombre">Nombre del Asitente.</param>
        /// <param name="apellidos">Apellido del Asitente.</param>
        /// <param name="domicilio">Domicilio del Asitente.</param>
        /// <param name="email">Email del Asitente.</param>
        /// <param name="telefono">Telefono del Asitente.</param>
        /// <param name="banda">Banda o posicion del Asitente-</param>
        public Asistente (int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono, string banda) : base(idArbitro, cedula,
                nombre, apellidos, domicilio, email, telefono)
        {
            this.banda = banda;
        }

        /// <summary>
        /// Método Getter y Setter de los atributos de asistente.
        /// </summary>
        public string Banda { get => banda; set => banda = value; }

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