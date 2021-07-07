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
                comando.Parameters.AddWithValue("_hora", encuentroDefinido.Hora.ToString("HH:mm"));
                comando.Parameters.AddWithValue("_idencuentro", encuentroDefinido.IdEncuentroGeneradoPendiente);
                comando.Parameters.AddWithValue("_idcolegiado", encuentroDefinido.IdColegiado);
                comando.Parameters.AddWithValue("_idestadio", encuentroDefinido.IdEstadio);
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

        public List<EncuentroDefinido> ObtenerEncuentros()
        {
            List<EncuentroDefinido> lista = new List<EncuentroDefinido>() ;
            EncuentroDefinido encuentroDefinido = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("mostrarEncuentroDefinidos", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    encuentroDefinido = new EncuentroDefinido();
                    encuentroDefinido.Id = Convert.ToInt32(reader["idefinido"].ToString());
                    encuentroDefinido.IdColegiado = Convert.ToInt32(reader["idcolegiado"].ToString());
                    encuentroDefinido.IdEncuentroGeneradoPendiente = Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentroDefinido.IdEstadio = Convert.ToInt32(reader["idefinido"].ToString());
                    lista.Add(encuentroDefinido);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
