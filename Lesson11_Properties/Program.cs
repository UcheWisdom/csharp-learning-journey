using System;

class Student
{
    public string Name;
    public int Age;
    private int score;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            if (value >= 0 && value <= 100)
            {
                score = value;
            }
            else
            {
                Console.WriteLine("Invalid score. Please enter a value between 0 and 100.");
            }
        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        //s1.Score = 85;
        //Console.WriteLine(s1.Score);

        s1.Score = 500;
        Console.WriteLine(s1.Score);
    }
}