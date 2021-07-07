using Model;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatosEncuentroDefinido
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction transaccion = null;


        public int GuardarEncuentroDefinido(EncuentroDefinido encuentroDefinido)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            Console.WriteLine(encuentroDefinido.FechaDeEncuentro.ToShortDateString())  ;
            try
            {
                MySqlCommand comando = new MySqlCommand("guardarEncuentrosDefinidos", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_fecha", encuentroDefinido.FechaDeEncuentro.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("_idencuentro", encuentroDefinido.IdEncuentroGeneradoPendiente);
                comando.Parameters.AddWithValue("_idcolegiado", encuentroDefinido.IdColegiado);
                comando.Parameters.AddWithValue("_estado", encuentroDefinido.Estado);
                comando.ExecuteNonQuery();
                comando = new MySqlCommand("obtenerId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id != 0)
                {
                    transaccion.Commit();
                }
            }
            catch(MySqlException ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
            }
            return id;
        }
    }
}
