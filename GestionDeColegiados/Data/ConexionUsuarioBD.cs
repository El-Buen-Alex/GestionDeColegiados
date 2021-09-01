using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Data;

namespace Model
{
    public class ConexionUsuarioBD
    {
        //variables necesarias para leer y realizar consultas con exitos de la base de datos
        private MySqlDataReader reader;
        private MySqlConnection conexion;
        private MySqlTransaction transaccion = null;

        //metodo que nos devuelve el administrador creado, si es que el mismo existe
        public Administrador ExisteUsuario(string usuario, string pass)
        {
            //obtenemos la conexion
            conexion = ConexionBD.getConexion();
            // abrimos la conexion
            conexion.Open();

            //llamamos al procedimiento almacenado creado

            MySqlCommand comando = new MySqlCommand("login", conexion);
            //informamos que el comando a enviar es un procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            /*
             * Aqui enviamos los parametros necesarios para el procedimiento almacenado
             *  el primer parametro es el nombre del campo en el procedimiento almacenadi
             *  el segundo parametro es la variable que contiene el valor para el campo
             */
            comando.Parameters.AddWithValue("@_username", usuario);
            comando.Parameters.AddWithValue("@_pass", pass);
            //ejecutamos dicho procedimiento
            reader = comando.ExecuteReader();
            // declaramos un administrador como null 
            Administrador administrador = null;
            //si la consulta es real entonces procedemos a instanciar dicho administrador
            if (reader.Read())
            {
                administrador = new Administrador();
                administrador.Id = int.Parse(reader["Id"].ToString());
                administrador.Nombre = reader["UserName"].ToString();
                administrador.Password = reader["UserPassword"].ToString();
                administrador.Rol= reader["rol"].ToString();
                administrador.PrimerAcceso = reader["primerAcceso"].ToString();
            }
            //cerramos la conexion
            conexion.Close();
            //finalmente lo retornamos
            return administrador;
        }

        public string CambiarPassword(string newPass, int idUser)
        {
            string respuesta = "";
            conexion = ConexionBD.getConexion();
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand("cambiarPass", conexion, transaccion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_newPass", newPass);
                cmd.Parameters.AddWithValue("@_idUser", idUser);
                cmd.Parameters.AddWithValue("@_primerAcceso", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                transaccion.Commit();

                respuesta = "EXITO: Cambio de contraseña exitoso";

            }
            catch (MySqlException ex)
            {
                transaccion.Rollback();
                respuesta = "ERROR: Cambio de contraseña no exitoso";
                throw new Exception(ex.ToString());
                
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

    }
}
