using Model;
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
    }
}
