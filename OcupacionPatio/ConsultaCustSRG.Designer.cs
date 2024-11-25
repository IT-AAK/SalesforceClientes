namespace Clientes
{
    partial class ConsultaCustSRG
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
            dataConsultaCustSRG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataConsultaCustSRG).BeginInit();
            SuspendLayout();
            // 
            // dataConsultaCustSRG
            // 
            dataConsultaCustSRG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataConsultaCustSRG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataConsultaCustSRG.BackgroundColor = Color.White;
            dataConsultaCustSRG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataConsultaCustSRG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataConsultaCustSRG.ColumnHeadersHeight = 50;
            dataConsultaCustSRG.EnableHeadersVisualStyles = false;
            dataConsultaCustSRG.Location = new Point(53, 44);
            dataConsultaCustSRG.Name = "dataConsultaCustSRG";
            dataConsultaCustSRG.ReadOnly = true;
            dataConsultaCustSRG.RowHeadersVisible = false;
            dataConsultaCustSRG.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataConsultaCustSRG.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataConsultaCustSRG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataConsultaCustSRG.Size = new Size(1392, 672);
            dataConsultaCustSRG.TabIndex = 33;
            dataConsultaCustSRG.CellContentClick += dataConsultaCustSRG_CellContentClick;
            // 
            // ConsultaCustSRG
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1497, 903);
            Controls.Add(dataConsultaCustSRG);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultaCustSRG";
            Text = "ConsultaCustSRG";
            ((System.ComponentModel.ISupportInitialize)dataConsultaCustSRG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataConsultaCustSRG;
    }
}