namespace Clientes
{
    partial class citas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewCitas = new DataGridView();
            txtEmailCitas = new TextBox();
            label11 = new Label();
            label4 = new Label();
            txtRFCCitas = new TextBox();
            label3 = new Label();
            txtNameProvCitas = new TextBox();
            label2 = new Label();
            label12 = new Label();
            dateTimePickerCita = new DateTimePicker();
            BtnCleanCitas = new Button();
            btnAddCitas = new Button();
            btnUpdateFechaCita = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(642, 68);
            label1.Name = "label1";
            label1.Size = new Size(116, 48);
            label1.TabIndex = 0;
            label1.Text = "CITAS";
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitas.BackgroundColor = Color.White;
            dataGridViewCitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCitas.ColumnHeadersHeight = 50;
            dataGridViewCitas.EnableHeadersVisualStyles = false;
            dataGridViewCitas.Location = new Point(12, 119);
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.RowHeadersVisible = false;
            dataGridViewCitas.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataGridViewCitas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCitas.Size = new Size(1391, 332);
            dataGridViewCitas.TabIndex = 1;
            dataGridViewCitas.CellContentClick += dataGridViewCitas_CellContentClick;
            // 
            // txtEmailCitas
            // 
            txtEmailCitas.Anchor = AnchorStyles.Top;
            txtEmailCitas.Location = new Point(658, 542);
            txtEmailCitas.Name = "txtEmailCitas";
            txtEmailCitas.ReadOnly = true;
            txtEmailCitas.Size = new Size(335, 31);
            txtEmailCitas.TabIndex = 64;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(560, 540);
            label11.Name = "label11";
            label11.Size = new Size(77, 32);
            label11.TabIndex = 61;
            label11.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.Location = new Point(548, 465);
            label4.Name = "label4";
            label4.Size = new Size(334, 45);
            label4.TabIndex = 59;
            label4.Text = "DATOS PROVEEDOR";
            // 
            // txtRFCCitas
            // 
            txtRFCCitas.Location = new Point(179, 601);
            txtRFCCitas.Name = "txtRFCCitas";
            txtRFCCitas.ReadOnly = true;
            txtRFCCitas.Size = new Size(335, 31);
            txtRFCCitas.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 610);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 57;
            label3.Text = "RFC";
            // 
            // txtNameProvCitas
            // 
            txtNameProvCitas.Location = new Point(179, 543);
            txtNameProvCitas.Name = "txtNameProvCitas";
            txtNameProvCitas.ReadOnly = true;
            txtNameProvCitas.Size = new Size(335, 31);
            txtNameProvCitas.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 524);
            label2.Name = "label2";
            label2.Size = new Size(135, 64);
            label2.TabIndex = 55;
            label2.Text = "Nombre \r\nProveedor";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(560, 598);
            label12.Name = "label12";
            label12.Size = new Size(80, 32);
            label12.TabIndex = 62;
            label12.Text = "Fecha";
            // 
            // dateTimePickerCita
            // 
            dateTimePickerCita.Anchor = AnchorStyles.Top;
            dateTimePickerCita.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerCita.Format = DateTimePickerFormat.Custom;
            dateTimePickerCita.Location = new Point(661, 604);
            dateTimePickerCita.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dateTimePickerCita.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePickerCita.Name = "dateTimePickerCita";
            dateTimePickerCita.Size = new Size(332, 31);
            dateTimePickerCita.TabIndex = 65;
            dateTimePickerCita.Value = new DateTime(2024, 6, 21, 10, 31, 39, 0);
            dateTimePickerCita.ValueChanged += dateTimePickerCita_ValueChanged;
            // 
            // BtnCleanCitas
            // 
            BtnCleanCitas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCleanCitas.BackColor = Color.FromArgb(39, 94, 139);
            BtnCleanCitas.Cursor = Cursors.Hand;
            BtnCleanCitas.FlatAppearance.BorderSize = 0;
            BtnCleanCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            BtnCleanCitas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCleanCitas.ForeColor = Color.White;
            BtnCleanCitas.Location = new Point(181, 698);
            BtnCleanCitas.Name = "BtnCleanCitas";
            BtnCleanCitas.Size = new Size(145, 60);
            BtnCleanCitas.TabIndex = 67;
            BtnCleanCitas.Text = "LIMPIAR";
            BtnCleanCitas.UseVisualStyleBackColor = false;
            BtnCleanCitas.Click += BtnCleanCitas_Click;
            // 
            // btnAddCitas
            // 
            btnAddCitas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCitas.BackColor = Color.FromArgb(39, 94, 139);
            btnAddCitas.Cursor = Cursors.Hand;
            btnAddCitas.FlatAppearance.BorderSize = 0;
            btnAddCitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAddCitas.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCitas.ForeColor = Color.White;
            btnAddCitas.Location = new Point(19, 698);
            btnAddCitas.Name = "btnAddCitas";
            btnAddCitas.Size = new Size(145, 60);
            btnAddCitas.TabIndex = 66;
            btnAddCitas.Text = "AGREGAR";
            btnAddCitas.UseVisualStyleBackColor = false;
            btnAddCitas.Click += btnAddCitas_Click;
            // 
            // btnUpdateFechaCita
            // 
            btnUpdateFechaCita.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateFechaCita.BackColor = Color.FromArgb(39, 94, 139);
            btnUpdateFechaCita.Cursor = Cursors.Hand;
            btnUpdateFechaCita.FlatAppearance.BorderSize = 0;
            btnUpdateFechaCita.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnUpdateFechaCita.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateFechaCita.ForeColor = Color.White;
            btnUpdateFechaCita.Location = new Point(345, 698);
            btnUpdateFechaCita.Name = "btnUpdateFechaCita";
            btnUpdateFechaCita.Size = new Size(295, 60);
            btnUpdateFechaCita.TabIndex = 68;
            btnUpdateFechaCita.Text = "ACTUALIZAR FECHA";
            btnUpdateFechaCita.UseVisualStyleBackColor = false;
            btnUpdateFechaCita.Click += btnUpdateFechaCita_Click;
            // 
            // citas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1415, 797);
            Controls.Add(btnUpdateFechaCita);
            Controls.Add(BtnCleanCitas);
            Controls.Add(btnAddCitas);
            Controls.Add(dateTimePickerCita);
            Controls.Add(txtEmailCitas);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(txtRFCCitas);
            Controls.Add(label3);
            Controls.Add(txtNameProvCitas);
            Controls.Add(label2);
            Controls.Add(dataGridViewCitas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "citas";
            Text = "citas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewCitas;
        private TextBox txtEmailCitas;
        private Label label11;
        private Label label4;
        private TextBox txtRFCCitas;
        private Label label3;
        private TextBox txtNameProvCitas;
        private Label label2;
        private Label label12;
        private DateTimePicker dateTimePickerCita;
        private Button BtnCleanCitas;
        private Button btnAddCitas;
        private Button btnUpdateFechaCita;
    }
}