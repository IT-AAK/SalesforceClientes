using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Numerics;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        //Abre la conexión y carga la consulta en el data grid
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Cerrar ventana
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Expandir ventana
        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        //Minimizar ventana
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Código para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void options_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void options_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFormPanel(object frmHijo)
        {

            if (this.body.Controls.Count > 0)
                this.body.Controls.RemoveAt(0);
            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.body.Controls.Add(fh);
            this.body.Tag = fh;
            fh.Show();

        }

        private void customizeDesing()
        {
            submenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (submenu.Visible == true)
                submenu.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(submenu);
            //openFormPanel(new proveedores());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            openFormPanel(new inicio());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            //openFormPanel(new citas());
        }

        //Agregar Proveedor
        private void button1_Click(object sender, EventArgs e)
        {
            openFormPanel(new proveedores());
            hideSubMenu();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            openFormPanel(new CuerpoCorreo());
            hideSubMenu();
        }

        private void btnCorreoProv_Click(object sender, EventArgs e)
        {
            openFormPanel(new CorreoProv());
            hideSubMenu();
        }
    }
}
