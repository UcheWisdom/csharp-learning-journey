using System;
using System.Security.Cryptography;

// ================
// Exercise 1
// ================
class student
{
    public string Name;
    public int Age;
    public int Score;
}

class Program
{
    public static void Main(string[] args)
    {
        // ================
        // Exercise 2
        // ================
        student s1 = new student();
        s1.Name = "wisdom";
        s1.Age = 22;
        s1.Score = 85;

        Console.WriteLine(s1.Name);
        Console.WriteLine(s1.Age);
        Console.WriteLine(s1.Score);
       
        
        student s2 = new student();
        s2.Name = "precious";
        s2.Age = 20;
        s2.Score = 90;

        Console.WriteLine(s2.Name);
        Console.WriteLine(s2.Age);
        Console.WriteLine(s2.Score);
    }
}