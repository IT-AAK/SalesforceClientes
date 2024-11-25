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
    public partial class proveedores : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public proveedores()
        {
            InitializeComponent();
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.visualizarDatosClientes(1);
            dbConnect.cargardatos(dataProv, cmd);
            dbConnect.cerrarConexion();
            cargarDatosComboBox();

        }

        //Muestra la información en los textbox al dar clic en alguna fila del data grid
        private void dataProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameCust.Text = dataProv.SelectedCells[0].Value.ToString();
            txtIDCust.Text = dataProv.SelectedCells[1].Value.ToString();
            //txtSAPRegGroup.Text = dataProv.SelectedCells[7].Value.ToString();
        }

        //Función para limpiar los campos
        private void clear()
        {
            txtNameCust.Clear();
            txtIDCust.Clear();
            comboSapRegGroup.SelectedIndex = -1;
        }

        //Botón que usa la función de limpiar
        private void BtnClean_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        //Busqueda dinamica por el ID (Cliente)
        private void txtCustID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorCustID(txtIDCust.Text, dataProv);

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

        //Busqueda dinamica por el Nombre (Cliente)
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorNombre(txtNameCust.Text, dataProv);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una selección válida en el ComboBox
                if (comboSapRegGroup.SelectedItem is KeyValuePair<string, string> selectedItem)
                {
                    string sapRegGroupCode = selectedItem.Key; // Obtén el código del ComboBox
                    string custID = txtIDCust.Text;           // ID del cliente
                    string nameCust = txtNameCust.Text;       // Nombre del cliente

                    dbConnect.abrirConexion();
                    dbConnect.InsertSapRegGroup(custID, nameCust, sapRegGroupCode);
                }
                else
                {
                    MessageBox.Show("Selecciona un grupo SAP válido.");
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
            finally
            {
                dbConnect.cerrarConexion();
            }
        }

        private void comboSapRegGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Seleccionaste: {comboSapRegGroup.SelectedItem}");
        }

        private void cargarDatosComboBox()
        {
            try
            {
                dbConnect.abrirConexion();
                SqlCommand cmd = dbConnect.visualizarListaSapRegGroup(2);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar items existentes en el ComboBox
                comboSapRegGroup.Items.Clear();

                // Llenar el ComboBox con pares clave-valor
                while (reader.Read())
                {
                    string sapRegGroup = reader.GetString(0);
                    string Description = reader.GetString(1);
                    comboSapRegGroup.Items.Add(new KeyValuePair<string, string>(sapRegGroup, Description));
                }

                // Configurar cómo mostrar los valores
                comboSapRegGroup.DisplayMember = "Value"; // Muestra el nombre
                comboSapRegGroup.ValueMember = "Key";    // Almacena el código

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
