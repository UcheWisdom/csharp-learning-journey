using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name  : {Name}");
        Console.WriteLine($"Age   : {Age}");
        Console.WriteLine($"Email : {Email}");

    }
}

class Student : Person
{
    public int Score { get; set; }
    public Student(string name, int age, string email, int score) : base(name, age, email)
    {
        Score = score;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("====== Student ======");
        base.DisplayInfo();
        Console.WriteLine($"Score : {Score}");
    }
}

class Teacher : Person
{
    public decimal Salary { get; set; }
    public Teacher(string name, int age, string email, decimal salary) : base(name, age, email)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("====== Teacher ======");
        base.DisplayInfo();
        Console.WriteLine($"Salary : {Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        people.Add(
            new Student(
                "Alice",
                20, 
                "ali@e.com", 
                90
            )
        );

        people.Add(
            new Teacher(
                "Bob",
                40,
                "bo@b.com",
                50000m
            )
        );

        people.Add(
            new Teacher(
                "Tolu",
                50,
                "Tol@b.com",
                60000m
            )
        );

        //Student student = new Student("Alice", 20, "ali@e.com", 90);
        //Teacher teacher = new Teacher("Bob", 40, "bo@b.com", 50000m);

        foreach(Person person in people )
        {

            person.DisplayInfo();

            Console.WriteLine();
        }

    }
}