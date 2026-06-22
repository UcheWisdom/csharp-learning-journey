using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // -------------------------
        // Lesson Example
        // -------------------------

        List<int> scores = new List<int>();

        scores.Add(70);
        scores.Add(85);
        scores.Add(40);

        Console.WriteLine("Scores:");

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine($"Total Scores Stored: {scores.Count}");

        Console.WriteLine();

        // -------------------------
        // Exercise 1
        // -------------------------

        List<string> sampleStudents = new List<string>();

        sampleStudents.Add("name1");
        sampleStudents.Add("name2");
        sampleStudents.Add("name3");

        Console.WriteLine("Sample Students:");

        foreach (string student in sampleStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();

        // -------------------------
        // Exercise 2
        // -------------------------

        Console.Write("How many student names do you want to enter? ");

        int numStudentNames;

        while (!int.TryParse(Console.ReadLine(), out numStudentNames))
        {
            Console.WriteLine("Invalid number. Try again.");
            Console.Write("How many student names do you want to enter? ");
        }

        List<string> students = new List<string>();

        for (int i = 0; i < numStudentNames; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");

            string nameInput = Console.ReadLine();

            students.Add(nameInput);
        }

        Console.WriteLine();
        Console.WriteLine("--- Student Names ---");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // -------------------------
        // Exercise 3
        // -------------------------

        Console.WriteLine();
        Console.WriteLine($"Total Students: {students.Count}");
    }
}