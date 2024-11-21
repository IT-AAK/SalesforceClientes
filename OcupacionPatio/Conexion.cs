using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Clientes
{
    internal class Conexion
    {

        public SqlConnection conn;
        private string datosConexion;
        private SqlCommand cmd;
        private SqlDataReader resultado;
        private SqlDataAdapter da;
        DataTable dt;
        string sql = "";

        public Dictionary<string, string> datosServidor = new Dictionary<string, string>()
        {
                {"servidor", "DESAFIVE-MOR-MX"},
                {"userId", "Consultas"},
                {"password","Consultas"},
                {"bd","Clientes_Test"}
        };

        public void actualizarDatos(string bd)
        {
            if (datosServidor.ContainsKey("bd"))
            {
                datosServidor["bd"] = bd;
            }

            datosConexion = "Data Source = " + datosServidor["servidor"] + ";" + "user id = " + datosServidor["userId"] + ";" + "password= " + datosServidor["password"] + ";" + "Initial Catalog = " + bd + ";";
        }


        public Conexion()
        {
            datosConexion = "Data Source = " + datosServidor["servidor"] + ";" + "user id = " + datosServidor["userId"] + ";" + "password= " + datosServidor["password"] + ";" + "Initial Catalog = " + datosServidor["bd"] + ";";
            conn = new SqlConnection(datosConexion);
        }

        public void abrirConexion()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion establecida con esta bd:" + datosServidor["bd"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer la conexion: " + ex.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conn.Close();
                //MessageBox.Show("Conexion Cerrada");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion aun abierta: " + ex.Message);
            }
        }

        public void cargardatos(DataGridView dgv, SqlCommand cmd)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la consulta: " + ex.Message);
            }
        }

        //Pantalla Proveedores
        public SqlCommand visualizarDatosVendor(int operacion, string name, string rfc, string status, string kind, string notification)
        {
            SqlCommand cmd = new SqlCommand("zSP_Clientes", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@RFC", rfc);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Kind", kind);
            cmd.Parameters.AddWithValue("@Kind2", "");
            cmd.Parameters.AddWithValue("@Kind3", "");
            cmd.Parameters.AddWithValue("@Kind4", "");
            cmd.Parameters.AddWithValue("@Email", "");
            cmd.Parameters.AddWithValue("@Notification", notification);
            cmd.Parameters.AddWithValue("@FechaCita", "");
            cmd.Parameters.AddWithValue("@subject", "");
            cmd.Parameters.AddWithValue("@title", "");
            cmd.Parameters.AddWithValue("@subtitle", "");
            cmd.Parameters.AddWithValue("@body", "");

            return cmd;
        }

        public void FiltrarPorNombreProveedor(string nombreProveedor, DataGridView dvg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("zSP_Clientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregamos el parámetro del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Name", "%" + nombreProveedor + "%");
                cmd.Parameters.AddWithValue("@tynOperacion", 2);
                // Se agregan los parámetros para evitar error en la base de datos
                cmd.Parameters.AddWithValue("@RFC", "");
                cmd.Parameters.AddWithValue("@Status", "");
                cmd.Parameters.AddWithValue("@Kind", "");
                cmd.Parameters.AddWithValue("@Kind2", "");
                cmd.Parameters.AddWithValue("@Kind3", "");
                cmd.Parameters.AddWithValue("@Kind4", "");
                cmd.Parameters.AddWithValue("@Email", "");
                cmd.Parameters.AddWithValue("@Notification", "");
                cmd.Parameters.AddWithValue("@FechaCita", "");
                cmd.Parameters.AddWithValue("@subject", "");
                cmd.Parameters.AddWithValue("@title", "");
                cmd.Parameters.AddWithValue("@subtitle", "");
                cmd.Parameters.AddWithValue("@body", "");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dvg.DataSource = dt;
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de excepciones específicas de SQL
                MessageBox.Show("Ocurrió un error con la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        //Busqueda dinamica por el RFC
        public void FiltrarPorRFC(string rfcProveedor, DataGridView dvg)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Agregamos el párametro del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@RFC", "%" + rfcProveedor + "%");
                    cmd.Parameters.AddWithValue("@tynOperacion", 3);
                    //Se agregan los párametros para evitar error en la base de datos
                    cmd.Parameters.AddWithValue("@Name", "");
                    cmd.Parameters.AddWithValue("@Status", "");
                    cmd.Parameters.AddWithValue("@Kind", "");
                    cmd.Parameters.AddWithValue("@Kind2", "");
                    cmd.Parameters.AddWithValue("@Kind3", "");
                    cmd.Parameters.AddWithValue("@Kind4", "");
                    cmd.Parameters.AddWithValue("@Email", "");
                    cmd.Parameters.AddWithValue("@Notification", "");
                    cmd.Parameters.AddWithValue("@FechaCita", "");
                    cmd.Parameters.AddWithValue("@subject", "");
                    cmd.Parameters.AddWithValue("@title", "");
                    cmd.Parameters.AddWithValue("@subtitle", "");
                    cmd.Parameters.AddWithValue("@body", "");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dvg.DataSource = dt;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de excepciones específicas de SQL
                MessageBox.Show("Ocurrió un error con la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }


        public void InsertVendor(string name, string rfc, string status, string kind, string kind2, string kind3, string kind4)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    // Configurar los parámetros del comando
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RFC", rfc);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Kind", kind);
                    cmd.Parameters.AddWithValue("@Kind2", kind2);
                    cmd.Parameters.AddWithValue("@Kind3", kind3);
                    cmd.Parameters.AddWithValue("@Kind4", kind4);
                    cmd.Parameters.AddWithValue("@Email", "");
                    cmd.Parameters.AddWithValue("@Notification", 0);
                    cmd.Parameters.AddWithValue("@tynOperacion", 4);
                    cmd.Parameters.AddWithValue("@FechaCita", "");
                    cmd.Parameters.AddWithValue("@subject", "");
                    cmd.Parameters.AddWithValue("@title", "");
                    cmd.Parameters.AddWithValue("@subtitle", "");
                    cmd.Parameters.AddWithValue("@body", "");

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Se agregó exitosamente.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        //Fin Pantalla Proveedores


        //Pantalla Inicio
        public SqlCommand VisualizarOcipacionPatio(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_Clientes", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@RFC", "");
            cmd.Parameters.AddWithValue("@Status", "");
            cmd.Parameters.AddWithValue("@Kind", "");
            cmd.Parameters.AddWithValue("@Kind2", "");
            cmd.Parameters.AddWithValue("@Kind3", "");
            cmd.Parameters.AddWithValue("@Kind4", "");
            cmd.Parameters.AddWithValue("@Email", "");
            cmd.Parameters.AddWithValue("@Notification", "");
            cmd.Parameters.AddWithValue("@FechaCita", "");
            cmd.Parameters.AddWithValue("@subject", "");
            cmd.Parameters.AddWithValue("@title", "");
            cmd.Parameters.AddWithValue("@subtitle", "");
            cmd.Parameters.AddWithValue("@body", "");


            return cmd;
        }

        public void InsertRegistroEnvioCorreo(string name, string rfc, string kindValue, string email)
        {
            string datosConexion2 = "Data Source = " + datosServidor["servidor"] + ";" + "user id = " + datosServidor["userId"] + ";" + "password= " + datosServidor["password"] + ";" + "Initial Catalog = " + datosServidor["bd"] + ";";
            SqlConnection conn2 = new SqlConnection(datosConexion2);

            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn2))
                {
                    conn2.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RFC", rfc);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FechaCita", ""); 
                    cmd.Parameters.AddWithValue("@Status", "");    
                    cmd.Parameters.AddWithValue("@Kind", kindValue);
                    cmd.Parameters.AddWithValue("@Kind2", "");
                    cmd.Parameters.AddWithValue("@Kind3", "");
                    cmd.Parameters.AddWithValue("@Kind4", "");
                    cmd.Parameters.AddWithValue("@Notification", "");
                    cmd.Parameters.AddWithValue("@subject", "");
                    cmd.Parameters.AddWithValue("@title", "");
                    cmd.Parameters.AddWithValue("@subtitle", "");
                    cmd.Parameters.AddWithValue("@body", "");
                    cmd.Parameters.AddWithValue("@tynOperacion", 9);

                    cmd.ExecuteNonQuery();

                    conn2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar registro de correo: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }

        }

        public SqlCommand VisualizarEmail(int operacion)
        {
            string datosConexion2 = "Data Source = " + datosServidor["servidor"] + ";" + "user id = " + datosServidor["userId"] + ";" + "password= " + datosServidor["password"] + ";" + "Initial Catalog = " + datosServidor["bd"] + ";";
            SqlConnection conn2 = new SqlConnection(datosConexion2);

            try
            {
                SqlCommand cmd = new SqlCommand("zSP_Clientes", conn2)
                {
                    CommandType = CommandType.StoredProcedure
                };
                conn2.Open();
                cmd.Parameters.AddWithValue("@Name", "");
                cmd.Parameters.AddWithValue("@RFC", "");
                cmd.Parameters.AddWithValue("@Email", "");
                cmd.Parameters.AddWithValue("@FechaCita", "");
                cmd.Parameters.AddWithValue("@Status", "");
                cmd.Parameters.AddWithValue("@Kind", "");
                cmd.Parameters.AddWithValue("@Kind2", "");
                cmd.Parameters.AddWithValue("@Kind3", "");
                cmd.Parameters.AddWithValue("@Kind4", "");
                cmd.Parameters.AddWithValue("@Notification", "");
                cmd.Parameters.AddWithValue("@subject", "");
                cmd.Parameters.AddWithValue("@title", "");
                cmd.Parameters.AddWithValue("@subtitle", "");
                cmd.Parameters.AddWithValue("@body", "");
                cmd.Parameters.AddWithValue("@tynOperacion", 10);

                return cmd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al visualizar email: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                return null;
            }
        }
        //Fin Pantalla Inicio


        //Pantalla Citas
        public SqlCommand ListaProveedores(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_Clientes", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@RFC", "");
            cmd.Parameters.AddWithValue("@Status", "");
            cmd.Parameters.AddWithValue("@Kind", "");
            cmd.Parameters.AddWithValue("@Kind2", "");
            cmd.Parameters.AddWithValue("@Kind3", "");
            cmd.Parameters.AddWithValue("@Kind4", "");
            cmd.Parameters.AddWithValue("@Email", "");
            cmd.Parameters.AddWithValue("@Notification", "");
            cmd.Parameters.AddWithValue("@FechaCita", "");
            cmd.Parameters.AddWithValue("@subject", "");
            cmd.Parameters.AddWithValue("@title", "");
            cmd.Parameters.AddWithValue("@subtitle", "");
            cmd.Parameters.AddWithValue("@body", "");


            return cmd;
        }

        public SqlCommand VisualizarProveedores(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_Clientes", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@Name", "");
            cmd.Parameters.AddWithValue("@RFC", "");
            cmd.Parameters.AddWithValue("@Status", "");
            cmd.Parameters.AddWithValue("@Kind", "");
            cmd.Parameters.AddWithValue("@Kind2", "");
            cmd.Parameters.AddWithValue("@Kind3", "");
            cmd.Parameters.AddWithValue("@Kind4", "");
            cmd.Parameters.AddWithValue("@Email", "");
            cmd.Parameters.AddWithValue("@Notification", "");
            cmd.Parameters.AddWithValue("@FechaCita", "");
            cmd.Parameters.AddWithValue("@subject", "");
            cmd.Parameters.AddWithValue("@title", "");
            cmd.Parameters.AddWithValue("@subtitle", "");
            cmd.Parameters.AddWithValue("@body", "");


            return cmd;
        }

        public void InsertCita(string name, string rfc, string email, DateTime FechaCita)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    // Configurar los parámetros del comando
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@RFC", rfc);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
                    cmd.Parameters.AddWithValue("@Status", "");
                    cmd.Parameters.AddWithValue("@Kind", "");
                    cmd.Parameters.AddWithValue("@Kind2", "");
                    cmd.Parameters.AddWithValue("@Kind3", "");
                    cmd.Parameters.AddWithValue("@Kind4", "");
                    cmd.Parameters.AddWithValue("@Notification", "");
                    cmd.Parameters.AddWithValue("@subject", "");
                    cmd.Parameters.AddWithValue("@title", "");
                    cmd.Parameters.AddWithValue("@subtitle", "");
                    cmd.Parameters.AddWithValue("@body", "");
                    cmd.Parameters.AddWithValue("@tynOperacion", 8);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Se agregó exitosamente.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Cuerpo Correo
        //public SqlCommand VisualizarCuerpoCorreo(int operacion)
        //{
        //    SqlCommand cmd = new SqlCommand("zSP_Clientes", conn)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };

        //    cmd.Parameters.AddWithValue("@tynOperacion", operacion);
        //    cmd.Parameters.AddWithValue("@Name", "");
        //    cmd.Parameters.AddWithValue("@RFC", "");
        //    cmd.Parameters.AddWithValue("@Status", "");
        //    cmd.Parameters.AddWithValue("@Kind", "");
        //    cmd.Parameters.AddWithValue("@Email", "");
        //    cmd.Parameters.AddWithValue("@Notification", "");
        //    cmd.Parameters.AddWithValue("@FechaCita", "");
        //    cmd.Parameters.AddWithValue("@subject", "");
        //    cmd.Parameters.AddWithValue("@title", "");
        //    cmd.Parameters.AddWithValue("@subtitle", "");
        //    cmd.Parameters.AddWithValue("@body", "");


        //    return cmd;
        //}

        public void UpdateCuerpoCorreo(string subject, string title, string subtitle, string body)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    // Configurar los parámetros del comando
                    cmd.Parameters.AddWithValue("@Name", "");
                    cmd.Parameters.AddWithValue("@RFC", "");
                    cmd.Parameters.AddWithValue("@Email", "");
                    cmd.Parameters.AddWithValue("@FechaCita", "");
                    cmd.Parameters.AddWithValue("@Status", "");
                    cmd.Parameters.AddWithValue("@Kind", "");
                    cmd.Parameters.AddWithValue("@Kind2", "");
                    cmd.Parameters.AddWithValue("@Kind3", "");
                    cmd.Parameters.AddWithValue("@Kind4", "");
                    cmd.Parameters.AddWithValue("@Notification", "");
                    cmd.Parameters.AddWithValue("@subject", subject);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@subtitle", subtitle);
                    cmd.Parameters.AddWithValue("@body", body);
                    cmd.Parameters.AddWithValue("@tynOperacion", 11);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Se actualizó exitosamente.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
















    }
}
