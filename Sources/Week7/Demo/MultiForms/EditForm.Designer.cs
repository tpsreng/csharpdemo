namespace MultiForms
{
    partial class EditForm
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
            btnUpdate = new Button();
            btnCancel = new Button();
            txtLength = new TextBox();
            label2 = new Label();
            txtWidth = new TextBox();
            label1 = new Label();
            txtNo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(228, 70);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(94, 27);
            txtLength.TabIndex = 9;
            txtLength.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Length";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(117, 70);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(94, 27);
            txtWidth.TabIndex = 7;
            txtWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Width";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(12, 70);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(94, 27);
            txtNo.TabIndex = 13;
            txtNo.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 12;
            label3.Text = "No";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 157);
            Controls.Add(txtNo);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(txtLength);
            Controls.Add(label2);
            Controls.Add(txtWidth);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            Text = "Editing Rectangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtLength;
        private Label label2;
        private TextBox txtWidth;
        private Label label1;
        private TextBox txtNo;
        private Label label3;
    }
}