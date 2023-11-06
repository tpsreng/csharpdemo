namespace StandardInputOutput;
class Program
{
    static void Main(string[] args)
    {
        //Test1();
        Test2();
    }
    static void Test2()
    {
        Console.WriteLine("Input data...");
        Console.Write($">{"Name",-10}: ");
        string? name = Console.ReadLine();

        Console.Write($">{"Age", -10}: ");
        int age = Int32.Parse(Console.ReadLine() ?? "");

        Console.Write($"<{"Height",-10}: ");
        float hgt = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine();
        Console.WriteLine("Output Information...");
        Console.WriteLine($">{"Name",-10}: {name}");
        Console.WriteLine($">{"Age",-10}: {age}");
        Console.WriteLine($">{"Height",-10}: {hgt}");
    }
    static void Test1()
    {
        Console.Write("Input a name  : ");
        string? name = Console.ReadLine();

        Console.Write("Input an age  : ");
        int age = Int32.Parse(Console.ReadLine() ?? "");

        Console.Write("Input a height: ");
        float hgt = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"{"Name",-10}: {name}");
        Console.WriteLine($"{"Age",-10}: {age}");
        Console.WriteLine($"{"Height",-10}: {hgt}");
    }
}
