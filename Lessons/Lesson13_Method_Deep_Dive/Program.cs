using System;

class Program
{
    static int GetValidNumber(string message)
    {
        int validNumber;

        Console.Write(message);

        while (!int.TryParse(Console.ReadLine(), out validNumber))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.ResetColor();

            Console.Write(message);
        }

        return validNumber;
    }


    static void Main()
    {
        Student currentStudent = GetStudent();

        DisplayStudent(currentStudent);
    }

    static Student GetStudent()
    {
        Student s = new Student();

        Console.Write("Enter student name: ");
        s.Name = Console.ReadLine();


        s.Age = GetValidNumber("Enter student age: ");


        s.Score = GetValidNumber("Enter student score: ");

        return s;
    }

    static bool IsPassed(Student student)
    {
        return student.Score >= 50;
    }

    static void DisplayStudent(Student student)
    {
        Console.WriteLine("\n--- Student Summary ---");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Score: {student.Score}");
        Console.WriteLine($"Grade: {student.Grade}");
        Console.WriteLine($"Status: {(student.IsPassed ? "PASSED" : "FAILED")}");
    }
}


class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }
    public bool IsPassed
    {
        get
        {
            return Score >= 50;
        }
    }
    public String Grade
    {
        get
        {
            if (Score>= 70)
                return "A";
            else if (Score >= 50)
                return "B";
            else
                return "F";
        }
    }
}