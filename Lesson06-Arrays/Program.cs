using System;

class Program
{
    public static void Main(string[] args)
    {
        // Exercise 1
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        //Exercise 2
        Console.WriteLine(numbers[2]);

        //Exercise 3
        Console.Write("How many students? ");
        int numberOfStudents;

        // Validate the number of students
        while (!int.TryParse(Console.ReadLine(), out numberOfStudents))
        {
            Console.WriteLine("Invalid number, Try again");
            Console.Write("How many students? ");
        }

        int[] scores = new int[numberOfStudents];

        // Loop through and collect each score
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score for student {i + 1}: ");

            // Parse directly into the array at index i
            while (!int.TryParse(Console.ReadLine(), out scores[i]))
            {
                Console.WriteLine("Invalid number, Try again");
                Console.Write($"Enter score for student {i + 1}: ");
            }
        }

        Console.WriteLine("\n--- Student Scores ---");
        // Print out all the collected scores
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }
}