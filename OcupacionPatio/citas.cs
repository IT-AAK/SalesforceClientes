using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clientes
{
    public partial class citas : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public citas()
        {
            InitializeComponent();
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.VisualizarProveedores(7);
            dbConnect.cargardatos(dataGridViewCitas, cmd);
            dbConnect.cerrarConexion();
            dateTimePickerCita.Value = DateTime.Now;
            //LlenarComboBox();
            //comboBoxCitas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        //Mostrar datos en los input de acuerdo a la selección a el gridview
        private void dataGridViewCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameProvCitas.Text = dataGridViewCitas.SelectedCells[0].Value.ToString();
            txtRFCCitas.Text = dataGridViewCitas.SelectedCells[1].Value.ToString();
            txtEmailCitas.Text = dataGridViewCitas.SelectedCells[4].Value.ToString();
        }

        //Limpiar inputs
        private void clear()
        {
            txtNameProvCitas.Clear();
            txtRFCCitas.Clear();
            txtEmailCitas.Clear();
        }

        private void BtnCleanCitas_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAddCitas_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.InsertCita(txtNameProvCitas.Text, txtRFCCitas.Text, txtEmailCitas.Text, dateTimePickerCita.Value);
                clear();

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

        private void dateTimePickerCita_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePickerCita.Value = DateTime.Now;
        }

        private void btnUpdateFechaCita_Click(object sender, EventArgs e)
        {
            dateTimePickerCita.Value = DateTime.Now;
        }


        //Bloque para mostrar lista de proveedores

        //private void LlenarComboBox()
        //{
        //    dbConnect.abrirConexion();

        //    List<string> nombres = ObtenerNombres(7);

        //    dbConnect.cerrarConexion();

        //    comboBoxCitas.DataSource = nombres;
        //}

        //private List<string> ObtenerNombres(int operacion)
        //{
        //    List<string> nombres = new List<string>();

        //    SqlCommand command = dbConnect.ListaProveedores(operacion);

        //    try
        //    {
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                string nombre = reader.GetString(0);
        //                nombres.Add(nombre);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocurrió un error: " + ex.Message);
        //    }

        //    return nombres;
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string nombreSeleccionado = comboBoxCitas.SelectedItem.ToString();
        //    MessageBox.Show("Has seleccionado: " + nombreSeleccionado);
        //}

        //Fin Bloque para mostrar lista de proveedores
    }
}
