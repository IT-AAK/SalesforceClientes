namespace Clientes
{
    partial class ViewContractSFOpportunity
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
            dataViewContractSFO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataViewContractSFO).BeginInit();
            SuspendLayout();
            // 
            // dataViewContractSFO
            // 
            dataViewContractSFO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataViewContractSFO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataViewContractSFO.BackgroundColor = Color.White;
            dataViewContractSFO.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataViewContractSFO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataViewContractSFO.ColumnHeadersHeight = 50;
            dataViewContractSFO.EnableHeadersVisualStyles = false;
            dataViewContractSFO.Location = new Point(50, 55);
            dataViewContractSFO.Name = "dataViewContractSFO";
            dataViewContractSFO.ReadOnly = true;
            dataViewContractSFO.RowHeadersVisible = false;
            dataViewContractSFO.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataViewContractSFO.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataViewContractSFO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataViewContractSFO.Size = new Size(1392, 672);
            dataViewContractSFO.TabIndex = 34;
            dataViewContractSFO.CellContentClick += dataViewContractSFO_CellContentClick;
            // 
            // ViewContractSFOpportunity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1497, 903);
            Controls.Add(dataViewContractSFO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewContractSFOpportunity";
            Text = "ViewContractSFOpportunity";
            ((System.ComponentModel.ISupportInitialize)dataViewContractSFO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewContractSFO;
    }
}