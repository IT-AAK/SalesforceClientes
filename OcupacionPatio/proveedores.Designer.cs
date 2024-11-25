namespace Clientes
{
    partial class proveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BtnClean = new Button();
            label10 = new Label();
            label4 = new Label();
            txtNameCust = new TextBox();
            label3 = new Label();
            txtIDCust = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            dataProv = new DataGridView();
            comboSapRegGroup = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataProv).BeginInit();
            SuspendLayout();
            // 
            // BtnClean
            // 
            BtnClean.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnClean.BackColor = Color.FromArgb(39, 94, 139);
            BtnClean.Cursor = Cursors.Hand;
            BtnClean.FlatAppearance.BorderSize = 0;
            BtnClean.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            BtnClean.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClean.ForeColor = Color.White;
            BtnClean.Location = new Point(250, 810);
            BtnClean.Name = "BtnClean";
            BtnClean.Size = new Size(180, 60);
            BtnClean.TabIndex = 50;
            BtnClean.Text = "LIMPIAR";
            BtnClean.UseVisualStyleBackColor = false;
            BtnClean.Click += BtnClean_Click_1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(722, 600);
            label10.Name = "label10";
            label10.Size = new Size(200, 32);
            label10.TabIndex = 47;
            label10.Text = "SAP Reg. Group";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.Location = new Point(581, 499);
            label4.Name = "label4";
            label4.Size = new Size(287, 45);
            label4.TabIndex = 40;
            label4.Text = "DATOS CLIENTES";
            // 
            // txtNameCust
            // 
            txtNameCust.Location = new Point(275, 630);
            txtNameCust.Name = "txtNameCust";
            txtNameCust.Size = new Size(358, 31);
            txtNameCust.TabIndex = 39;
            txtNameCust.TextChanged += txtNombre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 630);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 38;
            label3.Text = "Nombre Cliente";
            // 
            // txtIDCust
            // 
            txtIDCust.Location = new Point(275, 577);
            txtIDCust.Name = "txtIDCust";
            txtIDCust.Size = new Size(358, 31);
            txtIDCust.TabIndex = 37;
            txtIDCust.TextChanged += txtCustID_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 574);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 36;
            label2.Text = "ID Cliente";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(513, 64);
            label1.Name = "label1";
            label1.Size = new Size(492, 48);
            label1.TabIndex = 35;
            label1.Text = "CLIENTES SALESFORCE MX\r\n";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.FromArgb(39, 94, 139);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAdd.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(50, 810);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 60);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataProv
            // 
            dataProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProv.BackgroundColor = Color.White;
            dataProv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataProv.ColumnHeadersHeight = 50;
            dataProv.EnableHeadersVisualStyles = false;
            dataProv.Location = new Point(50, 124);
            dataProv.Name = "dataProv";
            dataProv.ReadOnly = true;
            dataProv.RowHeadersVisible = false;
            dataProv.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataProv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataProv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProv.Size = new Size(1397, 361);
            dataProv.TabIndex = 33;
            dataProv.CellContentClick += dataProv_CellContentClick;
            // 
            // comboSapRegGroup
            // 
            comboSapRegGroup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboSapRegGroup.FormattingEnabled = true;
            comboSapRegGroup.Location = new Point(928, 603);
            comboSapRegGroup.Name = "comboSapRegGroup";
            comboSapRegGroup.Size = new Size(463, 33);
            comboSapRegGroup.TabIndex = 52;
            comboSapRegGroup.SelectedIndexChanged += comboSapRegGroup_SelectedIndexChanged;
            // 
            // proveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1497, 903);
            Controls.Add(comboSapRegGroup);
            Controls.Add(BtnClean);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(txtNameCust);
            Controls.Add(label3);
            Controls.Add(txtIDCust);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(dataProv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "proveedores";
            Text = "proveedores";
            ((System.ComponentModel.ISupportInitialize)dataProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnClean;
        private Label label10;
        private Label label4;
        private TextBox txtNameCust;
        private Label label3;
        private TextBox txtIDCust;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private DataGridView dataProv;
        private ComboBox comboSapRegGroup;
    }
}