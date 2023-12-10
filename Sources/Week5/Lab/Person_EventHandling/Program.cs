namespace Person_EventHandling;

internal class Program
{
    static void Main(string[] args)
    {
        PersonList people = new();
        Person.Create("Heng Map", "Male", 34);
        Person.Create("Doung Nita", "Female", 25);
        Person.Create("Chan Dara", "Male", 45);
        Person.Create("Mut Vanny", "Female", 23);
        Person.Create("Vong Neary", "Female", 21);

        people.GenderGroupView();

        Console.WriteLine("\n[All people in ascending of names]");
        people.Elements.OrderBy(x => x.Name)
                       .ToList()
                       .ForEach(p => Console.WriteLine(p.Info));
    }
}
