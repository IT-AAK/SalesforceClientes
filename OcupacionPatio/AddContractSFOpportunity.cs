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

    public partial class AddContractSFOpportunity : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public AddContractSFOpportunity()
        {
            InitializeComponent();
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.visualizarDatosSFOpportunity(6);
            dbConnect.cargardatos(dataProv, cmd);
            dbConnect.cerrarConexion();
        }

        //Muestra la información en los textbox al dar clic en alguna fila del data grid
        private void dataProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSFOContractID.Text = dataProv.SelectedCells[0].Value.ToString();
            txtSFOCustID.Text = dataProv.SelectedCells[1].Value.ToString();
            //txtSAPRegGroup.Text = dataProv.SelectedCells[7].Value.ToString();
        }

        //Función para limpiar los campos
        private void clear()
        {
            txtSFOID.Clear();
            txtSFOContractID.Clear();
            txtSFOCustID.Clear();
            dateTimePickerSFOIniDate.Value = DateTime.Now;
            dateTimePickerSFOEndDate.Value = DateTime.Now;
        }

        private void BtnCleanSFO_Click(object sender, EventArgs e)
        {
            clear();
        }

        // Busqueda por Contracts
        private void txtSFOContractID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorSFOContract(txtSFOContractID.Text, dataProv);

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

        // Busqueda por CustID
        private void txtSFOCustID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbConnect.abrirConexion();
                dbConnect.FiltrarPorSFOCustID(txtSFOCustID.Text, dataProv);

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

        private void btnAddSFO_Click(object sender, EventArgs e)
        {
            try
            {
                    string SFOID = txtSFOID.Text; 
                    string ContractID = txtSFOContractID.Text;           
                    string CustID = txtSFOCustID.Text;
                    DateTime IniDate = dateTimePickerSFOIniDate.Value;
                    DateTime EndDate = dateTimePickerSFOEndDate.Value;

                    dbConnect.abrirConexion();
                    dbConnect.InsertSFOpportunity(SFOID, ContractID, CustID, IniDate, EndDate);


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
                clear();
            }
        }

        
    }
}
