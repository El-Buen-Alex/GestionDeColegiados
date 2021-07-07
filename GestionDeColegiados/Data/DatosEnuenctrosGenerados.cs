using Model;
using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatosEnuenctrosGenerados
    {
        private MySqlConnection conexion = null;
        private MySqlTransaction transaccion = null;

        /*
         
            try
            {
                MySqlCommand cmd = new MySqlCommand("guardarJuezCentral", conexion, trans);
               /* cmd.CommandType = Comma ndType.StoredProcedure;

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
return id;*/


        public void GuardarEncuentrosGenerados(List<EncuentroGenerado> listaEncuentrosGenerados)
        {
            int id = 0;
            conexion= ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {

            }
            Console.WriteLine("Tamanio:" + listaEncuentrosGenerados.Count());
        }
    }
}
