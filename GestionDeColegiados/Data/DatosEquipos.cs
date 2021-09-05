using Model.Colegiados;
using Model.Equipo;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;
/*clase que conecta directamente con los procedimientos que están ejecutados en la base de datos*/
namespace Data
{
    public class DatosEquipos
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;
        /*método encargado de extraer el id del equipo el cual es pasado por parametro en el llamado de este método.
            *Realiza las conexiones hacia la bd, escribe el nombre de la columna en la cual va hacer la busqueda.
            *Una vez los datos cargaos se los almacena en los campos correspondiente de la clase contenedora Equipo el
            *cual se encuentra en Model.
        */
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
        /*Método que permite extraer toda la información de los equipos*/
        public List<Equipo> consultarEquiposTabla()
        {
            List<Equipo> listaEquipo = new List<Equipo>();
            Equipo nombreEquipo = null;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerDatosEquipos", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    nombreEquipo = new Equipo();
                    nombreEquipo.NombreEquipo = reader["nombre"].ToString();
                    nombreEquipo.IdEquipo = Convert.ToInt32(reader["idequipo"].ToString());
                    nombreEquipo.NumeroJugadores = Convert.ToInt32(reader["numero_jugadores"].ToString());
                    nombreEquipo.NombreDirectoTecnico = reader["nombre_director_tecnico"].ToString();
                    nombreEquipo.PresidenteEquipo = reader["presidente_equipo"].ToString();
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
        /*Método que permite editar el estado en la base de datos un registro selecionado*/
        public int EliminarEquipo(string id)
        {
            int identificador = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("eliminarEquipo", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_idEquipo", id);
                cmd.ExecuteNonQuery();
                identificador = 1;
                trans.Commit();
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return identificador;
        }

        /*Método que permite editar en la base de datos un registro selecionado en la tabla de editar equipo*/
        public int EditarEquipo(Equipo equipo)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("editarEquipo", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_idEquipo", equipo.IdEquipo);
                cmd.Parameters.AddWithValue("@_nombre", equipo.NombreEquipo);
                cmd.Parameters.AddWithValue("@_numero_jugadores", equipo.NumeroJugadores);
                cmd.Parameters.AddWithValue("@_nombre_director_tecnico", equipo.NombreDirectoTecnico);
                cmd.Parameters.AddWithValue("@_presidente_equipo", equipo.PresidenteEquipo);
                cmd.ExecuteNonQuery();
                id = 1;
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

        /*Método que tiene la finalidad de almacenar los datos en la bd, donde recibió por parámetros el objeto del cual va a fragmentar la informacion
* para almacenarla. Se escribe el nombre de la columna y la variable que contiene la informacion para así poder registrarla en la bd
* 
*/
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
        /*método encargado de extraer la informacion necesaria para ser presentada según sea nuestro criterio*/
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
        /*Método el cual se comunica con el prcedimiento que nos devolverá la cantidad de equipos registrados en la bd*/
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
