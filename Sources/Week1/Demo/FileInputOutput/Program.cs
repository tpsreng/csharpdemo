internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Application to input from and output to files");
        string inputFile = "in.txt";
        string outputFile = "out.txt";

        Console.WriteLine($"Reading \"name\" and \"universitity\" from {inputFile}...");
        var stdIn = Console.In;
        Console.SetIn(File.OpenText(inputFile)); 
        string name = Console.ReadLine()??"(NA)";
        string university = Console.ReadLine() ?? "(NA)";

        var stdOut = Console.Out; 
        Console.WriteLine($"Writing a line to {outputFile}...");
        Console.SetOut(File.CreateText(outputFile));
        string result = $"Hello {name} from {university}.";
        Console.WriteLine(result);
        Console.Out.Close();

        Console.SetOut(stdOut);
        Console.SetIn(stdIn);
        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }
}