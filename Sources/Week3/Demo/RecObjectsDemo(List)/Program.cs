using System.Reflection.Metadata.Ecma335;

namespace RecObjectsDemo
{
    internal class Program
    {
        static int countWidth = 6;
        static void Main(string[] args)
        {
            Rectangle.FieldWidth = 15;
            Rectangle.DecimalPoint = 3;

            List<Rectangle> recs = GetInputRecs();
            Console.Write("Press any key to see the output");
            Console.ReadKey();
            ShowRecs(recs);

            if (recs.Count > 0)
            {
                Console.Write("Press any key continue");
                Console.ReadKey();
                int no = -1;
                while (true)
                {
                    Console.Write("\nRectangle number to be removed: ");
                    if (int.TryParse(Console.ReadLine(), out no) == false)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    if (no-1 > 0 && no-1 < recs.Count) break;
                    Console.WriteLine($"Number must in [1, {recs.Count}]");
                }
                recs.RemoveAt(no-1);
                Console.WriteLine($"A rectangle number, {no}, was removed");
                ShowRecs(recs);
            }

        }
        private static List<Rectangle> GetInputRecs()
        {
            Console.WriteLine("Rectangles");
            Console.WriteLine("Input width and length separated by space (eg. 2 5) or empty to stop.");

            List<Rectangle> recs = new List<Rectangle>();
            var count = 0;
            while (true)
            {
                Console.Write($"[{count + 1}]: ");
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                Rectangle rec = new();
                if (rec.SetData(line) == false) continue;
                recs.Add(rec);
            }
            return recs;
        }

        private static void ShowRecs(List<Rectangle> recs)
        {
            if (recs.Count == 0)
                Console.WriteLine("No rectangles to be shown out");
            double total = 0;
            string result = "";
            for(int index=0; index<recs.Count; index++)
            {
                Rectangle rec = recs[index];
                total += rec.GetArea();
                string line = string.Format($"{{0,{countWidth}}} {{1}}", index+1, rec.GetInfo());
                if (result != "") result += "\n";
                result += line;
            }
            string heading = string.Format($"{{0,{countWidth}}} ", "no") + Rectangle.GetHeading();
            string bar = new string('-', countWidth + 1) + Rectangle.GetBar('-');
            string totalFormat = $"Total:{{0:N{Rectangle.DecimalPoint}}}";
            var totalText = string.Format($"{{0,{bar.Length}}}", string.Format(totalFormat, total));

            Console.WriteLine();
            Console.WriteLine(heading);
            Console.WriteLine(bar);
            Console.WriteLine(result);
            Console.WriteLine(bar);
            Console.WriteLine(totalText);
        }
    }
}