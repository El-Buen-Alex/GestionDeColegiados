using Model;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class DatosEnuenctrosGenerados
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction transaccion = null;
        public bool GuardarEncuentrosGenerados(List<EncuentroGenerado> listaEncuentrosGenerados)
        {
            bool guardo = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                foreach (EncuentroGenerado encuentroGenerado in listaEncuentrosGenerados)
                {
                    MySqlCommand cmd = new MySqlCommand("guardarEncuentrosGenerados", conexion, transaccion);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@_idEquipoLocal", encuentroGenerado.IdEquipoLocal);
                    cmd.Parameters.AddWithValue("@_idEquipoVisitante", encuentroGenerado.IdEquipoVisitante);
                    cmd.ExecuteNonQuery();
                    guardo = true;
                }
            }
            catch (MySqlException)
            {
                transaccion.Rollback();
                guardo = false;
            }
            if (guardo == true)
            {
                transaccion.Commit();
            }
            conexion.Close();
            return guardo;
        }

        public EncuentroGenerado ObtenerEncuentroPendiente(int idEncuentroGeneradoPendiente)
        {
            EncuentroGenerado encuentro = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerEncuentroPorID", conexion, transaccion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_idencuentro", idEncuentroGeneradoPendiente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    encuentro = new EncuentroGenerado();
                    encuentro.Id = Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentro.IdEquipoLocal = Convert.ToInt32(reader["idEquipoLocal"].ToString());
                    encuentro.IdEquipoVisitante = Convert.ToInt32(reader["idEquipoVisitante"].ToString());
                    encuentro.Estado = reader["estado"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener encuentro pendiente: " + ex.Message);
            }
            conexion.Close();
            return encuentro;
        }

        public int ObetnerNumeroEncuentrosPendientes()
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerNumeroEncuentroPendiente", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["tamanio"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                cantidad = -1;
                Console.WriteLine("Error al obtener cantidad de encuentros pendientes: " + ex.Message);
            }
            conexion.Close();
            return cantidad;
        }

        public bool CambiarEstadoEncuentros(string estado)
        {
            bool respuesta = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("CambiarEstadoEncuentrosGeneradoToN", conexion, transaccion);

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

        public bool CambiarEstadoEncuentro(int idEncuentroGeneradoPendiente)
        {
            bool cambio = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("asigacionEncuentroAsignado", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_idencuentro", idEncuentroGeneradoPendiente);
                cmd.ExecuteNonQuery();
                cambio = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return cambio;
        }

        public List<EncuentroGenerado> ObtenerEncuentrosPendientes()
        {
            List<EncuentroGenerado> lista = new List<EncuentroGenerado>();
            EncuentroGenerado encuentroGeneradoPendiente = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerEncuentroPendiente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    encuentroGeneradoPendiente = new EncuentroGenerado();
                    encuentroGeneradoPendiente.Id = Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentroGeneradoPendiente.IdEquipoLocal = Convert.ToInt32(reader["idEquipoLocal"].ToString());
                    encuentroGeneradoPendiente.IdEquipoVisitante = Convert.ToInt32(reader["idEquipoVisitante"].ToString());
                    encuentroGeneradoPendiente.Estado = reader["estado"].ToString();
                    lista.Add(encuentroGeneradoPendiente);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener cantidad de encuentros pendientes: " + ex.Message);
            }
            conexion.Close();
            return lista;
        }
    }
}
