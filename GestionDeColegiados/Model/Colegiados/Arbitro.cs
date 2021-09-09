namespace Model
{
    /// <summary>
    /// Clase Abstracta Arbitro.
    /// </summary>
    public abstract class Arbitro
    {
        private int idArbitro;
        private string cedula;
        private string nombre;
        private string apellidos;
        private string domicilio;
        private string email;
        private string telefono;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Arbitro() {
        }

        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="idArbitro">ID del arbitro.</param>
        /// <param name="cedula">Cedula del arbito.</param>
        /// <param name="nombre">Nombre del arbito.</param>
        /// <param name="apellidos">Apellido del arbito.</param>
        /// <param name="domicilio">Domicilio del arbito.</param>
        /// <param name="email">Email del arbito.</param>
        /// <param name="telefono">Telefono del arbito.</param>
        public Arbitro (int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.domicilio = domicilio;
            this.email = email;
            this.telefono = telefono;
        }

        /// <summary>
        /// Métodos Getter y Setter de los atributos de arbitro.
        /// </summary>
        public int IdArbitro { get => idArbitro; set => idArbitro = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }

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