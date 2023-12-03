namespace Recs_WinForm_Demo
{
    partial class Form1
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
            btnRefresh = new Button();
            dgvRecs = new DataGridView();
            btnGridRemove = new Button();
            btnDataRemove = new Button();
            btnRemoveBoth = new Button();
            groupBox1 = new GroupBox();
            txtArea = new TextBox();
            label4 = new Label();
            txtLength = new TextBox();
            label3 = new Label();
            txtWidth = new TextBox();
            label2 = new Label();
            txtNo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 30);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvRecs
            // 
            dgvRecs.AllowUserToAddRows = false;
            dgvRecs.AllowUserToDeleteRows = false;
            dgvRecs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecs.Location = new Point(15, 52);
            dgvRecs.Name = "dgvRecs";
            dgvRecs.ReadOnly = true;
            dgvRecs.RowHeadersWidth = 51;
            dgvRecs.RowTemplate.Height = 29;
            dgvRecs.Size = new Size(420, 253);
            dgvRecs.TabIndex = 1;
            // 
            // btnGridRemove
            // 
            btnGridRemove.Location = new Point(454, 52);
            btnGridRemove.Name = "btnGridRemove";
            btnGridRemove.Size = new Size(130, 72);
            btnGridRemove.TabIndex = 2;
            btnGridRemove.Text = "Remove From Gridview";
            btnGridRemove.UseVisualStyleBackColor = true;
            // 
            // btnDataRemove
            // 
            btnDataRemove.Location = new Point(454, 143);
            btnDataRemove.Name = "btnDataRemove";
            btnDataRemove.Size = new Size(130, 72);
            btnDataRemove.TabIndex = 3;
            btnDataRemove.Text = "Remove From Data";
            btnDataRemove.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBoth
            // 
            btnRemoveBoth.Location = new Point(454, 230);
            btnRemoveBoth.Name = "btnRemoveBoth";
            btnRemoveBoth.Size = new Size(130, 72);
            btnRemoveBoth.TabIndex = 4;
            btnRemoveBoth.Text = "Remove Both";
            btnRemoveBoth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLength);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtWidth);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 93);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Rectangle";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(322, 48);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(88, 27);
            txtArea.TabIndex = 7;
            txtArea.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 24);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "Area";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(217, 48);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(88, 27);
            txtLength.TabIndex = 5;
            txtLength.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 24);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Length";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(110, 48);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(88, 27);
            txtWidth.TabIndex = 3;
            txtWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Width";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(12, 47);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(88, 27);
            txtNo.TabIndex = 1;
            txtNo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 418);
            Controls.Add(groupBox1);
            Controls.Add(btnRemoveBoth);
            Controls.Add(btnDataRemove);
            Controls.Add(btnGridRemove);
            Controls.Add(dgvRecs);
            Controls.Add(btnRefresh);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Rectangles";
            ((System.ComponentModel.ISupportInitialize)dgvRecs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvRecs;
        private Button btnGridRemove;
        private Button btnDataRemove;
        private Button btnRemoveBoth;
        private GroupBox groupBox1;
        private TextBox txtArea;
        private Label label4;
        private TextBox txtLength;
        private Label label3;
        private TextBox txtWidth;
        private Label label2;
        private TextBox txtNo;
        private Label label1;
    }
}
