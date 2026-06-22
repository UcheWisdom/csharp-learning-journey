using System;
using System.Collections.Generic;
using System.Linq;

class program
{
    public static void Main(string[] args)
    {
        /* =======================
              Algorithm
           =======================
        1.Create a list of scores
        2.Find scores >= 50
        3.Display passed scores
        4.Count passed scores
        5.Find highest score
        6.Find lowest score
        7.Display results
        ===========================
        */

        // ===================
        //   Exercise 1
        // ====================
        List<int> scores = new List<int>()
        {
            70,
            85,
            40,
            90,
            60
        };

        //Give me all scores where the score is 50 or above.
        var passedScores = scores.Where(score => score >= 50);


        //Count all passed students:
        int passedCount = scores.Count(score => score >= 50);

        Console.WriteLine($"Passed Students: {passedCount}"); 

        // ===================
        //   Exercise 2
        // ====================
        //Highest Score
        int highest = scores.Max();

        //lowest Score
        int lowest = scores.Min();

        Console.WriteLine($"The Highest score: { highest}");
        Console.WriteLine($"The Lowest score:{lowest}");


        // ===================
        //   Exercise 3
        // ====================
        foreach (int score in passedScores)
        {
            Console.WriteLine($"Passed Score: {score}");
        }
    }
}