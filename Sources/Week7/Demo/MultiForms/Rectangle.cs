namespace MultiForms;

public delegate void RectangleHandler(Rectangle rec);
public class Rectangle
{
    static int Count = 0;
    public static event RectangleHandler? Created;
    public static Rectangle CreateInstance(double wd, double lng)
    {
        Rectangle rec= new Rectangle()
        {
            Width = wd,
            Length = lng
        };
        Created?.Invoke(rec);
        return rec;
    }
    private int _no;
    public int No => _no;
    public double Width { get; set; } = 0;
    public double Length { get; set; } = 0;
    public double Area => Width * Length;
    private Rectangle() { _no = ++Count; }

}
