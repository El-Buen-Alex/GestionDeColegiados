using Model.Colegiados;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data {
    public class Datos {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;

        public int InsertarJuezCentral (JuezCentral juezCentral) {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try {
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
            } catch (MySqlException ex) {
                trans.Rollback();
            }
            conexion.Close();
            return id;
        }

        public int InsertarAsistente1 (Asistente asistente1) {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try {
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
            } catch (MySqlException ex) {
                trans.Rollback();
            }
            conexion.Close();
            return id;
        }

        public int InsertarAsistente2 (Asistente asistente2) {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try {
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
            } catch (MySqlException ex) {
                trans.Rollback();
            }
            conexion.Close();
            return id;
        }

        public int InsertarCuartoArbitro (CuartoArbitro cuartoArbitro) {
            int id = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try {
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
            } catch (MySqlException ex) {
                trans.Rollback();
            }
            conexion.Close();
            return id;
        }


        public bool InsertarColegiado (Colegiado colegiado) {
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            bool msj = false;
            try {
                MySqlCommand cmd = new MySqlCommand("guardarColegiado", conexion, trans);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_idjuezcentral", colegiado.Idjuezcentral);
                cmd.Parameters.AddWithValue("@_idasistente1", colegiado.Idasistente1);
                cmd.Parameters.AddWithValue("@_idasistente2", colegiado.Idasistente2);
                cmd.Parameters.AddWithValue("@_idcuartoarbitro", colegiado.Idcuartoarbitro);

                cmd.ExecuteNonQuery();

                trans.Commit();
                msj = true;
            } catch (MySqlException ex) {
                trans.Rollback();
                msj = false;
            }
            conexion.Close();
            return msj;
        }
    }
}
