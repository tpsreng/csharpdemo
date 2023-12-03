namespace Recs_WinForm_Demo
{
    public partial class Form1 : Form
    {
        private DataGridViewRow? curRow = null;
        public Form1()
        {
            InitializeComponent();
            ConfigGridView();
            
            btnRefresh.Click += (object? sender, EventArgs e) =>
            {
                dgvRecs.Rows.Clear();
                curRow = null;
                Program.Recs.ForEach(rect =>
                {
                    dgvRecs.Rows.Add(rect.No, rect.Width, rect.Length, rect.Area);
                });
            };

            btnGridRemove.Click += (object? sender, EventArgs e) =>
            {
                if (dgvRecs.CurrentRow == null) return;
                dgvRecs.Rows.Remove(dgvRecs.CurrentRow);
            };

            btnDataRemove.Click += (object? sender, EventArgs e) =>
            {
                if (dgvRecs.CurrentRow == null) return;
                int? no = (int?)dgvRecs.CurrentRow.Cells["colNo"].Value;
                Rectangle? removed = Program.Recs.FirstOrDefault(rect => rect.No == no);
                if (removed!=null && Program.Recs.Remove(removed))
                {
                    Task.Run(()=>MessageBox.Show($"A rectangle no, {removed.No}, was successfully removed"));
                    ViewCurrentRectangle();
                }
            };

            btnRemoveBoth.Click += (object? sender, EventArgs e) =>
            {
                if (dgvRecs.CurrentRow == null) return;
                Rectangle removed = Program.Recs[dgvRecs.CurrentRow.Index];
                if (Program.Recs.Remove(removed))
                {
                    dgvRecs.Rows.Remove(dgvRecs.CurrentRow);
                }
            };

            dgvRecs.SelectionChanged += (object? sender, EventArgs e) =>
            {
                if (dgvRecs.CurrentRow != curRow) ViewCurrentRectangle();
            };
        }
        private void ViewCurrentRectangle()
        {
            curRow = dgvRecs.CurrentRow;
            int? no = (int?)curRow?.Cells["colNo"].Value;
            Rectangle? curRec = Program.Recs.FirstOrDefault(rect => rect.No == no);
            txtNo.Text = curRec?.No.ToString();
            txtWidth.Text = curRec?.Width.ToString();
            txtLength.Text = curRec?.Length.ToString();
            txtArea.Text = curRec?.Area.ToString();
        }
 
        void ConfigGridView()
        {
            dgvRecs.Columns.Clear();
            dgvRecs.Columns.Add("colNo", "No");
            dgvRecs.Columns.Add("colWidth", "Width");
            dgvRecs.Columns.Add("colLength", "Length");
            dgvRecs.Columns.Add("colArea", "Area");

            foreach(DataGridViewColumn col in dgvRecs.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (col.Name == "colNo") continue;
                col.DefaultCellStyle.Format = "N2";
            }
            dgvRecs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

    }
}
