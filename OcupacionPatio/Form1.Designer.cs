namespace Clientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            options = new Panel();
            btnMinimize = new PictureBox();
            btnMaximize = new PictureBox();
            btnRestore = new PictureBox();
            btnClose = new PictureBox();
            Menu = new Panel();
            panel9 = new Panel();
            btnCitas = new Button();
            panel3 = new Panel();
            submenu = new Panel();
            btnCorreoProv = new Button();
            btnMensaje = new Button();
            panel10 = new Panel();
            panel6 = new Panel();
            btnProveedores = new Button();
            panel5 = new Panel();
            panel8 = new Panel();
            btnSubProveedores = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            btnInicio = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            header = new Panel();
            footer = new Panel();
            body = new Panel();
            options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            Menu.SuspendLayout();
            panel9.SuspendLayout();
            submenu.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // options
            // 
            options.BackColor = Color.FromArgb(224, 224, 224);
            options.Controls.Add(btnMinimize);
            options.Controls.Add(btnMaximize);
            options.Controls.Add(btnRestore);
            options.Controls.Add(btnClose);
            options.Dock = DockStyle.Top;
            options.Location = new Point(0, 0);
            options.Name = "options";
            options.Size = new Size(1635, 50);
            options.TabIndex = 0;
            options.Paint += options_Paint;
            options.MouseMove += options_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1505, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 5;
            btnMinimize.TabStop = false;
            btnMinimize.Click += pictureBox1_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(1551, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 4;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Image = (Image)resources.GetObject("btnRestore.Image");
            btnRestore.Location = new Point(1551, 7);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(30, 30);
            btnRestore.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestore.TabIndex = 1;
            btnRestore.TabStop = false;
            btnRestore.Click += btnExpand_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1598, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(39, 94, 139);
            Menu.Controls.Add(panel9);
            Menu.Controls.Add(submenu);
            Menu.Controls.Add(panel8);
            Menu.Controls.Add(panel7);
            Menu.Controls.Add(panel4);
            Menu.Controls.Add(pictureBox1);
            Menu.Controls.Add(pictureBox2);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 50);
            Menu.Name = "Menu";
            Menu.Size = new Size(220, 877);
            Menu.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnCitas);
            panel9.Controls.Add(panel3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 415);
            panel9.Name = "panel9";
            panel9.Size = new Size(220, 60);
            panel9.TabIndex = 14;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(39, 94, 139);
            btnCitas.Cursor = Cursors.Hand;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnCitas.ForeColor = Color.White;
            btnCitas.ImageAlign = ContentAlignment.MiddleRight;
            btnCitas.Location = new Point(11, 12);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(206, 50);
            btnCitas.TabIndex = 8;
            btnCitas.Text = "CITAS";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Location = new Point(2, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 50);
            panel3.TabIndex = 7;
            // 
            // submenu
            // 
            submenu.BackColor = Color.DarkGray;
            submenu.Controls.Add(btnCorreoProv);
            submenu.Controls.Add(btnMensaje);
            submenu.Controls.Add(panel10);
            submenu.Controls.Add(panel6);
            submenu.Controls.Add(btnProveedores);
            submenu.Controls.Add(panel5);
            submenu.Dock = DockStyle.Top;
            submenu.Location = new Point(0, 250);
            submenu.Name = "submenu";
            submenu.Size = new Size(220, 165);
            submenu.TabIndex = 13;
            // 
            // btnCorreoProv
            // 
            btnCorreoProv.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCorreoProv.BackColor = Color.DarkGray;
            btnCorreoProv.Cursor = Cursors.Hand;
            btnCorreoProv.FlatAppearance.BorderSize = 0;
            btnCorreoProv.FlatAppearance.MouseOverBackColor = Color.White;
            btnCorreoProv.FlatStyle = FlatStyle.Flat;
            btnCorreoProv.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnCorreoProv.ForeColor = Color.Black;
            btnCorreoProv.Image = (Image)resources.GetObject("btnCorreoProv.Image");
            btnCorreoProv.ImageAlign = ContentAlignment.MiddleLeft;
            btnCorreoProv.Location = new Point(11, 59);
            btnCorreoProv.Name = "btnCorreoProv";
            btnCorreoProv.Size = new Size(209, 50);
            btnCorreoProv.TabIndex = 15;
            btnCorreoProv.Text = "   Correo";
            btnCorreoProv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorreoProv.UseVisualStyleBackColor = false;
            btnCorreoProv.Click += btnCorreoProv_Click;
            // 
            // btnMensaje
            // 
            btnMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMensaje.BackColor = Color.DarkGray;
            btnMensaje.Cursor = Cursors.Hand;
            btnMensaje.FlatAppearance.BorderSize = 0;
            btnMensaje.FlatAppearance.MouseOverBackColor = Color.White;
            btnMensaje.FlatStyle = FlatStyle.Flat;
            btnMensaje.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnMensaje.ForeColor = Color.Black;
            btnMensaje.Image = (Image)resources.GetObject("btnMensaje.Image");
            btnMensaje.ImageAlign = ContentAlignment.MiddleLeft;
            btnMensaje.Location = new Point(11, 115);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(209, 50);
            btnMensaje.TabIndex = 16;
            btnMensaje.Text = "   Mensaje";
            btnMensaje.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMensaje.UseVisualStyleBackColor = false;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(2, 115);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 50);
            panel10.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(2, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 50);
            panel6.TabIndex = 12;
            // 
            // btnProveedores
            // 
            btnProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProveedores.BackColor = Color.DarkGray;
            btnProveedores.Cursor = Cursors.Hand;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.White;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.Image = (Image)resources.GetObject("btnProveedores.Image");
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(11, 3);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(209, 50);
            btnProveedores.TabIndex = 11;
            btnProveedores.Text = "   Nuevo";
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 50);
            panel5.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSubProveedores);
            panel8.Controls.Add(panel2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 190);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 60);
            panel8.TabIndex = 12;
            // 
            // btnSubProveedores
            // 
            btnSubProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubProveedores.BackColor = Color.FromArgb(39, 94, 139);
            btnSubProveedores.Cursor = Cursors.Hand;
            btnSubProveedores.FlatAppearance.BorderSize = 0;
            btnSubProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnSubProveedores.FlatStyle = FlatStyle.Flat;
            btnSubProveedores.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnSubProveedores.ForeColor = Color.White;
            btnSubProveedores.ImageAlign = ContentAlignment.MiddleRight;
            btnSubProveedores.Location = new Point(14, 3);
            btnSubProveedores.Name = "btnSubProveedores";
            btnSubProveedores.Size = new Size(206, 50);
            btnSubProveedores.TabIndex = 7;
            btnSubProveedores.Text = "PROVEEDORES";
            btnSubProveedores.UseVisualStyleBackColor = false;
            btnSubProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 50);
            panel2.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnInicio);
            panel7.Controls.Add(panel1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 130);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 60);
            panel7.TabIndex = 11;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(39, 94, 139);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.ImageAlign = ContentAlignment.MiddleRight;
            btnInicio.Location = new Point(11, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(203, 50);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 50);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 28);
            panel4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 790);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.Location = new Point(220, 50);
            header.Name = "header";
            header.Size = new Size(1415, 40);
            header.TabIndex = 2;
            // 
            // footer
            // 
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(220, 887);
            footer.Name = "footer";
            footer.Size = new Size(1415, 40);
            footer.TabIndex = 3;
            // 
            // body
            // 
            body.AutoScroll = true;
            body.Dock = DockStyle.Fill;
            body.Location = new Point(220, 90);
            body.Name = "body";
            body.Size = new Size(1415, 797);
            body.TabIndex = 4;
            body.Paint += body_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1635, 927);
            Controls.Add(body);
            Controls.Add(footer);
            Controls.Add(header);
            Controls.Add(Menu);
            Controls.Add(options);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            Menu.ResumeLayout(false);
            panel9.ResumeLayout(false);
            submenu.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel options;
        private Panel Menu;
        private PictureBox btnClose;
        private PictureBox btnRestore;
        private PictureBox btnMaximize;
        private PictureBox btnMinimize;
        private PictureBox pictureBox2;
        private Button btnInicio;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel header;
        private Panel footer;
        private Panel body;
        private Button btnSubProveedores;
        private Panel panel2;
        private Button btnCitas;
        private Panel panel3;
        private Button btnProveedores;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel4;
        private Panel panel8;
        private Panel panel9;
        private Panel submenu;
        private Button btnMensaje;
        private Panel panel10;
        private Button btnCorreoProv;
    }
}
