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
                {"servidor", "ERP-MOR-MX"},
                {"userId", "Consultas"},
                {"password","Consultas"},
                {"bd","AUMXAPPTEST"}
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

        //================================== Pantalla Registro SAPRegGroup =======================================================
        public SqlCommand visualizarDatosClientes(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@CustID", "");
            cmd.Parameters.AddWithValue("@NameCust", "");
            cmd.Parameters.AddWithValue("@SAPRG", "");

            return cmd;
        }

        public SqlCommand visualizarListaSapRegGroup(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);
            cmd.Parameters.AddWithValue("@CustID", "");
            cmd.Parameters.AddWithValue("@NameCust", "");
            cmd.Parameters.AddWithValue("@SAPRG", "");

            return cmd;
        }

        //Busqueda dinamica por el ID
        public void FiltrarPorCustID(string CustID, DataGridView dvg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregamos el parámetro del procedimiento almacenado
                cmd.Parameters.AddWithValue("@tynOperacion", 3);
                cmd.Parameters.AddWithValue("@CustID", "%" + CustID + "%");
                // Se agregan los parámetros para evitar error en la base de datos
                cmd.Parameters.AddWithValue("@NameCust", "");
                cmd.Parameters.AddWithValue("@SAPRG", "");

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

        //Busqueda dinamica por el Nombre
        public void FiltrarPorNombre(string NameCust, DataGridView dvg)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Agregamos el párametro del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@tynOperacion", 4);
                    cmd.Parameters.AddWithValue("@NameCust", "%" + NameCust + "%");
                    // Se agregan los parámetros para evitar error en la base de datos
                    cmd.Parameters.AddWithValue("@CustID", "");
                    cmd.Parameters.AddWithValue("@SAPRG", "");

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

        public bool ValidateInputs(string custID, string NameCust)
        {
            // Verifica si el campo CustID está vacío
            if (string.IsNullOrWhiteSpace(custID))
            {
                MessageBox.Show("El campo ID Cliente del cliente no puede estar vacío.");
                return false;
            }

            // Verifica si el campo NameCust está vacío
            if (string.IsNullOrWhiteSpace(NameCust))
            {
                MessageBox.Show("El campo Nombre Cliente no puede estar vacío.");
                return false;
            }

            // Si ambos campos tienen datos, retorna true
            return true;
        }

        public void InsertSapRegGroup(string custID, string NameCust, string sapRegGroup)
        {
            // Validar que los campos no estén vacíos
            if (!ValidateInputs(custID, NameCust))
            {
                return; // Si la validación falla, no continuar con el insert
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    // Configurar los parámetros del comando
                    cmd.Parameters.AddWithValue("@tynOperacion", 20);
                    cmd.Parameters.AddWithValue("@CustID",custID);
                    cmd.Parameters.AddWithValue("@NameCust", NameCust);
                    cmd.Parameters.AddWithValue("@SAPRG", sapRegGroup);


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


        //================================== Pantalla Consulta SAPRegGroup =======================================================

        //Pantalla Consulta Clientes SAPRegGroup

        public SqlCommand visualizarDatosClientesSRG(int operacion)
        {
            SqlCommand cmd = new SqlCommand("zSP_SapRegGroup", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@tynOperacion", operacion);

            return cmd;
        }

        //public SqlCommand VisualizarOcipacionPatio(int operacion)
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
        //    cmd.Parameters.AddWithValue("@Kind2", "");
        //    cmd.Parameters.AddWithValue("@Kind3", "");
        //    cmd.Parameters.AddWithValue("@Kind4", "");
        //    cmd.Parameters.AddWithValue("@Email", "");
        //    cmd.Parameters.AddWithValue("@Notification", "");
        //    cmd.Parameters.AddWithValue("@FechaCita", "");
        //    cmd.Parameters.AddWithValue("@subject", "");
        //    cmd.Parameters.AddWithValue("@title", "");
        //    cmd.Parameters.AddWithValue("@subtitle", "");
        //    cmd.Parameters.AddWithValue("@body", "");


        //    return cmd;

        //public SqlCommand VisualizarEmail(int operacion)
        //{
        //string datosConexion2 = "Data Source = " + datosServidor["servidor"] + ";" + "user id = " + datosServidor["userId"] + ";" + "password= " + datosServidor["password"] + ";" + "Initial Catalog = " + datosServidor["bd"] + ";";
        //SqlConnection conn2 = new SqlConnection(datosConexion2);

        //try
        //{
        //    SqlCommand cmd = new SqlCommand("zSP_Clientes", conn2)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    conn2.Open();
        //    cmd.Parameters.AddWithValue("@Name", "");
        //    cmd.Parameters.AddWithValue("@RFC", "");
        //    cmd.Parameters.AddWithValue("@Email", "");
        //    cmd.Parameters.AddWithValue("@FechaCita", "");
        //    cmd.Parameters.AddWithValue("@Status", "");
        //    cmd.Parameters.AddWithValue("@Kind", "");
        //    cmd.Parameters.AddWithValue("@Kind2", "");
        //    cmd.Parameters.AddWithValue("@Kind3", "");
        //    cmd.Parameters.AddWithValue("@Kind4", "");
        //    cmd.Parameters.AddWithValue("@Notification", "");
        //    cmd.Parameters.AddWithValue("@subject", "");
        //    cmd.Parameters.AddWithValue("@title", "");
        //    cmd.Parameters.AddWithValue("@subtitle", "");
        //    cmd.Parameters.AddWithValue("@body", "");
        //    cmd.Parameters.AddWithValue("@tynOperacion", 10);

        //    return cmd;
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Error al visualizar email: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
        //    return null;
        //}
        //}
        //Fin Pantalla Inicio


        //Pantalla Citas
        //public SqlCommand ListaProveedores(int operacion)
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
        //    cmd.Parameters.AddWithValue("@Kind2", "");
        //    cmd.Parameters.AddWithValue("@Kind3", "");
        //    cmd.Parameters.AddWithValue("@Kind4", "");
        //    cmd.Parameters.AddWithValue("@Email", "");
        //    cmd.Parameters.AddWithValue("@Notification", "");
        //    cmd.Parameters.AddWithValue("@FechaCita", "");
        //    cmd.Parameters.AddWithValue("@subject", "");
        //    cmd.Parameters.AddWithValue("@title", "");
        //    cmd.Parameters.AddWithValue("@subtitle", "");
        //    cmd.Parameters.AddWithValue("@body", "");


        //    return cmd;
        //}

        //public SqlCommand VisualizarProveedores(int operacion)
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
        //    cmd.Parameters.AddWithValue("@Kind2", "");
        //    cmd.Parameters.AddWithValue("@Kind3", "");
        //    cmd.Parameters.AddWithValue("@Kind4", "");
        //    cmd.Parameters.AddWithValue("@Email", "");
        //    cmd.Parameters.AddWithValue("@Notification", "");
        //    cmd.Parameters.AddWithValue("@FechaCita", "");
        //    cmd.Parameters.AddWithValue("@subject", "");
        //    cmd.Parameters.AddWithValue("@title", "");
        //    cmd.Parameters.AddWithValue("@subtitle", "");
        //    cmd.Parameters.AddWithValue("@body", "");


        //    return cmd;
        //}

        public void InsertCita(string name, string rfc, string email, DateTime FechaCita)
        {
            //try
            //{
            //    using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
            //    {

            //        cmd.CommandType = CommandType.StoredProcedure;
            //        // Configurar los parámetros del comando
            //        cmd.Parameters.AddWithValue("@Name", name);
            //        cmd.Parameters.AddWithValue("@RFC", rfc);
            //        cmd.Parameters.AddWithValue("@Email", email);
            //        cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
            //        cmd.Parameters.AddWithValue("@Status", "");
            //        cmd.Parameters.AddWithValue("@Kind", "");
            //        cmd.Parameters.AddWithValue("@Kind2", "");
            //        cmd.Parameters.AddWithValue("@Kind3", "");
            //        cmd.Parameters.AddWithValue("@Kind4", "");
            //        cmd.Parameters.AddWithValue("@Notification", "");
            //        cmd.Parameters.AddWithValue("@subject", "");
            //        cmd.Parameters.AddWithValue("@title", "");
            //        cmd.Parameters.AddWithValue("@subtitle", "");
            //        cmd.Parameters.AddWithValue("@body", "");
            //        cmd.Parameters.AddWithValue("@tynOperacion", 8);

            //        // Ejecutar el comando
            //        cmd.ExecuteNonQuery();

            //        // Mostrar mensaje de éxito
            //        MessageBox.Show("Se agregó exitosamente.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Manejar cualquier error
            //    MessageBox.Show("Ocurrió un error: " + ex.Message);
            //}
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
            //try
            //{
            //    using (SqlCommand cmd = new SqlCommand("zSP_Clientes", conn))
            //    {

            //        cmd.CommandType = CommandType.StoredProcedure;
            //        // Configurar los parámetros del comando
            //        cmd.Parameters.AddWithValue("@Name", "");
            //        cmd.Parameters.AddWithValue("@RFC", "");
            //        cmd.Parameters.AddWithValue("@Email", "");
            //        cmd.Parameters.AddWithValue("@FechaCita", "");
            //        cmd.Parameters.AddWithValue("@Status", "");
            //        cmd.Parameters.AddWithValue("@Kind", "");
            //        cmd.Parameters.AddWithValue("@Kind2", "");
            //        cmd.Parameters.AddWithValue("@Kind3", "");
            //        cmd.Parameters.AddWithValue("@Kind4", "");
            //        cmd.Parameters.AddWithValue("@Notification", "");
            //        cmd.Parameters.AddWithValue("@subject", subject);
            //        cmd.Parameters.AddWithValue("@title", title);
            //        cmd.Parameters.AddWithValue("@subtitle", subtitle);
            //        cmd.Parameters.AddWithValue("@body", body);
            //        cmd.Parameters.AddWithValue("@tynOperacion", 11);

            //        // Ejecutar el comando
            //        cmd.ExecuteNonQuery();

            //        // Mostrar mensaje de éxito
            //        MessageBox.Show("Se actualizó exitosamente.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Manejar cualquier error
            //    MessageBox.Show("Ocurrió un error: " + ex.Message);
            //}
        }
















    }
}
