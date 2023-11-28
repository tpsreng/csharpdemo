namespace Prop_Event_Demo;

public class Rectangle
{
    #region static members
    private static int Instances = 0;
    //static RW properties
    public static int FieldWidth { get; set; } = 8;
    public static int DecimalPoint { get; set; } = 2;

    //static methods
    public static string GetHeading()
    {
        string noText = string.Format($"{{0,{FieldWidth}}}", "no");
        string nameText = string.Format($"{{0,{FieldWidth}}}", "width");
        string genderText = string.Format($"{{0,{FieldWidth}}}", "length");
        string ageText = string.Format($"{{0, {FieldWidth}}}", "area");
        return $"{noText} {nameText} {genderText} {ageText}";
    }

    public static string GetBar(char c = '-')
    {
        return new string(c, FieldWidth * 4 + 3);
    }
    #endregion

    #region instance members
    //instance events
    public RectangleHandler? DataModified = null;

    //instance fields
    protected int _no = 0;
    protected double _width = 0.0;
    protected double _length = 0.0;

    //instance constructors
    public Rectangle() { _no = ++Instances; }
    public Rectangle(double width, double length)
    {
        _no = ++Instances;
        _width = width;
        _length = length;
    }
    
    //Instance RW properties
    public double Width
    {
        get { return _width; }
        set { _width = value; DataModified?.Invoke(this); }
    }
    public double Length
    {
        get { return _length; }
        set { _length = value; DataModified?.Invoke(this); }
    }

    //Write-only property
    public List<double> Data
    {
        set
        {
            if (value.Count < 2) return;
            _width = value[0];
            _length = value[1];
            DataModified?.Invoke(this);
        }
    }
    
    //Read-only properties
    public int No { get { return _no; } }
    public double Area { get { return _width * _length; } }
    public string Info
    {
        get
        {
            string format = "{0," + $"{FieldWidth}:N{DecimalPoint}" + "}";
            string noInfo = string.Format($"{{0,{FieldWidth}}}", _no);
            string wdInfo = string.Format(format, _width);
            string lngInfo = string.Format(format, _length);
            string areaInfo = string.Format(format, Area);
            return $"{noInfo} {wdInfo} {lngInfo} {areaInfo}";
        }
    }
    #endregion
}
