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
    public partial class ViewContractSFOpportunity : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public ViewContractSFOpportunity()
        {
            InitializeComponent();
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.visualizarDatosClientes(9);
            dbConnect.cargardatos(dataViewContractSFO, cmd);
            dbConnect.cerrarConexion();
        }

        private void dataViewContractSFO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
