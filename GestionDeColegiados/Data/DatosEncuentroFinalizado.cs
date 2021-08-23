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

        public bool FinalizarCompetencia(string anio, string estado)
        {
            bool respuesta = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("finalizarCompetencia", conexion, trans);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_copa", anio);
                cmd.Parameters.AddWithValue("_estado", estado[0]);
                cmd.ExecuteNonQuery();

                trans.Commit();

                respuesta = true;
               
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
            return respuesta;
        }

        public List<EncuentroFinalizado> GetEncuentrosFinalizados(string anio)
        {
            List<EncuentroFinalizado> posiciones = new List<EncuentroFinalizado>();
            EncuentroFinalizado encuentroFinalizado = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
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

        public EncuentroFinalizado GetEncuentroFinalizadoByIDefinidoEquipo(int idDefinido, int idEquipoLocal)
        {
            EncuentroFinalizado encuentroFinalizado = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerEncuentroFinalizadoById", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idDefinido", idDefinido);
                cmd.Parameters.AddWithValue("_idEquipo", idEquipoLocal);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    encuentroFinalizado = new EncuentroFinalizado();
                    encuentroFinalizado.Id = Convert.ToInt32(reader["id_partidoFinalizado"].ToString());
                    encuentroFinalizado.IdEquipo = Convert.ToInt32(reader["idEquipo"].ToString());
                    encuentroFinalizado.IdEncuentroDefinido = Convert.ToInt32(reader["idDefinido"].ToString());
                    encuentroFinalizado.GolesFavor = Convert.ToInt32(reader["golesFavor"].ToString());
                    encuentroFinalizado.GolesContra = Convert.ToInt32(reader["golesContra"].ToString());
                    encuentroFinalizado.GolesDiferencia = Convert.ToInt32(reader["golesDiferencia"].ToString());
                    encuentroFinalizado.Puntos = Convert.ToInt32(reader["puntos"].ToString());
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
            return encuentroFinalizado;
        }

        public bool UpdateEncuentroFinalizado(EncuentroFinalizado encuentroResultado)
        {
            bool respuesta = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("actulizarEncuentroFinalizado", conexion, trans);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idDefinido", encuentroResultado.IdEncuentroDefinido);
                comando.Parameters.AddWithValue("@_idEquipo", encuentroResultado.IdEquipo);
                comando.Parameters.AddWithValue("@_golFavor", encuentroResultado.GolesFavor);
                comando.Parameters.AddWithValue("@_golContra", encuentroResultado.GolesContra);
                comando.Parameters.AddWithValue("@_golDiferencia", encuentroResultado.GolesDiferencia);
                comando.Parameters.AddWithValue("@_puntos", encuentroResultado.Puntos);
                comando.ExecuteNonQuery();
                trans.Commit();
                respuesta = true;
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
           
            return respuesta;
        }

        public int GetCantidadEncuentrosFinalizados(string anio)
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("cantidadEncuentrosFinalizados", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_copa", anio);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["cantidadEncuentros"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cantidad = -1;
            }
            finally
            {
                conexion.Close();
            }
            return cantidad;

        }
    }
}
