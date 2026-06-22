using System;
using System.Runtime.ExceptionServices;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Exercise 1
        Algorithm
        total = 0
        Add first score 70
        Add second score 85
        Add third score 40
        Display total
        */

        //Exercise 2
        int[] scores = { 70, 85, 40 };
        int total = 0;

        foreach (int score in scores)
        {
            total += score;
        }

        Console.WriteLine($"The Total Score: {total}");

        //Exercise 3
        int avg = total / scores.Length;
        Console.WriteLine($"The Average Score: {avg}");

        /*
         Exercise 4
        highest = first score

        For every score:
             If score > highest
               highest = score
         */

        int highest = scores[0];

        foreach (int score in scores)
        {
            if (score > highest)
            {
                highest = score;
            }
        }

        Console.WriteLine($"Highest Score: {highest}");

    }
}