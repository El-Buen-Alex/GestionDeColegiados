namespace Model.Colegiados
{
    public class JuezCentral : Arbitro
    {

        public JuezCentral(int idArbitro, string cedula, string nombre, string apellidos,
            string domicilio, string email, string telefono) : base(idArbitro, cedula, nombre, apellidos,
                domicilio, email, telefono)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
