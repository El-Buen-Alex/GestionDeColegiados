﻿using Model;
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
    public class DatosEnuenctrosGenerados
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction transaccion = null;
        public bool GuardarEncuentrosGenerados(List<EncuentroGenerado> listaEncuentrosGenerados)
        {
            bool guardo=false;
            conexion= ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                foreach(EncuentroGenerado encuentroGenerado in listaEncuentrosGenerados)
                {
                    MySqlCommand cmd = new MySqlCommand("guardarEncuentrosGenerados", conexion, transaccion);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@_idEquipoLocal", encuentroGenerado.IdEquipoLocal);
                    cmd.Parameters.AddWithValue("@_idEquipoVisitante", encuentroGenerado.IdEquipoVisitante);
                    cmd.Parameters.AddWithValue("@_estado", encuentroGenerado.Estado);
                    cmd.ExecuteNonQuery();
                    guardo = true;
                    Console.WriteLine("guarda");
                }
            }catch(MySqlException ex)
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

        public int ObetnerNumeroEncuentrosPendientes()
        {
            int cantidad = 0;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("obtenerNumeroEncuentroDisponible", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cantidad = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener cantidad de encuentros pendientes: " + ex.Message);
            }
            return cantidad;
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
                cmd.Parameters.AddWithValue("@_estado", "Por Jugar");
                cmd.Parameters.AddWithValue("@_idencuentro", idEncuentroGeneradoPendiente);
                cmd.ExecuteNonQuery();
                cambio = true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                Console.WriteLine("hola entre a encuentros pendt");
                while (reader.Read())
                {
                    encuentroGeneradoPendiente = new EncuentroGenerado();
                    encuentroGeneradoPendiente.Id=Convert.ToInt32(reader["idencuentro"].ToString());
                    encuentroGeneradoPendiente.IdEquipoLocal= Convert.ToInt32(reader["idEquipoLocal"].ToString());
                    encuentroGeneradoPendiente.IdEquipoVisitante= Convert.ToInt32(reader["idEquipoVisitante"].ToString());
                    encuentroGeneradoPendiente.Estado = reader["estado"].ToString();
                    lista.Add(encuentroGeneradoPendiente);
                    Console.WriteLine(lista.Count);
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error al obtener cantidad de encuentros pendientes: " + ex.Message);
            }
            conexion.Close();
            return lista;
        }
    }
}