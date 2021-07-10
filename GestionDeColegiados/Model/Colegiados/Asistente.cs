namespace Model.Colegiados
{
    public class Asistente : Arbitro
    {
        private string banda;

        public Asistente(int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono, string banda) : base(idArbitro, cedula,
                nombre, apellidos, domicilio, email, telefono)
        {
            this.banda = banda;
        }

        public string Banda { get => banda; set => banda = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
