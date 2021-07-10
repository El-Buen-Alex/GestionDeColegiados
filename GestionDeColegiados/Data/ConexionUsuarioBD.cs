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

        //metodo que nos devuelve el administrador creado, si es que el mismo existe
        public Administrador ExisteUsuario(string usuario, string pass)
        {
            //obtenemos la conexion
            conexion = ConexionBD.getConexion();
            // abrimos la conexion
            conexion.Open();

            //llamamos al procedimiento almacenado creado

            MySqlCommand comando = new MySqlCommand("loginExample", conexion);
            //informamos que eel comando a enviar es un procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            /*
             * Aqui enviamos los parametros necesarios para el procedimiento almacenado
             *  el primer parametro es el nombre del campo en el procedimiento almacenadi
             *  el segundo parametro es la variable que contiene el valor para el campo
             */
            comando.Parameters.AddWithValue("@username", usuario);
            comando.Parameters.AddWithValue("@pass", pass);
            //ejecutamos dicho procedimiento
            reader = comando.ExecuteReader();
            // declaramos un administrador como null 
            Administrador administrador = null;
            //si la consulta es real entonces procedemos a instanciar dicho administrador
            if (reader.Read())
            {
                administrador = new Administrador();
                administrador.Id = int.Parse(reader["IdAdministradores"].ToString());
                administrador.Nombre = reader["AdminName"].ToString();
                administrador.Password = reader["AdminPassword"].ToString();

            }
            //cerramos la conexion
            conexion.Close();
            //finalmente lo retornamos
            return administrador;
        }
    }
}
