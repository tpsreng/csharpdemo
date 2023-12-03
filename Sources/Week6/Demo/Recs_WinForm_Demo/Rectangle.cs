using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recs_WinForm_Demo
{
    public class Rectangle
    {
        static int Count = 0;

        public static Rectangle CreateInstance(double wd, double lng)
        {
            return new Rectangle()
            {
                Width = wd,
                Length = lng
            };
        }
        private int _no;
        public int No => _no;
        public double Width { get; set; } = 0;
        public double Length { get; set; } = 0; 
        public double Area => Width * Length;
        private Rectangle() { _no = ++Count; }

    }
}
