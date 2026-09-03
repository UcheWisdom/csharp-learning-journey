# Lesson 17 — Interfaces


## 1. What Is an Interface?
An interface is a blueprint or contract in C# that defines a set of operations (methods or properties) without giving them an actual implementation. It specifies what a class should be able to do, but leaves the how entirely up to the class that uses it.


## 2. Interface Contract
An interface contract is a binding agreement. When a class promises to implement an interface, it guarantees to the compiler that it will provide concrete code for every single method and property listed in that interface. If it fails to implement even one member, the program will not compile.


## 3. Implementing an Interface

Implementing an interface means a class attaches the interface name after its declaration using a colon `:` and provides implementations for the required interface members. The implementations must match the signatures defined by the interface.

With normal implicit interface implementation, the implemented members are typically declared `public`. C# also supports explicit interface implementation, which is an advanced technique.

## 4. Interface Naming Convention
By C# convention, interface names always start with a capital I (for example, IPayable, IPrintable, or IDisposable). This makes it instantly clear to anyone reading the code that the type is a contract rather than a concrete or abstract class.


## 5. Interface vs Inheritance

- Class Inheritance (`class Student : Person`): Represents an "is-a" relationship where a derived class inherits accessible members and behavior from a base class. A C# class can directly inherit from only one base class.

- Interface Implementation (`class Student : IPrintable`): Represents a capability or contract. It does not establish class inheritance or provide instance fields/state. Instead, the implementing type agrees to provide the required interface members. A class can implement multiple interfaces.

## 6. Multiple Interfaces
While C# strictly forbids a class from inheriting from multiple base classes, a single class can implement multiple interfaces at the same time. This allows a single class to wear many hats and fulfill different functional roles across an application.


## 7. Interface Polymorphism
Interface polymorphism allows us to treat different, completely unrelated classes the same way as long as they implement the same interface. We can call a common interface method on different objects at runtime, and each object will execute its own unique version of that method.


## 8. Interface Reference vs Actual Object
In a statement like
```
IPayable p = new Employee();
```
- Declared/Reference Type (IPayable): The compile-time type. It controls what methods or properties you are allowed to call through that variable (only those defined in IPayable).
- Actual Object Type (Employee): The runtime type created in memory. It determines which actual code executes when a method is called.


## 9. Interfaces and Polymorphic Collections
By creating a collection of an interface type, such as List<IPayable>, you can store instances of completely different classes (like Employee, Manager, and Customer) together. You can then iterate through the collection and execute common interface actions seamlessly.


## 10. Interfaces vs Abstract Classes
- Abstract Class: Serves as a base abstraction for closely related classes. It can contain fields, properties, state, constructors, abstract members, virtual members, and fully implemented methods. A class can directly inherit from only one base class.
- Interface: Primarily defines a contract or capability that a type agrees to provide. It cannot contain instance fields, and a class can implement multiple interfaces. Modern C# also supports certain interface members with implementations.




- An interface defines a contract that implementing types must satisfy.
- Interfaces cannot contain instance fields.
- A class implementing an interface must satisfy its required members.
- A derived class can inherit an interface implementation through its base class.
- C# allows a class to inherit from one base class while implementing multiple interfaces.
- Interface references can be used for polymorphism.
- Interfaces are useful for reducing coupling and allowing unrelated types to share a common capability.


## 12. Practical Example
```csharp
using System;
using System.Collections.Generic;

// Interface definition
interface IPayable
{
    void Pay();
}

// Concrete class 1
class Employee : IPayable
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public virtual void Pay()
    {
        Console.WriteLine($"Paying employee {Name}: {Salary:C}");
    }
}

// Inherits from Employee and overrides behavior
class Manager : Employee
{
    public decimal Bonus { get; set; }

    public override void Pay()
    {
        Console.WriteLine($"Paying manager {Name}: {Salary + Bonus:C}");
    }
}

// Unrelated class implementing the same interface
class Customer : IPayable
{
    public string Name { get; set; }

    public void Pay()
    {
        Console.WriteLine($"Processing invoice payout for customer {Name}");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphic collection holding different types via interface reference
        List<IPayable> payables = new List<IPayable>
        {
            new Employee { Name = "John", Salary = 5000m },
            new Manager { Name = "Jane", Salary = 8000m, Bonus = 2000m },
            new Customer { Name = "Bob" }
        };

        foreach (IPayable item in payables)
        {
            item.Pay(); // Calls each object's respective Pay implementation
        }
    }
}
```

## 13. What I Learned
Interfaces provide a way to write loosely coupled, flexible, and clean C# code. They let us define what capabilities objects have without forcing them into strict class hierarchies. Mastering interfaces unlocks true polymorphism, enabling us to work with diverse objects uniformly through shared capabilities, handle collections safely, and build modular programs that are easy to extend.
