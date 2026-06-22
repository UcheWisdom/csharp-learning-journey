using System;

// =================
// Exercise 1
// =================
class Student
{
    public string Name;
    public int Age;
    public int Score;
}

class Program
{
    public static void Main(string[] args)
    {
        // =================
        // Exercise 2
        // =================
        Student s1 = new Student();
        s1.Name = "Wisdom";
        s1.Age = 22;
        s1.Score = 85;

        Console.WriteLine("Student 1:");
        Console.WriteLine(s1.Name);
        Console.WriteLine(s1.Age);
        Console.WriteLine(s1.Score);

        Console.WriteLine();

        Student s2 = new Student();
        s2.Name = "Precious";
        s2.Age = 20;
        s2.Score = 90;

        Console.WriteLine("Student 2:");
        Console.WriteLine(s2.Name);
        Console.WriteLine(s2.Age);
        Console.WriteLine(s2.Score);
    }
}