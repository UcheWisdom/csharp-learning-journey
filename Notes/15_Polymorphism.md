# Lesson 15 - Polymorphism 

## Definition 

Polymorphism is an OOP principle that allows objects of different derived classes to be treated through a common parent type while still executing their own specialized behavior at runtime.
## Objective

Learn how polymorphism builds on inheritance to allow a single variable type to hold different objects at runtime, and understand how C# determines which method to execute dynamically.

## Key Concepts

## Declared Type vs Actual Type

Every object reference in C# has two distinct types that dictate what code can be called and what code actually runs.
    

```` Example
Person p = new Student();
  │              │
  │              └─► Actual Type (Runtime)
  └─────────────────► Declared Type (Compile-time)
````
- Declared Type: The type used to define the variable at compile time. It determines which members are accessible.
- Actual Type: The type of the object that was actually created at runtime. It determines which overridden implementation executes.


## Upcasting

Upcasting is storing a reference to a child object inside a parent variable type.
```
Person p = new Student(); // Upcasting Student to Person
```
Upcasting is always implicit and type-safe because every Student is a Person.

Dynamic Method Dispatch

Dynamic method dispatch (or late binding) is the mechanism C# uses at runtime to choose which method implementation to call.

```
public class Person
{
    public virtual void Introduce() => Console.WriteLine("I am a person.");
}

public class Student : Person
{
    public override void Introduce() => Console.WriteLine("I am a student.");
}
```

```
p.DisplayInfo();
// Output: "I am a student."
```
At compile-time, C# checks that Person has an Introduce() method. At runtime, C# sees that p is actually a Student and executes Student's overridden method.

## Polymorphic Collections

Because child objects can be upcast to their parent type, a single array or list can hold different subclasses simultaneously.

```
List<Person> roster = new List<Person>();

roster.Add(new Student());
roster.Add(new Teacher());

foreach (Person p in roster)
{
    p.Introduce(); // Calls each specific child implementation automatically
}
```
Instead of using if-else or switch blocks to check types, polymorphism handles type-specific execution automatically.


## Benefits

- Simplifies code by eliminating conditional logic based on object type.
- Keeps applications loosely coupled and easier to extend.
- Allows new subclasses to be added without modifying existing processing loops.
- Supports the Open/Closed Principle (code is open for extension, closed for modification).


## Key Takeaways
- Declared type controls what methods you can call at compile-time.
- Actual type controls which overridden implementation runs at runtime.
- Upcasting to a parent type happens implicitly and safely.
- Dynamic method dispatch resolves method execution based on the object in memory, not the variable type.
- Polymorphic lists allow uniform treatment of diverse child types. 
- Polymorphism works particularly well with virtual and override methods.
- A parent reference can refer to a child object, but the reference can only directly access members available through the parent type.

## Algorithm

Start

    ↓

Create a parent Person class

    ↓

Create Student and Teacher child classes

    ↓

Override the DisplayInfo() method in each child class

    ↓

Create a List<Person>

    ↓

Add Student and Teacher objects to the list

    ↓

Loop through each Person object

    ↓

Call DisplayInfo()

    ↓

Runtime identifies the actual object type

    ↓

Execute the appropriate overridden DisplayInfo() method

    ↓

Display the object-specific information

    ↓

End