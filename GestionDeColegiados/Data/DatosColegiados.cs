using Model.Colegiados;
using Model.Equipo;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class DatosColegiados
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;

        public int InsertarJuezCentral(JuezCentral juezCentral)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarJuezCentral", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_cedula", juezCentral.Cedula);
                cmd.Parameters.AddWithValue("@_nombre", juezCentral.Nombre);
                cmd.Parameters.AddWithValue("@_apellido", juezCentral.Apellidos);
                cmd.Parameters.AddWithValue("@_domicilio", juezCentral.Domicilio);
                cmd.Parameters.AddWithValue("@_email", juezCentral.Email);
                cmd.Parameters.AddWithValue("@_telefono", juezCentral.Telefono);

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

        public int InsertarAsistente1(Asistente asistente1)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarAsistente1", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_cedula", asistente1.Cedula);
                cmd.Parameters.AddWithValue("@_nombre", asistente1.Nombre);
                cmd.Parameters.AddWithValue("@_apellido", asistente1.Apellidos);
                cmd.Parameters.AddWithValue("@_domicilio", asistente1.Domicilio);
                cmd.Parameters.AddWithValue("@_email", asistente1.Email);
                cmd.Parameters.AddWithValue("@_telefono", asistente1.Telefono);
                cmd.Parameters.AddWithValue("@_banda", asistente1.Banda);

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

        public int InsertarAsistente2(Asistente asistente2)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarAsistente2", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_cedula", asistente2.Cedula);
                cmd.Parameters.AddWithValue("@_nombre", asistente2.Nombre);
                cmd.Parameters.AddWithValue("@_apellido", asistente2.Apellidos);
                cmd.Parameters.AddWithValue("@_domicilio", asistente2.Domicilio);
                cmd.Parameters.AddWithValue("@_email", asistente2.Email);
                cmd.Parameters.AddWithValue("@_telefono", asistente2.Telefono);
                cmd.Parameters.AddWithValue("@_banda", asistente2.Banda);

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

        public int InsertarCuartoArbitro(CuartoArbitro cuartoArbitro)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarCuartoArbitro", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_cedula", cuartoArbitro.Cedula);
                cmd.Parameters.AddWithValue("@_nombre", cuartoArbitro.Nombre);
                cmd.Parameters.AddWithValue("@_apellido", cuartoArbitro.Apellidos);
                cmd.Parameters.AddWithValue("@_domicilio", cuartoArbitro.Domicilio);
                cmd.Parameters.AddWithValue("@_email", cuartoArbitro.Email);
                cmd.Parameters.AddWithValue("@_telefono", cuartoArbitro.Telefono);
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

        public bool InsertarColegiado(Colegiado colegiado)
        {
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            bool msj = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarColegiado", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_idjuezcentral", colegiado.Idjuezcentral);
                cmd.Parameters.AddWithValue("@_idasistente1", colegiado.Idasistente1);
                cmd.Parameters.AddWithValue("@_idasistente2", colegiado.Idasistente2);
                cmd.Parameters.AddWithValue("@_idcuartoarbitro", colegiado.Idcuartoarbitro);

                cmd.ExecuteNonQuery();

                trans.Commit();
                msj = true;
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                msj = false;
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return msj;
        }

        public string ObtenerNombreDeColegiados(int idColegiado)
        {
            string nombres = "";
            MySqlDataReader reader = null; //tabla virtual
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerUnColegiado", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", idColegiado);
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    nombres = "Juez Central: " + reader["nombreJC"].ToString() + "\r\n";
                    nombres += "Asistente 1: " + reader["nombreAs1"].ToString() + "\r\n";
                    nombres += "Asistente 2: " + reader["nombreAs2"].ToString() + "\r\n";
                    nombres += "Cuarto Arbitro: " + reader["nombreCA"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();
            return nombres;
        }

        public List<IntegrantesColegiados> ConsultarColegiado()
        {
            List<IntegrantesColegiados> listaColegiado = new List<IntegrantesColegiados>();
            IntegrantesColegiados integrantesColeg = null;
            MySqlDataReader reader = null; //tabla virtual
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerColegiado", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    integrantesColeg = new IntegrantesColegiados();
                    integrantesColeg.IdGrupoColegiado = Convert.ToInt32(reader["idGrupoColegiado"].ToString());
                    integrantesColeg.NombrejuezCentral = reader["nombreJC"].ToString();
                    integrantesColeg.Nombreasistente1 = reader["nombreAs1"].ToString();
                    integrantesColeg.Nombreasistente2 = reader["nombreAs2"].ToString();
                    integrantesColeg.NombrecuartoArbitro = reader["nombreCA"].ToString();
                    listaColegiado.Add(integrantesColeg);
                }
            }
            catch (MySqlException ex)
            {
                listaColegiado = null;
                throw new Exception(ex.ToString());
            }
            conexion.Close();
            return listaColegiado;
        }

    }
}
