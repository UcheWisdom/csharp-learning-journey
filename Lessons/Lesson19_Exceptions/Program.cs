//Basics of Exceptions in C#
/*
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");


        // Your code here
        string numberInput = Console.ReadLine();
        string ageInput = Console.ReadLine();
        try
        {
            // Number
            int number = int.Parse(numberInput);
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid number.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}
*/


//Additional Exception Handling Example
/*
using System;

class Program
{

    static void CheckAge(int age)
    {
        // 1 & 2. Check if age is less than 18, throw ArgumentException if true
        if (age < 18)
        {
            throw new ArgumentException("Age must be 18 or older.");
        }

        // 3. Otherwise print success message
        Console.WriteLine("You are eligible.");
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a age: ");


        // Your code here
        string ageInput = Console.ReadLine();
        try
        {

            // Age
            int age = int.Parse(ageInput);

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(age),
                    age,
                    "Age cannot be negative."
                );
            }

            Console.WriteLine($"Your age is: {age}");

            CheckAge(15);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            //Console.WriteLine("Age cannot be negative.");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid number for age.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}
*/

// Validating User Input with Exception Handling
/*
using System;

class Program
{

    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("Age must be 18 or older.");
        }

        Console.WriteLine("You are eligible.");
    }



    public static void Main(string[] args)
    {
        Console.Write("Enter an age: ");

        string ageInput = Console.ReadLine();

        try
        {
            int age = int.Parse(ageInput);

            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(age),
                    age,
                    "Age cannot be negative."
                );
            }

            CheckAge(age);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid number for age.");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}
*/


// Handling Exceptions in a Banking Application
/*        
using System;

class Program
{
    static void Withdraw(decimal balance, decimal amount)
    {
        // Your code here
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
        else
        {
            Console.WriteLine("Withdrawal successful.");
        }
    }


    public static void Main(string[] args)
    {
        decimal balance = 50000;
        decimal amount = 20000;

        try
        {
            Withdraw(balance, amount);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }

    }
}
*/

// Handling Exceptions in a Banking Application with a BankAccount Class
/*
using System;

class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(initialBalance),
                "Initial balance cannot be negative."
            );
        }

        balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero."
            );
        }

        if (amount > balance)
        {
            throw new InvalidOperationException(
                "Insufficient balance."
            );
        }

        balance -= amount;

        Console.WriteLine(
            $"Withdrawal successful. Remaining balance: {balance:C}"
        );
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(50000);

        try
        {
            account.Withdraw(20000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Input error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Transaction error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}
*/

// A small Student Registration Validator.
using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        // Validate the name
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Student name cannot be empty.");
        }

        // Validate the age
        if (age < 16)
        {
            throw new ArgumentOutOfRangeException( nameof(age),"Student must be at least 16 years old.");
        }

        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // create Student
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());

            // Create a new Student object
            Student student = new Student(name, age);

            Console.WriteLine($"Student registered: {student.Name}, Age: {student.Age}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Input error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Input error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid number for age.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Student registration process completed.");
        }
    }
}   
