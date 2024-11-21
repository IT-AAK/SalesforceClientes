using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clientes
{
    public partial class CuerpoCorreo : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public CuerpoCorreo()
        {
            InitializeComponent();
            cargarPantalla();
        }

        public void cargarPantalla()
        {
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.VisualizarEmail(10);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtSubject.Text = reader["subject"].ToString();
                    textTitle.Text = reader["Title"].ToString();
                    textSubtitle.Text = reader["Subtitle"].ToString();
                    textBody.Text = reader["Body"].ToString();
                }
            }
            dbConnect.cerrarConexion();
        }

        private void btnResetCuerpoCorreo_Click(object sender, EventArgs e)
        {
            cargarPantalla();
        }

        private void btnUpdateCuerpoCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.UpdateCuerpoCorreo(txtSubject.Text, textTitle.Text, textSubtitle.Text, textBody.Text);
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
            finally
            {
                dbConnect.cerrarConexion();
            }
        }
    }
}
