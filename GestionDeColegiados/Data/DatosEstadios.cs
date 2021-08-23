using Model;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class DatosEstadios
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction transaccion = null;

        public List<Estadio> obtenerEstadiosDisponibles()
        {
            List<Estadio> listaEstadios = new List<Estadio>();
            Estadio estadio = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("estadiosDiponibles", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estadio = new Estadio();
                    estadio.Id = Convert.ToInt32(reader["idestadio"].ToString());
                    estadio.Nombre = reader["nombreEstadio"].ToString();
                    estadio.Asignacion = reader["asignacion"].ToString();
                    listaEstadios.Add(estadio);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            conexion.Close();
            return listaEstadios;
        }

        public Estadio ObtenerEstadioPorId(int idEstadio)
        {
            Estadio estadio = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerEstadioPorId", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idEstadio", idEstadio);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    estadio = new Estadio();
                    estadio.Id = Convert.ToInt32(reader["idestadio"].ToString());
                    estadio.Nombre = reader["nombreEstadio"].ToString();
                    estadio.Asignacion = reader["asignacion"].ToString();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            conexion.Close();
            return estadio;
        }

        public bool PutEstadiosDisponibles()
        {
            bool cambio = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("PonerEstadiosDisponibles", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                cambio = true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cambio;
        }

        public bool CambiarEstado(int idEsadio, string estado)
        {
            bool cambio = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("asigacionEstadoEstadio", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_asignacion", estado);
                comando.Parameters.AddWithValue("_idestadio", idEsadio);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                cambio = true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            conexion.Close();
            return cambio;
        }
    }
}
