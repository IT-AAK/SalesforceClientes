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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtStatus = new TextBox();
            BtnClean = new Button();
            label10 = new Label();
            label4 = new Label();
            txtRFC = new TextBox();
            label3 = new Label();
            txtNameProv = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            dataProv = new DataGridView();
            checkBoxKind2 = new CheckBox();
            checkBoxKind3 = new CheckBox();
            checkBoxKind = new CheckBox();
            checkBoxKind4 = new CheckBox();
            buttonActualizarProv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProv).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Top;
            txtStatus.Location = new Point(664, 577);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(200, 31);
            txtStatus.TabIndex = 51;
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
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(570, 574);
            label10.Name = "label10";
            label10.Size = new Size(88, 32);
            label10.TabIndex = 47;
            label10.Text = "Status";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label4.Location = new Point(581, 499);
            label4.Name = "label4";
            label4.Size = new Size(334, 45);
            label4.TabIndex = 40;
            label4.Text = "DATOS PROVEEDOR";
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(212, 635);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(200, 31);
            txtRFC.TabIndex = 39;
            txtRFC.TextChanged += txtRFC_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 644);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 38;
            label3.Text = "RFC";
            // 
            // txtNameProv
            // 
            txtNameProv.Location = new Point(212, 577);
            txtNameProv.Name = "txtNameProv";
            txtNameProv.Size = new Size(200, 31);
            txtNameProv.TabIndex = 37;
            txtNameProv.TextChanged += txtNameProv_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 558);
            label2.Name = "label2";
            label2.Size = new Size(135, 64);
            label2.TabIndex = 36;
            label2.Text = "Nombre \r\nProveedor";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 64);
            label1.Name = "label1";
            label1.Size = new Size(350, 48);
            label1.TabIndex = 35;
            label1.Text = "TRANSPORTISTAS";
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
            dataProv.Location = new Point(50, 124);
            dataProv.Name = "dataProv";
            dataProv.ReadOnly = true;
            dataProv.RowHeadersVisible = false;
            dataProv.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataProv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataProv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProv.Size = new Size(1397, 361);
            dataProv.TabIndex = 33;
            dataProv.CellContentClick += dataProv_CellContentClick;
            // 
            // checkBoxKind2
            // 
            checkBoxKind2.AutoSize = true;
            checkBoxKind2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxKind2.Location = new Point(995, 631);
            checkBoxKind2.Name = "checkBoxKind2";
            checkBoxKind2.Size = new Size(122, 32);
            checkBoxKind2.TabIndex = 55;
            checkBoxKind2.Text = "PIPAS PT";
            checkBoxKind2.UseVisualStyleBackColor = true;
            checkBoxKind2.CheckedChanged += checkBoxKind2_CheckedChanged;
            // 
            // checkBoxKind3
            // 
            checkBoxKind3.AutoSize = true;
            checkBoxKind3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxKind3.Location = new Point(1181, 577);
            checkBoxKind3.Name = "checkBoxKind3";
            checkBoxKind3.Size = new Size(171, 32);
            checkBoxKind3.TabIndex = 56;
            checkBoxKind3.Text = "CAJA SECA PT";
            checkBoxKind3.UseVisualStyleBackColor = true;
            checkBoxKind3.CheckedChanged += checkBoxKind3_CheckedChanged_1;
            // 
            // checkBoxKind
            // 
            checkBoxKind.AutoSize = true;
            checkBoxKind.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxKind.Location = new Point(993, 576);
            checkBoxKind.Name = "checkBoxKind";
            checkBoxKind.Size = new Size(129, 32);
            checkBoxKind.TabIndex = 57;
            checkBoxKind.Text = "PIPAS MP";
            checkBoxKind.UseVisualStyleBackColor = true;
            checkBoxKind.CheckedChanged += checkBoxKind_CheckedChanged;
            // 
            // checkBoxKind4
            // 
            checkBoxKind4.AutoSize = true;
            checkBoxKind4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxKind4.Location = new Point(1181, 631);
            checkBoxKind4.Name = "checkBoxKind4";
            checkBoxKind4.Size = new Size(119, 32);
            checkBoxKind4.TabIndex = 58;
            checkBoxKind4.Text = "JUMBOS";
            checkBoxKind4.UseVisualStyleBackColor = true;
            checkBoxKind4.CheckedChanged += checkBoxKind4_CheckedChanged;
            // 
            // buttonActualizarProv
            // 
            buttonActualizarProv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonActualizarProv.BackColor = Color.FromArgb(39, 94, 139);
            buttonActualizarProv.Cursor = Cursors.Hand;
            buttonActualizarProv.FlatAppearance.BorderSize = 0;
            buttonActualizarProv.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            buttonActualizarProv.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonActualizarProv.ForeColor = Color.White;
            buttonActualizarProv.Location = new Point(453, 810);
            buttonActualizarProv.Name = "buttonActualizarProv";
            buttonActualizarProv.Size = new Size(180, 60);
            buttonActualizarProv.TabIndex = 59;
            buttonActualizarProv.Text = "ACTUALIZAR";
            buttonActualizarProv.UseVisualStyleBackColor = false;
            buttonActualizarProv.Click += buttonActualizarProv_Click;
            // 
            // proveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1497, 903);
            Controls.Add(buttonActualizarProv);
            Controls.Add(checkBoxKind4);
            Controls.Add(checkBoxKind);
            Controls.Add(checkBoxKind3);
            Controls.Add(checkBoxKind2);
            Controls.Add(txtStatus);
            Controls.Add(BtnClean);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(txtRFC);
            Controls.Add(label3);
            Controls.Add(txtNameProv);
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
        private TextBox txtStatus;
        private Button BtnClean;
        private Label label10;
        private Label label4;
        private TextBox txtRFC;
        private Label label3;
        private TextBox txtNameProv;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private DataGridView dataProv;
        private CheckBox checkBoxKind2;
        private CheckBox checkBoxKind3;
        private CheckBox checkBoxKind;
        private CheckBox checkBoxKind4;
        private Button buttonActualizarProv;
    }
}