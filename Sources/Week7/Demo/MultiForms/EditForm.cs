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
    public delegate void UpdatedHandler(EditForm sender, Rectangle rec);
    public partial class EditForm : Form
    {
        public event UpdatedHandler? Updated;
        Rectangle _rec = default!;
        public EditForm(Rectangle rec)
        {
            InitializeComponent();
            _rec = rec;
            ViewCurRectangle();
            btnCancel.Click += (sender, e) => ViewCurRectangle();
            btnUpdate.Click += DoClickUpdate;
        }

        private void DoClickUpdate(object? sender, EventArgs e)
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
                MessageBox.Show(msg, "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _rec.Width = wd;
            _rec.Length = lng;
            Updated?.Invoke(this, _rec);
            MessageBox.Show($"A rectangle no, {_rec.No}, was successfully updated", "Updating",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewCurRectangle()
        {
            txtWidth.Text = _rec.Width.ToString();
            txtLength.Text = _rec.Length.ToString();
        }
    }
}
