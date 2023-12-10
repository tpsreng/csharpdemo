namespace MultiForms
{
    partial class CreateForm
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
            label1 = new Label();
            txtWidth = new TextBox();
            txtLength = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(22, 75);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(94, 27);
            txtWidth.TabIndex = 1;
            txtWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(133, 75);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(94, 27);
            txtLength.TabIndex = 3;
            txtLength.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Length";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(22, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(133, 113);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 149);
            Controls.Add(btnCreate);
            Controls.Add(btnClear);
            Controls.Add(txtLength);
            Controls.Add(label2);
            Controls.Add(txtWidth);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Text = "Creating Rectangles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWidth;
        private TextBox txtLength;
        private Label label2;
        private Button btnClear;
        private Button btnCreate;
    }
}