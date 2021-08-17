namespace Model
{
    public class EncuentroGenerado
    {
        private int id;
        private int idEquipoLocal;
        private int idEquipoVisitante;
        private string estado;
        private string asignacion;

        public EncuentroGenerado()
        {

        }
        public EncuentroGenerado(int idEquipoLocal, int idEquipoVisitante)
        {
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
        }
       public EncuentroGenerado(int idEquipoLocal, int idEquipoVisitante, string estado)
        {
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
            this.estado = estado;
        }
        public EncuentroGenerado(int id, int idEquipoLocal, int idEquipoVisitante, string estado, string asignacion)
        {
            this.id = id;
            this.idEquipoLocal = idEquipoLocal;
            this.idEquipoVisitante = idEquipoVisitante;
            this.estado = estado;
            this.asignacion = asignacion;
        }

        public int Id { get => id; set => id = value; }
        public int IdEquipoLocal { get => idEquipoLocal; set => idEquipoLocal = value; }
        public int IdEquipoVisitante { get => idEquipoVisitante; set => idEquipoVisitante = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Asignacion { get => asignacion; set => asignacion = value; }
    }
}
