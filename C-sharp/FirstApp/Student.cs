namespace FirstApp;

internal sealed class Student:Person
{
    public static int _count=0;
    public int _countIns=0;
    public string University { get; set; }
    static Student()
    {
        Console.WriteLine("First time requested");
    }

    public Student(string name,string surname,string uni):base(name, surname)
    {
        _count++;
        _countIns++;
        Console.WriteLine("_count: "+_count);
        Console.WriteLine("_countIns: " + _countIns);
        University = uni;
    }

    public static void test()
    {
    }

    public override string Info()
    {
        return $"{base.Info()} {University}";
    }

    protected override void Eat()
    {
        Console.WriteLine("Eat as Student");
    }
}
