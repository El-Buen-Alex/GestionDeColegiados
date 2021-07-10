namespace Model
{
    public abstract class Arbitro
    {
        private int idArbitro;
        private string cedula;
        private string nombre;
        private string apellidos;
        private string domicilio;
        private string email;
        private string telefono;

        public Arbitro()
        {
        }

        public Arbitro(int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.domicilio = domicilio;
            this.email = email;
            this.telefono = telefono;
        }

        public int IdArbitro { get => idArbitro; set => idArbitro = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
