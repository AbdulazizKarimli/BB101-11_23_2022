namespace FirstApp;
abstract class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public Person()
    {
        Console.WriteLine("Person in Test");
    }
    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    protected abstract void Eat();

    public virtual string Info()
    {
        return $"{Name} {Surname}";
    }
}
