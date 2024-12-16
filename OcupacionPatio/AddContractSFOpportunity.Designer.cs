namespace Clientes
{
    partial class AddContractSFOpportunity
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
            dataProv = new DataGridView();
            BtnCleanSFO = new Button();
            btnAddSFO = new Button();
            label4 = new Label();
            txtSFOID = new TextBox();
            label2 = new Label();
            txtSFOContractID = new TextBox();
            label3 = new Label();
            txtSFOCustID = new TextBox();
            label5 = new Label();
            label8 = new Label();
            dateTimePickerSFOIniDate = new DateTimePicker();
            dateTimePickerSFOEndDate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataProv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(617, 41);
            label1.Name = "label1";
            label1.Size = new Size(281, 48);
            label1.TabIndex = 37;
            label1.Text = "SFOpportunity";
            // 
            // dataProv
            // 
            dataProv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProv.BackgroundColor = Color.White;
            dataProv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataProv.ColumnHeadersHeight = 50;
            dataProv.EnableHeadersVisualStyles = false;
            dataProv.Location = new Point(51, 103);
            dataProv.Name = "dataProv";
            dataProv.ReadOnly = true;
            dataProv.RowHeadersVisible = false;
            dataProv.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataProv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataProv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProv.Size = new Size(1397, 361);
            dataProv.TabIndex = 36;
            dataProv.CellContentClick += dataProv_CellContentClick;
            // 
            // BtnCleanSFO
            // 
            BtnCleanSFO.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCleanSFO.BackColor = Color.FromArgb(39, 94, 139);
            BtnCleanSFO.Cursor = Cursors.Hand;
            BtnCleanSFO.FlatAppearance.BorderSize = 0;
            BtnCleanSFO.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            BtnCleanSFO.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCleanSFO.ForeColor = Color.White;
            BtnCleanSFO.Location = new Point(251, 821);
            BtnCleanSFO.Name = "BtnCleanSFO";
            BtnCleanSFO.Size = new Size(180, 60);
            BtnCleanSFO.TabIndex = 52;
            BtnCleanSFO.Text = "CLEAR";
            BtnCleanSFO.UseVisualStyleBackColor = false;
            BtnCleanSFO.Click += BtnCleanSFO_Click;
            // 
            // btnAddSFO
            // 
            btnAddSFO.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddSFO.BackColor = Color.FromArgb(39, 94, 139);
            btnAddSFO.Cursor = Cursors.Hand;
            btnAddSFO.FlatAppearance.BorderSize = 0;
            btnAddSFO.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAddSFO.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSFO.ForeColor = Color.White;
            btnAddSFO.Location = new Point(51, 821);
            btnAddSFO.Name = "btnAddSFO";
            btnAddSFO.Size = new Size(180, 60);
            btnAddSFO.TabIndex = 51;
            btnAddSFO.Text = "ADD";
            btnAddSFO.UseVisualStyleBackColor = false;
            btnAddSFO.Click += btnAddSFO_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.Location = new Point(617, 491);
            label4.Name = "label4";
            label4.Size = new Size(214, 45);
            label4.TabIndex = 55;
            label4.Text = "CONTRACTS";
            // 
            // txtSFOID
            // 
            txtSFOID.Location = new Point(279, 555);
            txtSFOID.Name = "txtSFOID";
            txtSFOID.Size = new Size(358, 31);
            txtSFOID.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 552);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 53;
            label2.Text = "SFOpportunity";
            // 
            // txtSFOContractID
            // 
            txtSFOContractID.Location = new Point(279, 606);
            txtSFOContractID.Name = "txtSFOContractID";
            txtSFOContractID.Size = new Size(358, 31);
            txtSFOContractID.TabIndex = 57;
            txtSFOContractID.TextChanged += txtSFOContractID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 606);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 56;
            label3.Text = "ContractID";
            // 
            // txtSFOCustID
            // 
            txtSFOCustID.Location = new Point(279, 655);
            txtSFOCustID.Name = "txtSFOCustID";
            txtSFOCustID.Size = new Size(358, 31);
            txtSFOCustID.TabIndex = 59;
            txtSFOCustID.TextChanged += txtSFOCustID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 655);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 58;
            label5.Text = "CustID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(864, 555);
            label8.Name = "label8";
            label8.Size = new Size(98, 32);
            label8.TabIndex = 64;
            label8.Text = "IniDate";
            // 
            // dateTimePickerSFOIniDate
            // 
            dateTimePickerSFOIniDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerSFOIniDate.Location = new Point(981, 556);
            dateTimePickerSFOIniDate.Name = "dateTimePickerSFOIniDate";
            dateTimePickerSFOIniDate.Size = new Size(179, 31);
            dateTimePickerSFOIniDate.TabIndex = 66;
            // 
            // dateTimePickerSFOEndDate
            // 
            dateTimePickerSFOEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerSFOEndDate.Location = new Point(981, 604);
            dateTimePickerSFOEndDate.Name = "dateTimePickerSFOEndDate";
            dateTimePickerSFOEndDate.Size = new Size(179, 31);
            dateTimePickerSFOEndDate.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(864, 603);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 67;
            label6.Text = "EndDate";
            // 
            // AddContractSFOpportunity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1497, 903);
            Controls.Add(dateTimePickerSFOEndDate);
            Controls.Add(label6);
            Controls.Add(dateTimePickerSFOIniDate);
            Controls.Add(label8);
            Controls.Add(txtSFOCustID);
            Controls.Add(label5);
            Controls.Add(txtSFOContractID);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtSFOID);
            Controls.Add(label2);
            Controls.Add(BtnCleanSFO);
            Controls.Add(btnAddSFO);
            Controls.Add(label1);
            Controls.Add(dataProv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddContractSFOpportunity";
            Text = "AddContractSFOpportunity";
            ((System.ComponentModel.ISupportInitialize)dataProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataProv;
        private Button BtnCleanSFO;
        private Button btnAddSFO;
        private Label label4;
        private TextBox txtSFOID;
        private Label label2;
        private TextBox txtSFOContractID;
        private Label label3;
        private TextBox txtSFOCustID;
        private Label label5;
        private Label label8;
        private DateTimePicker dateTimePickerSFOIniDate;
        private DateTimePicker dateTimePickerSFOEndDate;
        private Label label6;
    }
}