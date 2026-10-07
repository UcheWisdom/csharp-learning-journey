# Lesson 19 — Exception Handling in C#

## 1. Introduction

Exception handling is a mechanism in C# used to detect, handle, and manage errors that occur while a program is running.

An exception is an unexpected condition that interrupts the normal flow of a program.

Examples include:

- Entering text when a number is expected.
- Dividing a number by zero.
- Using an invalid argument.
- Accessing an object that is `null`.
- Attempting an operation that cannot be completed.
- Trying to access an invalid position in a collection.

Exception handling helps programs respond to these situations instead of terminating unexpectedly.

---

## 2. What Is an Exception?

An exception is an object that represents an error or abnormal condition that occurs during program execution.

For example:

```csharp
int number = int.Parse("hello");
```

The string "hello" cannot be converted into an integer, so C# throws a FormatException.
Instead of allowing the program to terminate, the exception can be handled with try and catch.

---

## 3. The try Block

The try block contains code that may cause an exception.

Example:
```csharp
try
{
    int number = int.Parse("hello");
}
```
If an exception occurs inside the try block, C# searches for a matching catch block.

---

## 4. The catch Block

The catch block handles an exception thrown from the try block.

Example:
```csharp
try
{
    int number = int.Parse("hello");
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number.");
}
```
The catch block prevents the exception from terminating the program unexpectedly.

---

## 5. The Exception Object

A catch block can receive the exception object:

Example:
```csharp
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
```

The variable ex contains information about the exception.

One commonly used property is:

```chsarp
ex.Message
```

which provides a description of the error.

## 6. The finally Block

The finally block contains code that should normally execute after the try/catch process.

Example:
```csharp
try
{
    Console.WriteLine("Trying...");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program finished.");
}
```

The finally block is commonly used for cleanup operations such as releasing resources.

## 7. Common Exception Types

### FormatException

Occurs when a value cannot be converted into the expected format.

Example:
```csharp
int age = int.Parse("hello");
```

### DivideByZeroException

Occurs when an integer or decimal division attempts to divide by zero.

Example:
```Csharp
int result = 10 / 0;
```

ArgumentException

Occurs when an invalid argument is passed to a method.

Example:
```Csharp
throw new ArgumentException("Invalid argument.");
```

### ArgumentOutOfRangeException

Occurs when an argument is outside the permitted range.

Example:
```csharp
if (age < 0)
{
    throw new ArgumentOutOfRangeException(
        nameof(age),
        age,
        "Age cannot be negative."
    );
}
```

### InvalidOperationException

Occurs when a requested operation is invalid for the current state of an object.

Example:
```csharp
if (amount > balance)
{
    throw new InvalidOperationException(
        "Insufficient balance."
    );
}
```

### Exception

Exception is the base class for exceptions in .NET.

Example:
```csharp
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

A general Exception catch can be used as a final safety net, but specific exception types should normally be handled first.


---

## 8. Multiple catch Blocks

A program can have multiple catch blocks for handling different types of exceptions.

Example:
```csharp
try
{
    int age = int.Parse(input);

    if (age < 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(age),
            age,
            "Age cannot be negative."
        );
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Please enter a valid number.");
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred.");
}
```

Each exception type can receive different handling.

---

## 9. Catch Order

The order of catch blocks is important.

Specific exception types should be placed before broader exception types.

Correct:
```csharp
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

Incorrect:
```csharp
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
```

The second example is incorrect because Exception is broad enough to catch the ArgumentException before the more specific handler can be reached.

---

## 10. The throw Keyword

The throw keyword is used to create and raise an exception.

Example:
```csharp
if (age < 18)
{
    throw new ArgumentException(
        "Age must be 18 or older."
    );
}
```

The throw statement interrupts the current operation and transfers control to a matching catch block.

---

## 11. Throwing Exceptions from Methods

Exceptions can be thrown inside methods.

Example:
```csharp
static void CheckAge(int age)
{
    if (age < 18)
    {
        throw new ArgumentException(
            "Age must be 18 or older."
        );
    }

    Console.WriteLine("You are eligible.");
}
```

The method does not have to handle its own exception.

Another part of the program can handle it:

```csharp
try
{
    CheckAge(15);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
```

This separates the responsibility of detecting a problem from the responsibility of handling it.

---

## 12. throw vs catch

The two keywords have different responsibilities.

#### throw

Creates or raises an exception.
```csharp
throw new ArgumentException("Invalid age.");
```

#### catch

Handles an exception.
```csharp
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
```

A simple way to remember this is:

```
throw = report the problem
catch = handle the problem
```

---

## 13. Parse vs TryParse

Parse() attempts to convert a string and throws an exception if the conversion fails.

Example:
```csharp
int age = int.Parse(input);
``` 

If input is "hello", a FormatException is thrown.

TryParse() attempts the conversion without throwing an exception for normal invalid input.

Example:
```csharp
if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Age: {age}");
}
else
{
    Console.WriteLine("Invalid age.");
}
```

#### General rule

Use TryParse() when invalid user input is an expected possibility.

Use exceptions when something unexpected or invalid occurs that should interrupt the normal operation.

---

## 14. Rethrowing Exceptions

An exception can be rethrown from a catch block.

Preferred:
```csharp
catch (Exception ex)
{
    throw;
}
```
Using:
```
throw;
```
preserves the original exception's stack trace.

Avoid unnecessarily using:
```
catch (Exception ex)
{
    throw ex;
}
```

when the intention is simply to rethrow the same exception.

---

## 15. Exception Hierarchy

Many C# exception types inherit from other exception types.

A simplified hierarchy is:
```
Exception
│
├── SystemException
│   ├── FormatException
│   ├── InvalidOperationException
│   └── ...
│
└── ArgumentException
    ├── ArgumentNullException
    └── ArgumentOutOfRangeException
```

This inheritance relationship explains why specific exceptions must normally be caught before general exceptions.

## 16. Exception Handling in Constructors

Exceptions can also be used to prevent invalid objects from being created.

Example:
```csharp
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Student name cannot be empty."
            );
        }

        if (age < 16)
        {
            throw new ArgumentOutOfRangeException(
                nameof(age),
                "Student must be at least 16 years old."
            );
        }

        Name = name;
        Age = age;
    }
}
```

This ensures that a Student object cannot be created with invalid data.

## 17. Complete Student Registration Example

```csharp
using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Student name cannot be empty."
            );
        }

        if (age < 16)
        {
            throw new ArgumentOutOfRangeException(
                nameof(age),
                "Student must be at least 16 years old."
            );
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
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());

            Student student = new Student(name, age);

            Console.WriteLine(
                $"Student registered: {student.Name}, Age: {student.Age}"
            );
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
            Console.WriteLine(
                "Please enter a valid number for age."
            );
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "An unexpected error occurred."
            );
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(
                "Student registration process completed."
            );
        }
    }
}
```

## 18. Important Best Practices
1. Catch specific exceptions

Prefer:
```
catch (FormatException ex)
{
    ...
}
```

instead of immediately catching everything:

```
catch (Exception ex)
{
    ...
}
```

### 2. Do not use exceptions for normal control flow

For expected invalid numeric input, prefer:
```
int.TryParse(...)
```

instead of deliberately causing an exception.

### 3. Provide useful error messages

Prefer:
```
throw new ArgumentException(
    "Student name cannot be empty."
);
```

instead of:

```
throw new Exception("Error");
```

### 4. Preserve the original exception when rethrowing

Use:
```
throw;
```

instead of:

```
throw ex;
```

### 5. Validate data at appropriate boundaries

Constructors, methods, and other public APIs should validate data when necessary.

---

## 19. Key Concepts to Remember

| Concept                       | Purpose                                                              |
| ----------------------------- | -------------------------------------------------------------------- |
| `try`                         | Contains code that may throw an exception                            |
| `catch`                       | Handles an exception                                                 |
| `finally`                     | Performs code that should normally run afterward                     |
| `throw`                       | Creates/raises an exception                                          |
| `Exception`                   | Base exception class                                                 |
| `FormatException`             | Invalid conversion format                                            |
| `ArgumentException`           | Invalid method argument                                              |
| `ArgumentOutOfRangeException` | Argument outside allowed range                                       |
| `InvalidOperationException`   | Operation is invalid in current state                                |
| `TryParse()`                  | Safely attempts conversion without throwing for normal invalid input |



- Use try around code that may throw an exception.
- Use catch to handle exceptions.
- Use finally for cleanup or final actions.
- Use throw to raise an exception intentionally.
- Catch specific exceptions before general exceptions.
- Use TryParse() for expected invalid numeric input.
- Use ArgumentException when an argument is invalid.
- Use ArgumentOutOfRangeException when a value is outside the allowed range.
- Use InvalidOperationException when an operation is invalid in the current state.
- Use FormatException when a value cannot be converted because its format is invalid.
- Use Exception as a general fallback when appropriate.
- Use throw; when rethrowing an existing exception.
- Avoid using exceptions as normal program control flow.
- Validate data before creating objects when necessary.


---



## 20. Lesson Summary
Exception handling allows C# programs to respond to runtime problems in a controlled manner.

The basic pattern is:
```
try
   ↓
Attempt operation
   ↓
Exception?
   ├── No → Continue
   │
   └── Yes
        ↓
      catch
        ↓
      Handle error
        ↓
      finally
```

The most important principles from this lesson are:

- Use try for code that may throw.
- Use catch to handle exceptions.
- Use specific exception types when possible.
- Put specific catches before general catches.
- Use throw when a condition should be treated as an exception.
- Use finally for cleanup/finalization work.
- Use TryParse() for expected invalid user input.
- Do not use exceptions as normal program flow.
- Use meaningful exception messages.
- Use throw; when rethrowing an existing exception.
