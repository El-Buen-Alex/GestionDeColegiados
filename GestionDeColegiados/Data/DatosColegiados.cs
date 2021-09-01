using Model;
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
        
        //Guardar Juez Central 
        public int InsertarJuezCentral(JuezCentral juezCentral)
        {
            int id = 0;
            conexion = ConexionBD.getConexion(); //Obtener conexión
            conexion.Open();                     //Abrir conexión
            trans = conexion.BeginTransaction(); //Comenzar transaccion
            try
            {
                //Inicializa una nueva instancia de la clase MySqlCommand con el texto de la consulta, MySqlConnection y MySqlTransaction
                MySqlCommand cmd = new MySqlCommand("guardarJuezCentral", conexion, trans);
                
                //Comando para decirle que lo que ejecutar es un procedimiento
                cmd.CommandType = CommandType.StoredProcedure;                              

                //Añade los valores del procedimiento a los atributos de la clase JuezCentral
                cmd.Parameters.AddWithValue("@_cedula", juezCentral.Cedula);
                cmd.Parameters.AddWithValue("@_nombre", juezCentral.Nombre);
                cmd.Parameters.AddWithValue("@_apellido", juezCentral.Apellidos);
                cmd.Parameters.AddWithValue("@_domicilio", juezCentral.Domicilio);
                cmd.Parameters.AddWithValue("@_email", juezCentral.Email);
                cmd.Parameters.AddWithValue("@_telefono", juezCentral.Telefono);

                //Ejecuta el procedimiento
                cmd.ExecuteNonQuery();

                //Obtener ID de la ultima sentencia que se ejecutó
                cmd = new MySqlCommand("obtenerId", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //Convertir lo obtenido a entero
                id = Convert.ToInt32(cmd.ExecuteScalar());

                trans.Commit();
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new falloBDException(ex.Message);
            }
            conexion.Close(); //Cerrar conexión
            return id;
        }


        public int InsertarAsistente1(Asistente asistente1)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
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
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return id;
        }

        public int InsertarAsistente2(Asistente asistente2)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
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
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return id;
        }

        public int InsertarCuartoArbitro(CuartoArbitro cuartoArbitro)
        {
            int id = 0;
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
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
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return id;
        }


        public void InsertarColegiado(Colegiado colegiado)
        {
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
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
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                throw new falloBDException(ex.Message);
            }
            conexion.Close();//Cerrar conexión
        }

        public List<int> consultarIdColegiado () {
            List<int> listaIdColegiado = new List<int>(); //Crear lista
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerIdColegiado", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    int id = Convert.ToInt32(reader["idcolegiado"].ToString());
                    listaIdColegiado.Add(id);
                }
            } catch (MySqlException ex) {
                listaIdColegiado = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaIdColegiado;
        }

        public List<JuezCentral> consultarJuezCentral (int id) {
            List<JuezCentral> listaArbitro = new List<JuezCentral>(); //Crear lista
            JuezCentral arbitro = null;
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerJuezCentral", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", id);
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    arbitro = new JuezCentral();
                    arbitro.Cedula = reader["cedula"].ToString();
                    arbitro.Nombre = reader["nombre"].ToString();
                    arbitro.Apellidos = reader["apellido"].ToString();
                    arbitro.Domicilio = reader["domicilio"].ToString();
                    arbitro.Email = reader["email"].ToString();
                    arbitro.Telefono = reader["telefono"].ToString();
                    listaArbitro.Add(arbitro);
                }
            } catch (MySqlException ex) {
                listaArbitro = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaArbitro;
        }

        public List<Asistente> consultarAsistente (int id, string procedimiento){
            List<Asistente> listaAsistente = new List<Asistente>();
            Asistente asistente = null;
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", id);
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    asistente = new Asistente();
                    asistente.Cedula = reader["cedula"].ToString();
                    asistente.Nombre = reader["nombre"].ToString();
                    asistente.Apellidos = reader["apellido"].ToString();
                    asistente.Domicilio = reader["domicilio"].ToString();
                    asistente.Email = reader["email"].ToString();
                    asistente.Telefono = reader["telefono"].ToString();
                    listaAsistente.Add(asistente);
                }
            } catch (MySqlException ex) {
                listaAsistente = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaAsistente;
        }

        public List<Asistente> consultarAsistente1 (int id) {
            List<Asistente> listaAsistente1 = new List<Asistente>();
            listaAsistente1 = consultarAsistente(id, "obtenerAsistente1");
            return listaAsistente1;
        }

        public List<Asistente> consultarAsistente2 (int id) {
            List<Asistente> listaAsistente1 = new List<Asistente>();
            listaAsistente1 = consultarAsistente(id, "obtenerAsistente2");
            return listaAsistente1;
        }


        public List<CuartoArbitro> consultarCuartoArbitro (int id) {
            List<CuartoArbitro> listaCA = new List<CuartoArbitro>(); //Crear lista
            CuartoArbitro arbitro = null;
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerCuartoArbitro", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", id);
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    arbitro = new CuartoArbitro();
                    arbitro.Cedula = reader["cedula"].ToString();
                    arbitro.Nombre = reader["nombre"].ToString();
                    arbitro.Apellidos = reader["apellido"].ToString();
                    arbitro.Domicilio = reader["domicilio"].ToString();
                    arbitro.Email = reader["email"].ToString();
                    arbitro.Telefono = reader["telefono"].ToString();
                    listaCA.Add(arbitro);
                }
            } catch (MySqlException ex) {
                listaCA = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaCA;
        }

        public List<IntegrantesColegiados> ConsultarColegiado()
        {
            List<IntegrantesColegiados> listaColegiado = new List<IntegrantesColegiados>(); //Crear lista
            IntegrantesColegiados integrantesColeg = null;      //Instanciar clase IntegrantesColegiados
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try
            {
                MySqlCommand comando = new MySqlCommand("obtenerColegiado", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
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
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaColegiado;
        }

        public List<IntegrantesColegiados> ConsultarCedulaColegiado () {
            List<IntegrantesColegiados> listaColegiado = new List<IntegrantesColegiados>();
            IntegrantesColegiados integrantesColeg = null;
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerCedulaColegiado", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    integrantesColeg = new IntegrantesColegiados();
                    integrantesColeg.IdGrupoColegiado = Convert.ToInt32(reader["idGrupoColegiado"].ToString());
                    integrantesColeg.NombrejuezCentral = reader["cedulaJC"].ToString();
                    integrantesColeg.Nombreasistente1 = reader["cedulaAs1"].ToString();
                    integrantesColeg.Nombreasistente2 = reader["cedulaAs2"].ToString();
                    integrantesColeg.NombrecuartoArbitro = reader["cedulaCA"].ToString();
                    listaColegiado.Add(integrantesColeg);
                }
            } catch (MySqlException ex) {
                listaColegiado = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaColegiado;
        }

        public string ObtenerNombreDeColegiados (int idColegiado) {
            string nombres = "";
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerUnColegiado", conexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", idColegiado);
                reader = comando.ExecuteReader();
                if (reader.Read()) {
                    nombres = "Juez Central: " + reader["nombreJC"].ToString() + "\r\n";
                    nombres += "Asistente 1: " + reader["nombreAs1"].ToString() + "\r\n";
                    nombres += "Asistente 2: " + reader["nombreAs2"].ToString() + "\r\n";
                    nombres += "Cuarto Arbitro: " + reader["nombreCA"].ToString();
                }
            } catch (MySqlException ex) {
                Console.WriteLine(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return nombres;
        }

        public List<Colegiado> obtenerTodosIdColegiado (int idColegiado) {
            List<Colegiado> listaIDColegiado = new List<Colegiado>();
            Colegiado colegiado = null;
            MySqlDataReader reader = null;          //tabla virtual
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            try 
            {
                MySqlCommand comando = new MySqlCommand("obtenerTodosIDColegiado", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_idColegiado", idColegiado);
                reader = comando.ExecuteReader();

                //Condición para leer y agregar los arbitros a la lista
                while (reader.Read()) {
                    colegiado = new Colegiado();
                    colegiado.Idcolegiado = Convert.ToInt32(reader["idColegiado"].ToString());
                    colegiado.Idjuezcentral = Convert.ToInt32(reader["idJuezCentral"].ToString());
                    colegiado.Idasistente1 = Convert.ToInt32(reader["idAsistente1"].ToString());
                    colegiado.Idasistente2 = Convert.ToInt32(reader["idAsistente2"].ToString());
                    colegiado.Idcuartoarbitro = Convert.ToInt32(reader["idCuartoArbitro"].ToString());
                    listaIDColegiado.Add(colegiado);
                }
            } 
            catch (MySqlException ex) 
            {
                listaIDColegiado = null;
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
            return listaIDColegiado;
        }

        public void EditarJuezCentralBD (JuezCentral juezCentral) {
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
            try 
            {
                MySqlCommand comando = new MySqlCommand("editarJuezCentral", conexion, trans);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idJuezCentral", juezCentral.IdArbitro);
                comando.Parameters.AddWithValue("@_cedula", juezCentral.Cedula);
                comando.Parameters.AddWithValue("@_nombre", juezCentral.Nombre);
                comando.Parameters.AddWithValue("@_apellido", juezCentral.Apellidos);
                comando.Parameters.AddWithValue("@_domicilio", juezCentral.Domicilio);
                comando.Parameters.AddWithValue("@_email", juezCentral.Email);
                comando.Parameters.AddWithValue("@_telefono", juezCentral.Telefono);

                comando.ExecuteNonQuery();
                trans.Commit();
            }
            catch (MySqlException ex) 
            {
                trans.Rollback();
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
        }

        public void editarAsistenteBD (Asistente asistente, string procedimiento) {
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
            try {
                MySqlCommand comando = new MySqlCommand(procedimiento, conexion, trans);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idAsistente", asistente.IdArbitro);
                comando.Parameters.AddWithValue("@_cedula", asistente.Cedula);
                comando.Parameters.AddWithValue("@_nombre", asistente.Nombre);
                comando.Parameters.AddWithValue("@_apellido", asistente.Apellidos);
                comando.Parameters.AddWithValue("@_domicilio", asistente.Domicilio);
                comando.Parameters.AddWithValue("@_email", asistente.Email);
                comando.Parameters.AddWithValue("@_telefono", asistente.Telefono);

                comando.ExecuteNonQuery();
                trans.Commit();
            } catch (MySqlException ex) {
                trans.Rollback();
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
        }

        public void editarAsistente1BD (Asistente asistente1) {
            string procedimiento = "editarAsistente1";
            editarAsistenteBD(asistente1,procedimiento);
        }

        public void editarAsistente2BD (Asistente asistente2) {
            string procedimiento = "editarAsistente2";
            editarAsistenteBD(asistente2, procedimiento);
        }

        public void editarCuartoArbitro (CuartoArbitro cuartoArbitro) {
            conexion = ConexionBD.getConexion();    //Obtener conexión
            conexion.Open();                        //Abrir conexión
            trans = conexion.BeginTransaction();    //Comenzar transaccion
            try {
                MySqlCommand comando = new MySqlCommand("editarCuartoArbitro", conexion, trans);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idCuartoArbitro", cuartoArbitro.IdArbitro);
                comando.Parameters.AddWithValue("@_cedula", cuartoArbitro.Cedula);
                comando.Parameters.AddWithValue("@_nombre", cuartoArbitro.Nombre);
                comando.Parameters.AddWithValue("@_apellido", cuartoArbitro.Apellidos);
                comando.Parameters.AddWithValue("@_domicilio", cuartoArbitro.Domicilio);
                comando.Parameters.AddWithValue("@_email", cuartoArbitro.Email);
                comando.Parameters.AddWithValue("@_telefono", cuartoArbitro.Telefono);

                comando.ExecuteNonQuery();
                trans.Commit();
            } catch (MySqlException ex) {
                trans.Rollback();
                throw new falloBDException(ex.Message);
            }
            conexion.Close();   //Cerrar conexión
        }
    }
}