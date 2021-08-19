using Model.Partido;
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
    public class DatosEncuentroFinalizado
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction trans = null;

        public bool AddEncuentroFinalizado(EncuentroFinalizado encuentroFinalizado)
        {
            bool guardado = false;
            conexion = ConexionBD.getConexion();
            conexion.Open();
            trans = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("insertarResultadoPartido", conexion, trans);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_idEquipo", encuentroFinalizado.IdEquipo);
                cmd.Parameters.AddWithValue("@_golesFavor", encuentroFinalizado.GolesFavor);
                cmd.Parameters.AddWithValue("@_golesContra", encuentroFinalizado.GolesContra);
                cmd.Parameters.AddWithValue("@_golesDiferencia", encuentroFinalizado.GolesDiferencia);
                cmd.Parameters.AddWithValue("@_puntos",encuentroFinalizado.Puntos);
                cmd.Parameters.AddWithValue("@_copa", DateTime.Now.Year);

                cmd.ExecuteNonQuery();
             
                trans.Commit();

                guardado = true;
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new Exception(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
           
            return guardado;
        }
    }
}
