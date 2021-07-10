using Model.Colegiados;
using Model.Equipo;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class DatosEquipos
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;
        public Equipo ObtenerEquipoPorId(int id)
        {
            Equipo equipo = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerEquipo", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_equipoID", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    equipo = new Equipo();
                    equipo.NombreEquipo = reader["nombre"].ToString();
                    equipo.IdEquipo = Convert.ToInt32(reader["idequipo"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return equipo;
        }
        public int InsertarEquipo(Equipo equipo)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarEquipo", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_nombre", equipo.NombreEquipo);
                cmd.Parameters.AddWithValue("@_numero_jugadores", equipo.NumeroJugadores);
                cmd.Parameters.AddWithValue("@_nombre_director_tecnico", equipo.NombreDirectoTecnico);
                cmd.Parameters.AddWithValue("@_presidente_equipo", equipo.PresidenteEquipo);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("obtenerId", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(cmd.ExecuteScalar());
                trans.Commit();
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return id;
        }
        public int registrarEncuentrosGenerados(string nombreEquipo, string estado, int idEquipo)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarEncuentros", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_idequipo", idEquipo);
                cmd.Parameters.AddWithValue("@_nombre", nombreEquipo);
                cmd.Parameters.AddWithValue("@_estado", estado);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("obtenerId", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(cmd.ExecuteScalar());
                trans.Commit();
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return id;
        }

        public List<Equipo> consultarEquipos()
        {
            List<Equipo> listaEquipo = new List<Equipo>();
            Equipo nombreEquipo = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerNombreEquipo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    nombreEquipo = new Equipo();
                    nombreEquipo.NombreEquipo = reader["nombre"].ToString();
                    nombreEquipo.IdEquipo = Convert.ToInt32(reader["idequipo"].ToString());
                    listaEquipo.Add(nombreEquipo);
                }
            }
            catch (MySqlException ex)
            {
                listaEquipo = null;
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return listaEquipo;
        }
        public int ObtenerCantidadEquipoRegistrados()
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("cantidadEquipos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["cantidadEquipos"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener la cantidad de equipos registrados" + ex.Message);
            }
            conexion.Close();
            return cantidad;
        }

    }
}
