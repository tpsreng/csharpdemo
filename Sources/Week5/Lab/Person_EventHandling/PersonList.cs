namespace Person_EventHandling;

public class PersonList
{
    private List<Person> pers = new();
    public PersonList() 
    {
        Person.Created += p =>  pers.Add(p); 
    }
    public List<Person> Elements => new List<Person>(pers);
    
    public List<string> Genders =>  pers.Select(e => e.Gender).Distinct().ToList();
    public void GenderGroupView()
    {
        Genders.ForEach(g =>
        {
            Console.WriteLine($"[{g} People]");
            pers.Where(p => p.Gender == g).ToList()
                .ForEach(e => Console.WriteLine($"Age:{e.Age}, Name:{e.Name}"));
            Console.WriteLine();
        });
    }
}
