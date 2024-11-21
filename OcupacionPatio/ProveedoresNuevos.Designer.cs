namespace Clientes
{
    partial class ProveedoresNuevos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresNuevos));
            label1 = new Label();
            options = new Panel();
            btnClosePN = new PictureBox();
            btnMinimize = new PictureBox();
            btnMaximize = new PictureBox();
            btnRestore = new PictureBox();
            btnClose = new PictureBox();
            footer = new Panel();
            options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClosePN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(589, 89);
            label1.Name = "label1";
            label1.Size = new Size(499, 48);
            label1.TabIndex = 2;
            label1.Text = "ACTUALIZAR PROVEEDORES";
            // 
            // options
            // 
            options.BackColor = Color.FromArgb(224, 224, 224);
            options.Controls.Add(btnClosePN);
            options.Controls.Add(btnMinimize);
            options.Controls.Add(btnMaximize);
            options.Controls.Add(btnRestore);
            options.Controls.Add(btnClose);
            options.Dock = DockStyle.Top;
            options.Location = new Point(0, 0);
            options.Name = "options";
            options.Size = new Size(1635, 50);
            options.TabIndex = 3;
            options.MouseMove += options_MouseDown;
            // 
            // btnClosePN
            // 
            btnClosePN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClosePN.Cursor = Cursors.Hand;
            btnClosePN.Image = (Image)resources.GetObject("btnClosePN.Image");
            btnClosePN.Location = new Point(1530, 12);
            btnClosePN.Name = "btnClosePN";
            btnClosePN.Size = new Size(25, 30);
            btnClosePN.SizeMode = PictureBoxSizeMode.Zoom;
            btnClosePN.TabIndex = 6;
            btnClosePN.TabStop = false;
            btnClosePN.Click += btnClosePN_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(2940, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 5;
            btnMinimize.TabStop = false;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(2986, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 4;
            btnMaximize.TabStop = false;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.Image = (Image)resources.GetObject("btnRestore.Image");
            btnRestore.Location = new Point(2986, 7);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(30, 30);
            btnRestore.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestore.TabIndex = 1;
            btnRestore.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(3033, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            // 
            // footer
            // 
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 760);
            footer.Name = "footer";
            footer.Size = new Size(1635, 40);
            footer.TabIndex = 4;
            // 
            // ProveedoresNuevos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1635, 800);
            Controls.Add(footer);
            Controls.Add(options);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedoresNuevos";
            Text = "ProveedoresNuevos";
            options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClosePN).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel options;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
        private PictureBox btnRestore;
        private PictureBox btnClose;
        private PictureBox btnClosePN;
        private Panel footer;
    }
}