// Example of using interfaces in C#
//interface IPrintable
//{
//    void Print();
//}

//class Student : IPrintable
//{
//    public string Name { get; set; }

//    public void Print()
//    {
//        Console.WriteLine($"Printing information for student: {Name}");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        IPrintable printable = new Student
//        {
//            Name = "Alice"
//        };

//        printable.Print();
//    }
//}

//Execrise 1
//using System;
//using System.Collections.Generic;

//interface IPayable
//{
//    void Pay();
//}

//class Employee : IPayable
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }

//    // Mark as virtual so derived classes can override it
//    public virtual void Pay()
//    {
//        Console.WriteLine("Paying employee salary...");
//        Console.WriteLine($"Paying {Name} an amount of {Salary:C}");
//    }
//}

//class Manager : Employee
//{
//    public decimal Bonus { get; set; }

//    // Override the base method to ensure runtime polymorphism
//    public override void Pay()
//    {
//        Console.WriteLine("Paying manager salary and bonus...");
//        Console.WriteLine($"Paying {Name} an amount of {Salary + Bonus:C}");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        IPayable employee = new Employee
//        {
//            Name = "John",
//            Salary = 5000m
//        };

//        IPayable manager = new Manager
//        {
//            Name = "Jane",
//            Salary = 8000m,
//            Bonus = 2000m
//        };

//        // Add items to the collection
//        List<IPayable> payables = new List<IPayable> { employee, manager };

//        // Rename loop variable to avoid shadowing
//        foreach (IPayable item in payables)
//        {
//            item.Pay();
//            Console.WriteLine();
//        }
//    }
//}

//Execrise 1
//interface ISaveable
//{
//    void Save();
//}

//interface IPrintable
//{
//    void Print();
//}

//class Student : IPrintable, ISaveable
//{
//    public string Name { get; set; }

//    public void Print()
//    {
//        Console.WriteLine($"Printing {Name}");
//    }

//    public void Save()
//    {
//        Console.WriteLine($"Saving {Name}");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Student student = new Student 
//        {
//            Name = "Alice" 
//        };

//        IPrintable printable = student;
//        ISaveable saveable = student;

//        printable.Print();
//        saveable.Save();
//    }
//}



//Final Lesson 17 exercise
using System;
using System.Collections.Generic;

interface IPayable
{
    void Pay(); // Standard PascalCase
}

class Employee : IPayable
{
    public string Name { get; set; }
    public decimal Salary { get; set; } = 0;

    // Mark as virtual so derived classes can override it
    public virtual void Pay()
    {
        Console.WriteLine($"Paying employee {Name} a salary of {Salary:C}");
    }
}

class Manager : Employee
{
    public decimal Bonus { get; set; } = 0;

    // Use override instead of new to enable polymorphism
    public override void Pay()
    {
        Console.WriteLine($"Paying manager {Name} a salary of {Salary:C} and a bonus of {Bonus:C}");
        Console.WriteLine($"Total payment: {Salary + Bonus:C}");
    }
}

class Customer : IPayable
{
    public string Name { get; set; }

    public void Pay()
    {
        Console.WriteLine($"Paying customer {Name} an invoice...");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        IPayable employee = new Employee
        {
            Name = "John",
            Salary = 5000m
        };
        IPayable manager = new Manager
        {
            Name = "Jane",
            Salary = 8000m,
            Bonus = 2000m
        };
        IPayable customer = new Customer
        {
            Name = "Bob"
        };

        List<IPayable> payables = new List<IPayable> { employee, manager, customer };

        foreach (IPayable item in payables)
        {
            item.Pay();
            Console.WriteLine();
        }
    }
}