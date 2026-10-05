/*
using System;

class BankAccount
{
    // private balance field
    private decimal balance;

    // AccountHolder property
    public string? AccountHolder { get; set; }

    // Balance property with validation
    public decimal Balance 
    {
        get
        {
            return balance;
        }

        //private set
        //{
        //    if (value >= 0)
        //    {
        //        balance = value;
        //    }
        //}
    }

    // Deposit method
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    //withdraw method
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        if (amount > balance)
        {
            return false;
        }

        balance -= amount;
        return true;
    }

    //GetAccountSummary method
    public string GetAccountSummary()
    {
        return $"Account Holder: {AccountHolder}\nBalance: {Balance}";
    }
}

class Program
{
    static void Main()
    {
        // create BankAccount
        BankAccount bankAccount = new BankAccount();

        // set account holder
        bankAccount.AccountHolder = "John Doe";

        // set initial balance
        //bankAccount.Balance = 1000.00m;
        // Use a method to safely modify the balance
        bankAccount.Deposit(1000.00m);

        // capture initial balance before depositing
        decimal initialBalance = bankAccount.Balance;

        // deposit money
        decimal depositAmount = 500.00m;
        bankAccount.Deposit(depositAmount);

        // withdraw money
        decimal withdrawAmount = 300.00m;
        bool withdrawalSuccessful = bankAccount.Withdraw(withdrawAmount);

        // display account information
        Console.WriteLine($"Account Holder: {bankAccount.AccountHolder}");
        Console.WriteLine($"Initial Balance: {initialBalance}");
        Console.WriteLine($"Deposited Amount: {depositAmount}");
        Console.WriteLine($"Withdrawn Amount: {withdrawAmount}");
        Console.WriteLine($"Withdrawal Successful: {withdrawalSuccessful}");
        Console.WriteLine($"Final Balance: {bankAccount.Balance}");

        Console.WriteLine("================================");
        Console.WriteLine(bankAccount.GetAccountSummary());
        Console.WriteLine("================================");
    }
}
*/



using System;

class Student
{
    public string? Name { get; set; }

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
                throw new ArgumentOutOfRangeException(
                    nameof(Score),
                    value,
                    "Score must be between 0 and 100."
                );
            }
        }
    }

    public string GetGrade()
    {
        if (score >= 70)
        {
            return "A";
        }
        else if (score >= 50)
        {
            return "B";
        }
        else
        {
            return "F";
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "John Doe";
        student.Score = 50;

        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Score: {student.Score}");
        Console.WriteLine($"Grade: {student.GetGrade()}");
    }
}