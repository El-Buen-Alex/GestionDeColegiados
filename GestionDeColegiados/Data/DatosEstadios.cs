using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using Model;
using Sistema;
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
                    estadio.Estado = reader["estado"].ToString();
                    listaEstadios.Add(estadio);
                    Console.WriteLine(estadio.Id);
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }

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
                    estadio.Estado = reader["estado"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            return estadio;
        }

        public bool CambiarEstado(int idEsadio, string estado)
        {
            bool cambio=false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand comando = new MySqlCommand("asigacionEstadoEstadio", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_estado", estado);
                comando.Parameters.AddWithValue("_idestadio", idEsadio);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                cambio = true;
            }
            catch(MySqlException ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error en la obtencion de estadios disponibles: " + ex.Message);
            }
            conexion.Close();
            return cambio;
        }
    }
}
