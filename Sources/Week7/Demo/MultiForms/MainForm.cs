
namespace MultiForms;

public partial class MainForm : Form
{
    List<Rectangle> _recs= new List<Rectangle>();
    List<Rectangle> _editing = new();
    public MainForm()
    {
        InitializeComponent();
        Rectangle.Created += (rec) =>
        {
            _recs.Add(rec);
            AddRecToView(rec);
        };
        LoadRectangles();
        

        btnNew.Click += (sender, e) => new CreateForm().Show();
        btnEdit.Click += DoClickEdit;
        btnDelete.Click += DoClickDelete;
    }

    private void DoClickDelete(object? sender, EventArgs e)
    {
        if (dgvRecs.CurrentRow == null) return;
        Rectangle? rec = _recs.FirstOrDefault(r => r.No == (int)dgvRecs.CurrentRow.Cells[0].Value);
        if (rec == null) return;
        if (_editing.Contains(rec))
        {
            MessageBox.Show($"The rectangle no, {rec.No}, is currently being edited?", "Deleting",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        var result = MessageBox.Show($"Are you sure to delete a rectangle no, {rec.No}?", "Deleting",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No) return;
        if (_recs.Remove(rec))
        {
            dgvRecs.Rows.Remove(dgvRecs.CurrentRow);
            ViewOverallInfo();
        }
    }

    private void DoClickEdit(object? sender, EventArgs e)
    {
        if (dgvRecs.CurrentRow == null) return;
        Rectangle? rec = _recs.FirstOrDefault(r => r.No == (int)dgvRecs.CurrentRow.Cells[0].Value);
        if (rec == null) return;
        EditForm frm = new EditForm(rec);
        frm.Updated += DoOnRecUpdated;
        frm.Show();
        _editing.Add(rec);
        frm.FormClosed += (sender, e) => _editing.Remove(rec);
    }

    private void DoOnRecUpdated(EditForm sender, Rectangle rec)
    {
        foreach(DataGridViewRow row in dgvRecs.Rows)
        {
            if ( rec.No==(int)row.Cells[0].Value)
            {
                row.SetValues(rec.No, rec.Width, rec.Length, rec.Area);
                ViewOverallInfo();
                break;
            }
        }
        
    }

    private void ViewOverallInfo()
    {
        txtCount.Text = _recs.Count.ToString();
        txtTotal.Text = _recs.Sum(rec => rec.Area).ToString("N2");
    }
    private void LoadRectangles()
    {
        _recs.Clear();
        string[] lines = File.ReadAllLines("recs.txt");
        foreach(string line in lines)
        {
            List<double>? sides = line.ToValues();
            if (sides == null) continue;
            if (sides.Count < 2) continue;
            Rectangle.CreateInstance(sides[0], sides[1]);
        }
    }
    private void AddRecToView(Rectangle rec)
    {
        dgvRecs.Rows.Add(rec.No, rec.Width, rec.Length, rec.Area);
        ViewOverallInfo();
    }
}
