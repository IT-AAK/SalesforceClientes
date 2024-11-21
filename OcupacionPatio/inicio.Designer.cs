namespace Clientes
{
    partial class inicio
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataDisponibilidad = new DataGridView();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataDisponibilidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(463, 55);
            label1.Name = "label1";
            label1.Size = new Size(307, 48);
            label1.TabIndex = 0;
            label1.Text = "DISPONIBILIDAD";
            // 
            // dataDisponibilidad
            // 
            dataDisponibilidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataDisponibilidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDisponibilidad.BackgroundColor = Color.White;
            dataDisponibilidad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataDisponibilidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataDisponibilidad.ColumnHeadersHeight = 65;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataDisponibilidad.DefaultCellStyle = dataGridViewCellStyle2;
            dataDisponibilidad.EnableHeadersVisualStyles = false;
            dataDisponibilidad.Location = new Point(12, 140);
            dataDisponibilidad.Name = "dataDisponibilidad";
            dataDisponibilidad.ReadOnly = true;
            dataDisponibilidad.RowHeadersVisible = false;
            dataDisponibilidad.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(39, 94, 139);
            dataDisponibilidad.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataDisponibilidad.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataDisponibilidad.Size = new Size(1221, 578);
            dataDisponibilidad.TabIndex = 1;
            dataDisponibilidad.CellContentClick += dataGridView1_CellContentClick;
            // 
            // timer2
            // 
            timer2.Interval = 60000;
            timer2.Tick += timer2_Tick;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1245, 737);
            Controls.Add(dataDisponibilidad);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inicio";
            Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)dataDisponibilidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataDisponibilidad;
        private System.Windows.Forms.Timer timer2;
    }
}