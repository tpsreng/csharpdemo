namespace RecsInput;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rectangles' data (width & length separated by space, eg. 2 5)");
        
        string result = "";
        double totalArea = 0.0;
        int count = 0;
        while (true)
        {
            Console.Write($"[{count + 1}] : ");
            var line = Console.ReadLine();
            if (line == null) break;
            var data = line.Split(' ');
            if (data.Length < 2) break;
            if (double.TryParse(data[0], out double width)==false) continue;
            if(double.TryParse(data[1], out double length)==false) continue;
            count++;
            double area = width * length;
            totalArea += area;
            var lineInfo = $"{count,10} {width,10:n2} {length,10:n2} {area,10:n2}";
            if (result != "") result += "\n";
            result += lineInfo;
        }
        if (count == 0) return;
        string heading = $"{"no",10} {"width",10} {"length",10} {"area",10}";
        string bar = new string('-', 43);
        Console.WriteLine();
        Console.WriteLine(heading);
        Console.WriteLine(bar); 
        Console.WriteLine(result);
        Console.WriteLine(bar);
        var totalText = $"Total:{totalArea:n2}";
        Console.WriteLine($"{totalText,43}");

    }
}
