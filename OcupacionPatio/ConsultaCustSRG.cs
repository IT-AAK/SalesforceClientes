﻿using System;
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
    public partial class ConsultaCustSRG : Form
    {
        // Conexión a la BD
        Conexion dbConnect = new Conexion();
        public ConsultaCustSRG()
        {
            InitializeComponent();
            dbConnect.abrirConexion();
            SqlCommand cmd = dbConnect.visualizarDatosClientes(5);
            dbConnect.cargardatos(dataConsultaCustSRG, cmd);
            dbConnect.cerrarConexion();
        }

        private void dataConsultaCustSRG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
