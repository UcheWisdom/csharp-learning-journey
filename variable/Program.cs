class Program
{
    public static void Main(string[] args)
    {
        string name = "Wisdom";
        int age = 20;
        Console.WriteLine($"Hello! {name}, who is {age} years");

        Console.Write("Enter your name: ");
        string input = Console.ReadLine();

        Console.WriteLine($"Welcome {input}");

        /*Exercise 1
        Write a program that asks for:
        Student Name
        Course
        Age
        
        1. Ask user for name
        2. Ask user for course
        3. Ask user for age
        4. Display all information
         */

        // 1. Ask user for name
        Console.WriteLine("Enter Student Name: ");
        string studentName = Console.ReadLine();

        // 2. Ask user for course
        Console.WriteLine("Enter Student Course: ");
        string studentCourse = Console.ReadLine();

        // 3. Ask user for age
        Console.WriteLine("Enter student Age: ");
        int studentAge = int.Parse( Console.ReadLine() );


        // 4. Display all information
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Student Course: {studentCourse}");
        Console.WriteLine($"student Age: {studentAge}");



    }
}
