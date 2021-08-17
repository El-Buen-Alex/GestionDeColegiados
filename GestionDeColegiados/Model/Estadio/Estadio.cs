namespace Model
{
    public class Estadio
    {
        private int id;
        private string nombre;
        private string asignacion;

        public Estadio()
        {

        }
        public Estadio(int id, string nombre, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.asignacion = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Asignacion { get => asignacion; set => asignacion = value; }
    }
}
