using System.Windows.Markup;

namespace Prop_Event_Demo;

internal class Program
{
    static List<Rectangle> ModifiedRecs = new();
    static void Main(string[] args)
    {
        
        //Creating and initializing a list of rectangles
        List<Rectangle> recs = new List<Rectangle> 
        { new(4, 6)
        , new(3, 7)
        , new(2, 9)
        , new(5, 8)
        , new(6, 7)
        , new(3, 10)
        };

        //Subcripting for every rectangle's event DataModified
        recs.ForEach(r => r.DataModified += (r) => 
        { 
            ModifiedRecs.Add(r);
            Console.WriteLine($"The rectangle, {r.No}, was modified");
        });
        
        //Viewing rectangles
        ViewRectangles(recs);
        Pause();

        //Modifying 3 rectangles
        recs[0].Data = new List<double> { 4, 8 };
        recs[3].Width = 2;
        recs[5].Length = 12;
        Pause();

        //Viewing Rectangles
        ViewRectangles(recs);
    }
    static void Pause()
    {
        Console.Write("Press any key continue...");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine();
        
    }
    static void ViewRectangles(List<Rectangle> recs)
    {
        ConsoleColor color = Console.BackgroundColor;
        ConsoleColor modColor = ConsoleColor.DarkRed;
        Console.WriteLine(Rectangle.GetHeading());
        string bar = Rectangle.GetBar('-');
        Console.WriteLine(bar);
        recs.ForEach((r) =>
        {
            Console.BackgroundColor = (ModifiedRecs.Contains(r)) ? modColor : color;
            Console.WriteLine(r.Info);
        });
        Console.BackgroundColor = color;
        Console.WriteLine(bar);
        string areaTotal = string.Format("Area Total:{0:N3}", recs.Sum(r => r.Area));
        Console.WriteLine(string.Format($"{{0,{bar.Length}}}", areaTotal));

        ModifiedRecs.Clear();
    }
}
