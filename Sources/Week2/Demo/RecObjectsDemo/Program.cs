using System.Reflection.Metadata.Ecma335;

namespace RecObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countWidth = 6;
            Rectangle.FieldWidth = 15;
            Rectangle.DecimalPoint = 5;
            Rectangle rec = new();

            Console.WriteLine("Rectangles");
            Console.WriteLine("Input width and length separated by space (eg. 2 5) or empty to stop.");
            
            var result = "";
            var totalArea = 0.0;
            var count = 0;
            while (true)
            {
                Console.Write($"[{count + 1}]: ");
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                if (rec.SetData(line) == false) continue;
                
                totalArea += rec.GetArea();
                count++;
                var subResult =string.Format($"{{0,{countWidth}}} {{1}}", count, rec.GetInfo());
                if (result != "") result += "\n";
                result += subResult;
            }
            
            if (count == 0) return;
            
            string heading = string.Format($"{{0,{countWidth}}} ", "no") + Rectangle.GetHeading();
            string bar = new string('-', countWidth + 1) + Rectangle.GetBar('-');
            string totalFormat = $"Total:{{0:N{Rectangle.DecimalPoint}}}";
            var totalText = string.Format($"{{0,{bar.Length}}}",string.Format(totalFormat, totalArea));

            Console.WriteLine();
            Console.WriteLine(heading);
            Console.WriteLine(bar);
            Console.WriteLine(result);
            Console.WriteLine(bar);
            Console.WriteLine(totalText);
        }
    }
}