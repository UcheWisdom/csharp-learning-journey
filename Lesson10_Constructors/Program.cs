using System;
using System.Security.Cryptography.X509Certificates;

class Student
{
    public string Name;
    public int Age;
    public int Score;

    public Student(string name, int age, int score)
    {
        Name = name;
        Age = age;
        Score = score;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("wisdom", 22, 85);
        Student s2 = new Student("Precious", 20, 90);
    }
}