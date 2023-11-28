
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Action_Func_Demo;

class Program
{
    static void Main(string[] args)
    {
        #region Getting rectangles where their data are from file
        var stdIn = Console.In;
        Console.SetIn(File.OpenText("recs.txt"));
        List<Rectangle> recs = new List<Rectangle>();
        while (true)
        {
            string data = Console.ReadLine();
            if (data == null) break;
            Rectangle rec = new();
            if (rec.SetData(data, "/")) recs.Add(rec);
        }
        Console.SetIn(stdIn);
        #endregion

        #region Viewing Rectangles> Action<T> with a method
        Action<Rectangle> view = ViewRectangle;
        foreach (Rectangle r in recs) view(r);
        #endregion
        Pause();

        #region Viewing Rectangles> Action<T> with anonymous method
        Action<Rectangle> view2 = delegate (Rectangle r) { Console.WriteLine(r.GetInfo()); };
        foreach (Rectangle r in recs) view(r);
        #endregion
        Pause();

        #region Viewing Rectangles> Lambda expression as argument of a paramter typed of Action<T>
        recs.ForEach(
            (r) => Console.WriteLine(r.GetInfo())
        );
        #endregion
        Pause();

        #region Area Total> Func<T, TResult> with anonymous method
        Func<Rectangle, double> func = delegate (Rectangle r){ return r.GetArea(); };
        double? totalArea = recs.Sum(func);
        Console.WriteLine($"Area Total: {totalArea:N3}");
        #endregion
        Pause();

        #region Area Total> Lambda expression as argument of a paramter typed of Func<T, TResult>
        double? totalArea2 = recs.Sum(r=>r.GetArea());
        Console.WriteLine($"Area Total: {totalArea2:N3}");
        #endregion
        Pause();

        #region Ordering Rectangles: Lambda expression as argument
        var orderedRecs = recs.OrderBy<Rectangle, double>(r=>r.GetArea())
                              .ToList();
        orderedRecs.ForEach(r => Console.WriteLine(r.GetInfo()));
        #endregion
        Pause();

        #region Filtering Rectangles: Lambda expression as argument
        var filterRecs = recs.Where(r=>r.GetArea() >= 40)
                             .ToList();
        filterRecs.ForEach(r => Console.WriteLine(r.GetInfo()));
        #endregion
    }
    static void Pause() 
    { 
        Console.Write("Press any key to continue..."); 
        Console.ReadKey(); 
        Console.WriteLine();
        Console.WriteLine();
    }
    static void ViewRectangle(Rectangle r) => Console.WriteLine(r.GetInfo());
    
   
}
