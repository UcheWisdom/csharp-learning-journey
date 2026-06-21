class Program
{
    public static void Main(string[] args)
    {
        string name = "Wisdom";
        int age = 20;
        Console.WriteLine($"Hello! {name}, who is {age} years");

        Console.Write("Enter your name: ");
        string input = Console.ReadLine();

        Console.WriteLine($"Welcome {input}");
    }
}
