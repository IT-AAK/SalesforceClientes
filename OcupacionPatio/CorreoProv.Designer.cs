namespace Clientes
{
    partial class CorreoProv
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
            dataGridViewProv = new DataGridView();
            label1 = new Label();
            dataGridViewCorreosProv = new DataGridView();
            txtRFCCorreo = new TextBox();
            label3 = new Label();
            textCorreoProv = new TextBox();
            label2 = new Label();
            BtnCleanCorreoProv = new Button();
            btnAddCorreoProv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorreosProv).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProv
            // 
            dataGridViewProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProv.BackgroundColor = Color.White;
            dataGridViewProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProv.Location = new Point(12, 109);
            dataGridViewProv.Name = "dataGridViewProv";
            dataGridViewProv.RowHeadersWidth = 62;
            dataGridViewProv.Size = new Size(694, 332);
            dataGridViewProv.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(509, 58);
            label1.Name = "label1";
            label1.Size = new Size(406, 48);
            label1.TabIndex = 1;
            label1.Text = "CORREOS PROVEEDOR";
            // 
            // dataGridViewCorreosProv
            // 
            dataGridViewCorreosProv.BackgroundColor = Color.White;
            dataGridViewCorreosProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCorreosProv.Location = new Point(712, 109);
            dataGridViewCorreosProv.Name = "dataGridViewCorreosProv";
            dataGridViewCorreosProv.RowHeadersWidth = 62;
            dataGridViewCorreosProv.Size = new Size(691, 332);
            dataGridViewCorreosProv.TabIndex = 2;
            // 
            // txtRFCCorreo
            // 
            txtRFCCorreo.Location = new Point(121, 496);
            txtRFCCorreo.Name = "txtRFCCorreo";
            txtRFCCorreo.ReadOnly = true;
            txtRFCCorreo.Size = new Size(335, 31);
            txtRFCCorreo.TabIndex = 60;
            txtRFCCorreo.TextChanged += txtRFCCorreo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 495);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 59;
            label3.Text = "RFC";
            // 
            // textCorreoProv
            // 
            textCorreoProv.Location = new Point(121, 549);
            textCorreoProv.Name = "textCorreoProv";
            textCorreoProv.ReadOnly = true;
            textCorreoProv.Size = new Size(335, 31);
            textCorreoProv.TabIndex = 62;
            textCorreoProv.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 548);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 61;
            label2.Text = "Email";
            //label2.Click += this.label2_Click;
            // 
            // BtnCleanCorreoProv
            // 
            BtnCleanCorreoProv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCleanCorreoProv.BackColor = Color.FromArgb(39, 94, 139);
            BtnCleanCorreoProv.Cursor = Cursors.Hand;
            BtnCleanCorreoProv.FlatAppearance.BorderSize = 0;
            BtnCleanCorreoProv.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            BtnCleanCorreoProv.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCleanCorreoProv.ForeColor = Color.White;
            BtnCleanCorreoProv.Location = new Point(199, 694);
            BtnCleanCorreoProv.Name = "BtnCleanCorreoProv";
            BtnCleanCorreoProv.Size = new Size(145, 60);
            BtnCleanCorreoProv.TabIndex = 69;
            BtnCleanCorreoProv.Text = "LIMPIAR";
            BtnCleanCorreoProv.UseVisualStyleBackColor = false;
            // 
            // btnAddCorreoProv
            // 
            btnAddCorreoProv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCorreoProv.BackColor = Color.FromArgb(39, 94, 139);
            btnAddCorreoProv.Cursor = Cursors.Hand;
            btnAddCorreoProv.FlatAppearance.BorderSize = 0;
            btnAddCorreoProv.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAddCorreoProv.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCorreoProv.ForeColor = Color.White;
            btnAddCorreoProv.Location = new Point(37, 694);
            btnAddCorreoProv.Name = "btnAddCorreoProv";
            btnAddCorreoProv.Size = new Size(145, 60);
            btnAddCorreoProv.TabIndex = 68;
            btnAddCorreoProv.Text = "AGREGAR";
            btnAddCorreoProv.UseVisualStyleBackColor = false;
            // 
            // CorreoProv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1415, 800);
            Controls.Add(BtnCleanCorreoProv);
            Controls.Add(btnAddCorreoProv);
            Controls.Add(textCorreoProv);
            Controls.Add(label2);
            Controls.Add(txtRFCCorreo);
            Controls.Add(label3);
            Controls.Add(dataGridViewCorreosProv);
            Controls.Add(label1);
            Controls.Add(dataGridViewProv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CorreoProv";
            Text = "CorreoProv";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorreosProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProv;
        private Label label1;
        private DataGridView dataGridViewCorreosProv;
        private TextBox txtRFCCorreo;
        private Label label3;
        private TextBox textCorreoProv;
        private Label label2;
        private Button BtnCleanCorreoProv;
        private Button btnAddCorreoProv;
    }
}