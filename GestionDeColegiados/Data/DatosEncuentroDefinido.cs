using Model;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;

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
            try
            {
                MySqlCommand comando = new MySqlCommand("guardarEncuentrosDefinidos", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_fecha", encuentroDefinido.FechaDeEncuentro.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("_hora", encuentroDefinido.Hora.ToString("HH:mm"));
                comando.Parameters.AddWithValue("_idencuentro", encuentroDefinido.IdEncuentroGeneradoPendiente);
                comando.Parameters.AddWithValue("_idcolegiado", encuentroDefinido.IdColegiado);
                comando.Parameters.AddWithValue("_idestadio", encuentroDefinido.IdEstadio);
                comando.ExecuteNonQuery();
                comando = new MySqlCommand("obtenerId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id != 0)
                {
                    transaccion.Commit();
                }
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return id;
        }

        public List<EncuentroDefinido> ObtenerEncuentros()
        {
            List<EncuentroDefinido> lista = new List<EncuentroDefinido>();
            EncuentroDefinido encuentroDefinido = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("mostrarEncuentroDefinidos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    encuentroDefinido = new EncuentroDefinido();
                    encuentroDefinido.Id = Convert.ToInt32(reader["idefinido"].ToString());
                    encuentroDefinido.IdColegiado = Convert.ToInt32(reader["idcolegiado"].ToString());
                    encuentroDefinido.IdEncuentroGeneradoPendiente = Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentroDefinido.IdEstadio = Convert.ToInt32(reader["idestadio"].ToString());
                    encuentroDefinido.Hora = Convert.ToDateTime(reader["hora"].ToString());
                    encuentroDefinido.FechaDeEncuentro = Convert.ToDateTime(reader["fecha"].ToString());
                    lista.Add(encuentroDefinido);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return lista;
        }

        public bool CambiarEstadoEnucentroDefinido(string estado)
        {
            bool respuesta = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("CambiarEstadoEncuentrosDefinidos", conexion, transaccion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_estado", estado[0]);

                cmd.ExecuteNonQuery();

                transaccion.Commit();

                respuesta = true;

            }
            catch (MySqlException ex)
            {
                transaccion.Rollback();

                throw new Exception(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        public List<EncuentroDefinido> GetEncuentrosDefinidosFinalizados(string anio)
        {
            List<EncuentroDefinido> lista = new List<EncuentroDefinido>();
            EncuentroDefinido encuentroDefinido = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("encuentrosDefinidosEncuentrosFinalizados", conexion, transaccion);
                comando.Parameters.AddWithValue("_copa", anio);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    encuentroDefinido = new EncuentroDefinido();
                    encuentroDefinido.Id = Convert.ToInt32(reader["idefinido"].ToString());
                    encuentroDefinido.IdColegiado = Convert.ToInt32(reader["idcolegiado"].ToString());
                    encuentroDefinido.IdEncuentroGeneradoPendiente = Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentroDefinido.IdEstadio = Convert.ToInt32(reader["idestadio"].ToString());
                    encuentroDefinido.Hora = Convert.ToDateTime(reader["hora"].ToString());
                    encuentroDefinido.FechaDeEncuentro = Convert.ToDateTime(reader["fecha"].ToString());
                    lista.Add(encuentroDefinido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public int ObtenerCantidadEncuentrosDefinidos()
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("cantidadEncuentrosDefinidosActivos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["cantidadEncuentrosActivos"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cantidad;
        }

        public bool ActualizarEstadioDePartido(int idEncuentroPorActualizar, int idNuevoEstadioAsociado)
        {
            bool exito = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("actulizarEstadioAsociado", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idencuentro", idEncuentroPorActualizar);
                comando.Parameters.AddWithValue("@_idEstadio", idNuevoEstadioAsociado);
                comando.ExecuteNonQuery();
                exito = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return exito;
        }

        public int ObtenerCantidadEncuentrosPorJugar()
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("cantidadEncuentrosPorJugar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["cantidadEncuentros"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return cantidad;
        }

        public bool ActualizarFechaHoraDEPartido(int id,DateTime fecha, DateTime hora, int idColegiado)
        {
            bool exito = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand("actulizarFechaHoraColegiadoEncuentroDefinido", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idefinido", id);
                comando.Parameters.AddWithValue("@_fecha", fecha.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@_hora", hora.ToString("HH:mm"));
                comando.Parameters.AddWithValue("@_idColegiado", idColegiado);
                comando.ExecuteNonQuery();
                exito = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                exito = false;
            }
            finally
            {
                conexion.Close();
            }
            return exito;
        }
    }
}
