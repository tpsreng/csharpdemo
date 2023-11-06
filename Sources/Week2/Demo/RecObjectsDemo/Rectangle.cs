namespace RecObjectsDemo
{
    public class Rectangle
    {
        #region static members
        //static fields
        public static int FieldWidth = 8;
        public static int DecimalPoint = 2;
       
        //static metnods
        public static string GetHeading()
        {
            string nameText = string.Format($"{{0,{FieldWidth}}}", "width");
            string genderText = string.Format($"{{0,{FieldWidth}}}", "length");
            string ageText = string.Format($"{{0, {FieldWidth}}}", "area");
            return $"{nameText} {genderText} {ageText}";
        }

        public static string GetBar(char c = '-')
        {
            return new string(c, FieldWidth * 3 + 2);
        }
        #endregion

        #region instance members
        //instance fields
        protected double _width = 0.0;
        protected double _length = 0.0;
        protected double _area = 0.0;
        protected bool _isAreaToUpdate = false;

        //instance constructors
        public Rectangle() { }
        public Rectangle(double width, double length)
        {
            _width = width;
            _length = length;
            _isAreaToUpdate = true;
        }
        
        //instance methods
        public double GetWidth() { return _width; }

        public double GetLength() { return _length; }
 
        public double GetArea() 
        {  
            if (_isAreaToUpdate) _area = _width * _length;
            return  _area; } 
       
        public bool SetData(string data, string separator=" ")
        {
            string[] sides = data.Split(separator);
            if (sides.Length < 2) return false;
            if (double.TryParse(sides[0], out double wd)==false) return false;
            if(double.TryParse(sides[1], out double lng)==false) return false;
            _width = wd;
            _length = lng;
            _isAreaToUpdate = true;
            return true;
        }

        public string GetInfo()
        {
            string format ="{0," + $"{FieldWidth}:N{DecimalPoint}" +"}";
            string wdInfo = string.Format(format, GetWidth());
            string lngInfo = string.Format(format, GetLength());
            string areaInfo = string.Format(format, GetArea());
            return $"{wdInfo} {lngInfo} {areaInfo}";
        }
        #endregion
    }
}