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
}

class Student : Person
{
    public int Score { get; set; }
    public Student (string name, int age, string email, int score) : base(name, age, email)
    {
        Score = score;
    }
}

class Teacher : Person
{
    public decimal Salary { get; set; }
    public Teacher(string name, int age, string email, decimal salary) : base(name, age, email)
    {
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Alice", 20, "ali@e.com", 90);

        Teacher teacher = new Teacher("Bob", 40, "bo@b.com", 50000m);


        //Console.WriteLine($"Student: {student.Name}, Age: {student.Age}, Email: {student.Email}, Score: {student.Score}");
        //Console.WriteLine($"Teacher: {teacher.Name}, Age: {teacher.Age}, Email: {teacher.Email}, Salary: ${teacher.Salary}");

        Console.WriteLine("Student Information");
        Console.WriteLine($"Name  : {student.Name}");
        Console.WriteLine($"Age   : {student.Age}");
        Console.WriteLine($"Email : {student.Email}");
        Console.WriteLine($"Score : {student.Score}");
        Console.WriteLine();
        Console.WriteLine("Teacher Information");
        Console.WriteLine($"Name  : {teacher.Name}");
        Console.WriteLine($"Age   : {teacher.Age}");
        Console.WriteLine($"Email : {teacher.Email}");
        Console.WriteLine($"Salary : {teacher.Salary}");

    }
}