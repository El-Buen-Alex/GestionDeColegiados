using Model.Partido;
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
    public class DatosEncuentroFinalizado
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;

        public bool AddEncuentroFinalizado(EncuentroFinalizado encuentroFinalizado)
        {
            bool guardado = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarPartidoFinalizado", conexion, trans);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_idEquipo", encuentroFinalizado.IdEquipo);
                cmd.Parameters.AddWithValue("@_idDefinido", encuentroFinalizado.IdEncuentroDefinido);
                cmd.Parameters.AddWithValue("@_golesFavor", encuentroFinalizado.GolesFavor);
                cmd.Parameters.AddWithValue("@_golesContra", encuentroFinalizado.GolesContra);
                cmd.Parameters.AddWithValue("@_golesDiferencia", encuentroFinalizado.GolesDiferencia);
                cmd.Parameters.AddWithValue("@_puntos",encuentroFinalizado.Puntos);
                cmd.Parameters.AddWithValue("@_copa", encuentroFinalizado.Copa);

                cmd.ExecuteNonQuery();
             
                trans.Commit();

                guardado = true;
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new Exception(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
           
            return guardado;
        }

        public List<EncuentroFinalizado> GetEncuentrosFinalizados(string anio)
        {
            List<EncuentroFinalizado> posiciones = new List<EncuentroFinalizado>();
            EncuentroFinalizado encuentroFinalizado = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                int golesFavor = 0;
                MySqlCommand cmd = new MySqlCommand("obtenerCompetencia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_anio", anio);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    encuentroFinalizado = new EncuentroFinalizado();
                    encuentroFinalizado.Id= Convert.ToInt32(reader["id_partidoFinalizado"].ToString());
                    encuentroFinalizado.IdEquipo= Convert.ToInt32(reader["idEquipo"].ToString());
                    encuentroFinalizado.IdEncuentroDefinido= Convert.ToInt32(reader["idDefinido"].ToString());
                    encuentroFinalizado.GolesFavor= Convert.ToInt32(reader["golesAFavor"].ToString());
                    encuentroFinalizado.GolesContra = Convert.ToInt32(reader["golesEnContra"].ToString());
                    encuentroFinalizado.GolesDiferencia = Convert.ToInt32(reader["golesDeDiferencia"].ToString());
                    encuentroFinalizado.Puntos= Convert.ToInt32(reader["puntosTotales"].ToString());
                    posiciones.Add(encuentroFinalizado);
                }
                
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return posiciones;
        }
    }
}
