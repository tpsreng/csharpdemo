using People_OOP.Models;
using System.Text;

namespace People_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datafile = "people.txt";
            List<Person> people = GetPeople(datafile);

            Console.WriteLine("\nOriginal people");
            ViewPeople(people);

            Pause();
            List<Person> filterPeople = FilterPeopleOverAge(people, 25);
            filterPeople.Sort(AgeComparison);
            Console.WriteLine("\nPeople with age>25 in decending of ages");
            ViewPeople(filterPeople);

            Pause();
            people.Sort(NameComparison);
            Console.WriteLine("\nPeople in ascending of names");
            ViewPeople(people);
        }
        static void Pause()
        {
            Console.WriteLine("Any key to continue...");
            Console.ReadKey();
        }
        static List<Person> GetPeople(string file)
        {
            TextReader reader = Console.In;
            Console.SetIn(new StreamReader(file));
            List<Person> result = new();
            while (true)
            {
                string? data = Console.ReadLine();
                if (data == null) break;
                Person p = new Person();
                if (p.SetData(data, "/") == false) continue;
                result.Add(p);
            }
            Console.SetIn(reader);
            return result;
        }
        static void ViewPeople(List<Person> pers)
        {
            if (pers.Count == 0)
            {
                Console.WriteLine("No people to be shown out");
            }
            Console.WriteLine(Person.GetHeading());
            Console.WriteLine(Person.GetBar());
            for (int index = 0; index < pers.Count; index++)
            {
                Console.WriteLine(pers[index].GetInfo());
            }
            Console.WriteLine(Person.GetBar());
        }
        static List<Person> FilterPeopleOverAge(List<Person> pers, int age)
        {
            List<Person> result = new();
            foreach (Person p in pers)
                if (p.GetAge() > age) { result.Add(p); }
            return result;
        }
        static int AgeComparison(Person x, Person y)
        {
            return y.GetAge().CompareTo(x.GetAge());
        }
        static int NameComparison(Person x, Person y)
        {
            return x.GetName().CompareTo(y.GetName());
        }
    }
}