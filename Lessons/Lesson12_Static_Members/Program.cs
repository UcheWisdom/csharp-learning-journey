using System;


//class Student
//{

//    public static int StudentsCount = 0;

//    public string Name;

//    public Student(string name)
//    {
//        Name = name;

//        StudentsCount++;
//    }
//}

//Exercise 1
class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

}


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



    public static void Main(string[] args)
    {
        //Student s1 = new Student("Wisdom");
        //Student s2 = new Student("Precious");
        //Student s3 = new Student("Delight");
        //Student s4 = new Student("Tobi");
        //Student s5 = new Student("Tolu");

        //Console.WriteLine(Student.StudentsCount);

        //int result = Calculator.Add(5, 3);
        //Console.WriteLine(result);


        int number1 = GetValidNumber("Enter first integer number: ");
        int number2 = GetValidNumber("Enter second integer number: ");


        int additionResult = Calculator.Add(number1, number2);
        int subtractionResult = Calculator.Subtract(number1, number2);
        int multiplicationResult = Calculator.Multiply(number1, number2);

        Console.WriteLine($"Addition: {number1} + {number2} = {additionResult}");
        Console.WriteLine($"Subtraction: {number1} - {number2} = {subtractionResult}");
        Console.WriteLine($"Multiplication: {number1} * {number2} = {multiplicationResult}");

    }
}