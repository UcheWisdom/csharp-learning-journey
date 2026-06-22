using System;

class Program
{
    public static void Main(string[] args)
    {

        /*
        Exercise 1
        program should:

        Write the algorithm first:

        Ask for student's score.
        If score is 70 or above:
            Display "Grade A"
        Else if score is 50 or above:
            Display "Grade B"
        Otherwise:
            Display "Grade F"
        */

        Console.Write("Enter Student Score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 70)
        {
            Console.WriteLine("Grade A");
        }
        else if (score >= 50)
        {
            Console.WriteLine("Grade B");
        }
        else
        {
            Console.WriteLine("Grade F");
        }


        /*
        Exercise 2

        Write a second program that:

        Asks for age.
        If age is 18 or above:
            Display "Adult"
        Otherwise:
            Display "Minor"
        */

        Console.Write("Enter Student Age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }

    }
}
