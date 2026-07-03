using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Student : Person
{
    public int Score { get; set; }
}

class Teacher : Person
{
    public decimal Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "Alice",
            Age = 20,
            Email = "ali@ce.com",
            Score = 95
        };

        Teacher teacher = new Teacher
        {
            Name = "Bob",
            Age = 40,
            Email = "bo@g.com",
            Salary = 50000m
        };


        Console.WriteLine($"Student: {student.Name}, Age: {student.Age}, Email: {student.Email}, Score: {student.Score}");
        Console.WriteLine($"Teacher: {teacher.Name}, Age: {teacher.Age}, Email: {teacher.Email}, Salary: ${teacher.Salary}");
    }
}