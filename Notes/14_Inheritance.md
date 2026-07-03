# Lesson 14 - Method Overriding & 

## Objective

Learn how inheritance allows child classes to reuse code from a parent class and how method overriding enables child classes to customize inherited behavior without duplicating code.

Key Concepts
Inheritance

Inheritance allows one class (the child class) to inherit properties and methods from another class (the parent class).


```` Example
Person
│
├── Student
└── Teacher
````

Both Student and Teacher automatically inherit the common information stored inside the Person class, such as:
```
Name
Age
Email
```

This helps eliminate duplicate code and makes applications easier to maintain.

## Method Overriding

Method overriding allows a child class to replace the implementation of an inherited method with its own customized version.

## Instead of rewriting the entire method, the child can extend the parent's behavior.

````csharp
public override void DisplayInfo()
{
    base.DisplayInfo();
    Console.WriteLine($"Score: {Score}");
}
````
The virtual Keyword

The virtual keyword tells C# that a method may be replaced by child classes.

Example:
```` chsharp
public virtual void DisplayInfo()
{
    Console.WriteLine(Name);
}
````

Without virtual, overriding is not allowed.



## The override keyword replaces an inherited virtual method with a new implementation.


````csharp
public override void DisplayInfo()
{
    base.DisplayInfo();
    Console.WriteLine(Score);
}
````

## The base keyword allows a child class to access members of its parent class.


```` Example
base.DisplayInfo();
````

Instead of rewriting the parent's logic, the child reuses it and then adds its own functionality.

## Benefits

- Promotes code reuse.
- Eliminates duplicate code (DRY principle).
- Makes applications easier to maintain.
- Allows specialized behavior while preserving shared functionality.
- Forms the foundation of runtime polymorphism.


## Key Takeaways
- A child class automatically inherits public members from its parent class.
- The virtual keyword allows methods to be overridden.
- The override keyword replaces the parent's implementation.
- The base keyword reuses the parent's implementation.
- Method overriding is one of the core features that enables polymorphism in object-oriented programming.