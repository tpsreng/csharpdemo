using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            btnClear.Click += (sender, e) => { txtWidth.Clear(); txtLength.Clear(); };
            btnCreate.Click += DoClickCreate;
        }

        private void DoClickCreate(object? sender, EventArgs e)
        {
            List<string> messages = new();
            if (double.TryParse(txtWidth.Text, out double wd) == false)
            {
                messages.Add($"Invalid width, {txtWidth.Text}");
            }
            if (double.TryParse(txtLength.Text, out double lng) == false)
            {
                messages.Add($"Invalid Length, {txtWidth.Text}");
            }
            if (messages.Count > 0)
            {
                string msg = messages.Aggregate((a, b) => a + "\n" + b);
                MessageBox.Show(msg, "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Rectangle rec = Rectangle.CreateInstance(wd, lng);
            MessageBox.Show($"A rectangle no, {rec.No}, was successfully created", "Creating",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
