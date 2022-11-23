namespace FirstApp;

internal class Engineer:Person
{
    public string Position { get; set; }
    public Engineer(string name, string surname, string pos) : base(name, surname)
    {
        Position = pos;
    }

    protected override void Eat()
    {
        Console.WriteLine("Eat as Engineer");
    }

    public sealed override string Info()
    {
        return $"{Name} {Surname} Engineer";
    }
}

class BackEndEngineer : Engineer
{
    public BackEndEngineer(string name, string surname, string pos) : base(name, surname, pos)
    {
    }
    //public override string Info()
    //{
    //    return "BackEndEngineer";
    //}
}
