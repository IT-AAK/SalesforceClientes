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
            SqlCommand cmd = dbConnect.visualizarDatosVendor(1, Name, RFC, Status, Kind, Notification);
            dbConnect.cargardatos(dataProv, cmd);
            dbConnect.cerrarConexion();
        }

        //Variables vacías para evitar errores en la base de datos
        string Name = "";
        string RFC = "";
        string Status = "";
        string Kind = "";
        string Kind2 = "";
        string Kind3 = "";
        string Kind4 = "";
        string Notification = "";

        //Insertar valor del texto si se hace check
        private void checkBoxKind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKind.Checked)
            {
                Kind = "PIPAS MP";
            }
            else
            {
                Kind = "";
            }
        }
        private void checkBoxKind2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKind2.Checked)
            {
                Kind2 = "PIPAS PT";
            }
            else
            {
                Kind2 = "";
            }
        }

        private void checkBoxKind3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxKind3.Checked)
            {
                Kind3 = "CAJA SECA PT";
            }
            else
            {
                Kind3 = "";
            }
        }

        private void checkBoxKind4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKind4.Checked)
            {
                Kind4 = "JUMBOS";
            }
            else
            {
                Kind4 = "";
            }
        }
        //Fin insertar valor del texto si se hace check


        //Muestra la información en los textbox al dar clic en alguna fila del data grid
        private void dataProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFC.Text = dataProv.SelectedCells[0].Value.ToString();
            txtNameProv.Text = dataProv.SelectedCells[1].Value.ToString();
            txtStatus.Text = dataProv.SelectedCells[7].Value.ToString();
        }

        //Función para limpiar los campos
        private void clear()
        {
            txtRFC.Clear();
            txtNameProv.Clear();
            checkBoxKind.Checked = false;
            checkBoxKind2.Checked = false;
            checkBoxKind3.Checked = false;
            checkBoxKind4.Checked = false;
            //comboBoxKind.SelectedIndex = -1;
            txtStatus.Clear();
        }

        //Botón que usa la función de limpiar
        private void BtnClean_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        //Busqueda dinamica por el nombre (proveedor)
        private void txtNameProv_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorNombreProveedor(txtNameProv.Text, dataProv);

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

        //Busqueda dinamica por el RFC (proveedor)
        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorRFC(txtRFC.Text, dataProv);

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
                dbConnect.abrirConexion();
                dbConnect.InsertVendor(txtNameProv.Text, txtRFC.Text, txtStatus.Text, Kind, Kind2, Kind3, Kind4);

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


        // Código que sirve para agregar un combobox extra y se limita solo a 3
        //List<ComboBox> dynamicComboBoxes = new List<ComboBox>();
        //List<Button> removeButtons = new List<Button>();
        //int i = 1;
        //private void btnAddCombobox_Click(object sender, EventArgs e)
        //{
        //    if (dynamicComboBoxes.Count < 3)
        //    {
        //        ComboBox comboBox = new ComboBox();
        //        comboBox.Anchor = (AnchorStyles.Top);
        //        comboBox.Width = 200;
        //        this.Controls.Add(comboBox);
        //        comboBox.Top = 635 + (dynamicComboBoxes.Count * 60);
        //        comboBox.Left = 842;
        //        comboBox.Text = "SELECT" + this.i.ToString();
        //        i++;

        //        // Agregar elementos al ComboBox
        //        List<string> items = new List<string> { "SELECT", "PIPAS MP", "PIPAS PT", "CAJA SECA PT" };
        //        comboBox.DataSource = items;

        //        dynamicComboBoxes.Add(comboBox);

        //        Button removeButton = new Button();
        //        removeButton.Anchor = (AnchorStyles.Top);
        //        removeButton.Text = "-";
        //        removeButton.Width = 30;
        //        removeButton.Height = 30;
        //        removeButton.Top = 580 + (dynamicComboBoxes.Count * 60);
        //        removeButton.Left = 1050;
        //        removeButton.Click += (s, args) => RemoveComboBox(comboBox, removeButton);

        //        this.Controls.Add(removeButton);
        //        removeButtons.Add(removeButton);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se pueden agregar más de 2 ComboBox.");
        //    }
        //}

        //private void RemoveComboBox(ComboBox comboBox, Button removeButton)
        //{
        //    this.Controls.Remove(comboBox);
        //    this.Controls.Remove(removeButton);
        //    dynamicComboBoxes.Remove(comboBox);

        //    // Reubica los ComboBox y botones restantes
        //    for (int i = 0; i < dynamicComboBoxes.Count; i++)
        //    {
        //        dynamicComboBoxes[i].Location = new Point(842, 635 + (i * 25));
        //    }
        //}
        //Fin código para agregar un nuevo combobox

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizarProv_Click(object sender, EventArgs e)
        {
            ProveedoresNuevos newFormProv = new ProveedoresNuevos();

            newFormProv.ShowDialog();
        }
    }
}
