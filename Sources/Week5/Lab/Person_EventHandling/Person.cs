namespace Person_EventHandling;
public delegate void CreatedHandler(Person p);
public class Person
{
    public static event CreatedHandler? Created;
    public static void Create(string name, string gender, byte age)
    {
        Person newPerson = new Person()
        {
            Name = name,
            Gender = gender,
            Age = age
        };
        Created?.Invoke(newPerson);
    }
    private Person() { }
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
    public byte Age { get; set; } = default;

    public string Info
    {
        get
        {
            return $"Name:{Name}, Gender:{Gender}, Age:{Age}";
        }
    }
}
