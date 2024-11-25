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
            submenu = new Panel();
            btnSearchCust = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            btnInsertCust = new Button();
            panel8 = new Panel();
            panel7 = new Panel();
            btnSubProveedores = new Button();
            panel2 = new Panel();
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
            submenu.SuspendLayout();
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
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 316);
            panel9.Name = "panel9";
            panel9.Size = new Size(220, 30);
            panel9.TabIndex = 14;
            // 
            // submenu
            // 
            submenu.BackColor = Color.DarkGray;
            submenu.Controls.Add(btnSearchCust);
            submenu.Controls.Add(panel5);
            submenu.Controls.Add(panel6);
            submenu.Controls.Add(btnInsertCust);
            submenu.Dock = DockStyle.Top;
            submenu.Location = new Point(0, 200);
            submenu.Name = "submenu";
            submenu.Size = new Size(220, 116);
            submenu.TabIndex = 13;
            // 
            // btnSearchCust
            // 
            btnSearchCust.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchCust.BackColor = Color.DarkGray;
            btnSearchCust.Cursor = Cursors.Hand;
            btnSearchCust.FlatAppearance.BorderSize = 0;
            btnSearchCust.FlatAppearance.MouseOverBackColor = Color.White;
            btnSearchCust.FlatStyle = FlatStyle.Flat;
            btnSearchCust.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnSearchCust.ForeColor = Color.Black;
            btnSearchCust.Image = (Image)resources.GetObject("btnSearchCust.Image");
            btnSearchCust.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCust.Location = new Point(11, 60);
            btnSearchCust.Name = "btnSearchCust";
            btnSearchCust.Size = new Size(209, 50);
            btnSearchCust.TabIndex = 15;
            btnSearchCust.Text = "   Consultar";
            btnSearchCust.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchCust.UseVisualStyleBackColor = false;
            btnSearchCust.Click += btnSearchCust_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(2, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 50);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(2, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 50);
            panel6.TabIndex = 12;
            panel6.Paint += panel6_Paint;
            // 
            // btnInsertCust
            // 
            btnInsertCust.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInsertCust.BackColor = Color.DarkGray;
            btnInsertCust.Cursor = Cursors.Hand;
            btnInsertCust.FlatAppearance.BorderSize = 0;
            btnInsertCust.FlatAppearance.MouseOverBackColor = Color.White;
            btnInsertCust.FlatStyle = FlatStyle.Flat;
            btnInsertCust.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnInsertCust.ForeColor = Color.Black;
            btnInsertCust.Image = (Image)resources.GetObject("btnInsertCust.Image");
            btnInsertCust.ImageAlign = ContentAlignment.MiddleLeft;
            btnInsertCust.Location = new Point(11, 4);
            btnInsertCust.Name = "btnInsertCust";
            btnInsertCust.Size = new Size(209, 50);
            btnInsertCust.TabIndex = 11;
            btnInsertCust.Text = "   Regsitro";
            btnInsertCust.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInsertCust.UseVisualStyleBackColor = false;
            btnInsertCust.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 190);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 10);
            panel8.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSubProveedores);
            panel7.Controls.Add(panel2);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 130);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 60);
            panel7.TabIndex = 11;
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
            btnSubProveedores.Location = new Point(14, 10);
            btnSubProveedores.Name = "btnSubProveedores";
            btnSubProveedores.Size = new Size(206, 50);
            btnSubProveedores.TabIndex = 7;
            btnSubProveedores.Text = "SF CLIENTES";
            btnSubProveedores.UseVisualStyleBackColor = false;
            btnSubProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Location = new Point(3, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 50);
            panel2.TabIndex = 6;
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
            submenu.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Panel header;
        private Panel footer;
        private Panel body;
        private Button btnSubProveedores;
        private Panel panel2;
        private Button btnInsertCust;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel4;
        private Panel panel8;
        private Panel panel9;
        private Panel submenu;
        private Button btnSearchCust;
    }
}
