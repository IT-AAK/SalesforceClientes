using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Clientes
{
    public partial class inicio : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        //private bool correosEnviadosFlag = false;
        private HashSet<string> kindsEnviados = new HashSet<string>();


        public inicio()
        {
            InitializeComponent();
            cargarPantalla();
        }

        public void cargarPantalla()
        {
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.VisualizarOcipacionPatio(6);
            dbConnect.cargardatos(dataDisponibilidad, cmd);
            dataDisponibilidad.CellFormatting += ColoresPorcentaje;
            timer2.Enabled = true;
            dbConnect.cerrarConexion();
        }

        private void ColoresPorcentaje(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataDisponibilidad.Columns[e.ColumnIndex].Name == "Porcentaje")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int porcentaje))
                {
                    DataGridViewRow row = dataDisponibilidad.Rows[e.RowIndex];
                    DataGridViewCell cell = row.Cells["kind"];

                    if (cell != null && cell.Value != null && cell.Value != DBNull.Value)
                    {
                        string kind = cell.Value.ToString().Trim();

                        try
                        {
                            if (porcentaje >= 80)
                            {
                                // Enviar correos solo si el porcentaje es mayor o igual a 80
                                EnviarCorreosDesdeSQL(kind);
                                kindsEnviados.Add(kind);
                                //correosEnviadosFlag = true;
                            }

                            // Establecer el color de la celda según el porcentaje
                            if (porcentaje < 50)
                            {
                                e.CellStyle.BackColor = Color.Green;
                            }
                            else if (porcentaje < 80)
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                            }
                            else
                            {
                                e.CellStyle.BackColor = Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener tipo de Kind: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                        }
                    }
                }
            }
        }

        //private void timerInicial()
        //{
        //    // Configurar el Timer con un intervalo inicial (ejemplo: 5 minutos)
        //    timer1 = new Timer();
        //    timer1.Interval = 300000; // 5 minutos en milisegundos
        //    timer1.Tick += cargarPantalla;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cargarPantalla();
            dataDisponibilidad.CellFormatting += ColoresPorcentaje;
            //correosEnviadosFlag = false;
            //MessageBox.Show("Funciona");
        }

        //Bloque para envío de correo
        private void EnviarCorreosDesdeSQL(string kind)
        {
            try
            {
                dbConnect.abrirConexion();
                using (SqlCommand cmd = new SqlCommand("zSP_Clientes", dbConnect.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tynOperacion", 5);
                    cmd.Parameters.AddWithValue("@Kind", kind);
                    cmd.Parameters.AddWithValue("@Kind2", "");
                    cmd.Parameters.AddWithValue("@Kind3", "");
                    cmd.Parameters.AddWithValue("@Kind4", "");
                    cmd.Parameters.AddWithValue("@Name", "");
                    cmd.Parameters.AddWithValue("@RFC", "");
                    cmd.Parameters.AddWithValue("@Status", "");
                    cmd.Parameters.AddWithValue("@Email", "");
                    cmd.Parameters.AddWithValue("@Notification", "");
                    cmd.Parameters.AddWithValue("@FechaCita", "");
                    cmd.Parameters.AddWithValue("@subject", "");
                    cmd.Parameters.AddWithValue("@title", "");
                    cmd.Parameters.AddWithValue("@subtitle", "");
                    cmd.Parameters.AddWithValue("@body", "");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //if (!reader.HasRows)
                        //{
                        //    MessageBox.Show("No se encontraron registros.");
                        //    return;
                        //}

                        while (reader.Read())
                        {
                            try
                            {
                                string name = reader.IsDBNull(0) ? string.Empty : reader.GetString(0).Trim();
                                string rfc = reader.IsDBNull(1) ? string.Empty : reader.GetString(1).Trim();
                                string kindValue = reader.IsDBNull(2) ? string.Empty : reader.GetString(2).Trim();
                                string email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3).Trim();

                                if (IsValidEmail(email))
                                {
                                    try
                                    {
                                        enviarCorreo(email, kind);
                                        dbConnect.InsertRegistroEnvioCorreo(name, rfc, kindValue, email);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error al enviar correo a " + email + ": " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La dirección de correo electrónico no es válida: " + email);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al leer datos del DataReader: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta SQL: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
            finally
            {
                dbConnect.cerrarConexion();
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //public void enviarCorreo(string destinatario, string kind)
        //{
        //    try
        //    {
        //        SqlCommand cmd = dbConnect.VisualizarEmail(10);
        //        if (cmd == null)
        //        {
        //            MessageBox.Show("Error al crear el comando SQL.");
        //            return;
        //        }

        //        if (cmd.Connection.State != System.Data.ConnectionState.Open)
        //        {
        //            cmd.Connection.Open();
        //        }

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (!reader.HasRows)
        //            {
        //                MessageBox.Show("No se encontraron registros en la base de datos.");
        //                return;
        //            }

        //            while (reader.Read())
        //            {
        //                string subject = reader["Subject"]?.ToString();
        //                string title = reader["Title"]?.ToString();
        //                string subtitle = reader["Subtitle"]?.ToString();
        //                string body = reader["Body"]?.ToString();

        //                if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(subtitle) || string.IsNullOrEmpty(body))
        //                {
        //                    MessageBox.Show("Uno o más campos del correo están vacíos.");
        //                    continue;
        //                }

        //                Outlook.Application outlookApp = new Outlook.Application();
        //                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
        //                mailItem.Subject = $"AVISO - {kind}";
        //                mailItem.HTMLBody = $"<h1>{title}</h1>" +
        //                                    $"<h1>{subtitle}</h1>" +
        //                                    $"<h1>{body}</h1>";
        //                mailItem.To = destinatario;
        //                mailItem.Send();
        //            }
        //        }

        //        cmd.Connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al enviar correo: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
        //    }
        //}

        public void enviarCorreo(string destinatario, string kind)
        {
            try
            {
                SqlCommand cmd = dbConnect.VisualizarEmail(10);
                if (cmd == null)
                {
                    MessageBox.Show("Error al crear el comando SQL.");
                    return;
                }

                if (cmd.Connection.State != System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No se encontraron registros en la base de datos.");
                        return;
                    }

                    while (reader.Read())
                    {
                        try
                        {
                            string subject = reader["Subject"]?.ToString();
                            string title = reader["Title"]?.ToString();
                            string subtitle = reader["Subtitle"]?.ToString();
                            string body = reader["Body"]?.ToString();

                            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(subtitle) || string.IsNullOrEmpty(body))
                            {
                                MessageBox.Show("Uno o más campos del correo están vacíos.");
                                continue;
                            }

                            Outlook.Application outlookApp = null;
                            Outlook.MailItem mailItem = null;

                            try
                            {
                                outlookApp = new Outlook.Application();
                                mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                                mailItem.Subject = $"AVISO - {kind}";
                                mailItem.HTMLBody = $"<h1>{title}</h1><h1>{subtitle}</h1><h1>{body}</h1>";
                                mailItem.To = destinatario;
                                mailItem.Send();
                            }
                            finally
                            {
                                if (mailItem != null) Marshal.ReleaseComObject(mailItem);
                                if (outlookApp != null) Marshal.ReleaseComObject(outlookApp);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al leer datos del DataReader: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                        }
                    }
                }

                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }







    }
}
