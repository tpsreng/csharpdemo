namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation op = new(50, 20);
            op.View(new List<Calculation>{Add, Sub, Mul, Div });
        }
        
        public static double Add(double x, double y) { return x + y; }
        public static double Sub(double x, double y) { return x - y; }
        public static double Mul(double x, double y) { return x * y; }
        public static double Div(double x, double y) { return x / y; }
    }
    
}