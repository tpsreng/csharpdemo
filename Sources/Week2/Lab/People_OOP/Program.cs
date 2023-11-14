using People_OOP.Models;

namespace People_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datafile = "people.txt";
            if (File.Exists(datafile) == false)
            {
                Console.WriteLine($"Data file, {datafile} does not exist");
                return;
            }
            Console.SetIn(new StreamReader(datafile));

            int count = 0;
            int lines = 0;
            string result = "";
            while (true)
            {
                lines++;
                Console.Write($"Reading line {lines}...");
                string? data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    Console.WriteLine(">Nothing");
                    break;
                }
                Person p = new Person();
                if (p.SetData(data, "/") == false)
                {
                    Console.WriteLine(">Invalid");
                    continue;
                }
                Console.WriteLine(">Ok");
                count++;
                if (result != "") result += "\n";
                result += p.GetInfo();
            }
            Console.WriteLine();
            Console.WriteLine(Person.GetHeading());
            Console.WriteLine(Person.GetBar());
            Console.WriteLine(result);
            Console.WriteLine(Person.GetBar());
        }
    }
}