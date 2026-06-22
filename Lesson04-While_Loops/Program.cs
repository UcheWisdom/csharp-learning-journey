using System;

class Program
{
    public static void Main (string[] args)
    {
        /*
        Exercise 1
        algorithm
        1.Ask user for age
        2.Try converting input
        3.If conversion fails
             Ask again
        4.If conversion succeeds
             Continue
        */

        Console.Write("Enter Age: ");

        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid Number. Try again");
            Console.Write("Enter Age: ");
        }

        Console.WriteLine($"Your age is {age} ");


        //Exercise 2
        Console.Write("Enter Score: ");

        int score;
        while (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("Invalid Number. Try again");
            Console.Write("Enter score: ");
        }

        Console.WriteLine($"Your score is {score} ");

    }
}