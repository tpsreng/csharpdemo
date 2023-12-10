namespace MultiForms
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvRecs = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCount = new TextBox();
            txtTotal = new TextBox();
            label2 = new Label();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecs).BeginInit();
            SuspendLayout();
            // 
            // dgvRecs
            // 
            dgvRecs.AllowUserToAddRows = false;
            dgvRecs.AllowUserToDeleteRows = false;
            dgvRecs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRecs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecs.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvRecs.Location = new Point(12, 80);
            dgvRecs.Name = "dgvRecs";
            dgvRecs.ReadOnly = true;
            dgvRecs.RowHeadersWidth = 51;
            dgvRecs.RowTemplate.Height = 29;
            dgvRecs.Size = new Size(473, 358);
            dgvRecs.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 58;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Width";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 78;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Length";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 83;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Area";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Rectangles";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(103, 14);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(70, 27);
            txtCount.TabIndex = 2;
            txtCount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(102, 48);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(113, 27);
            txtTotal.TabIndex = 3;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Area Total";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(493, 121);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(495, 162);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(494, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 452);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(txtCount);
            Controls.Add(label1);
            Controls.Add(dgvRecs);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Rectangles";
            ((System.ComponentModel.ISupportInitialize)dgvRecs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRecs;
        private Label label1;
        private TextBox txtCount;
        private TextBox txtTotal;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
    }
}
