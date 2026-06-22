using System;

class Program
{
    public static void Main (string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Hello");
        }


        //Exercise 1
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        //Exercise 2
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

        //Exercise 3
        //School System Challenge
        Console.Write("How many students? ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"Entering Student {i}");
        }

    }
}