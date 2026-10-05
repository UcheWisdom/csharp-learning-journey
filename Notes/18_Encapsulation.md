# Lesson 18 — Encapsulation

## 1. What is Encapsulation?

Encapsulation is the object-oriented programming principle of controlling how an object's data is accessed and modified.

Instead of allowing outside code to directly change important internal data, the class protects its internal state and provides controlled ways to interact with it.

In simple terms:

> Encapsulation means protecting an object's data and controlling how that data can be accessed or changed.

---

## 2. Why Encapsulation is Important

Encapsulation helps to:

- Protect object data from invalid changes.
- Control how data is modified.
- Keep validation rules inside the class.
- Prevent unwanted direct access to internal state.
- Make code easier to maintain.
- Keep business rules close to the data they control.
- Reduce the possibility of inconsistent object state.

---

## 3. Private Fields

A private field is a variable inside a class that cannot be accessed directly from outside the class.

Example:

````csharp
class Student
{
    private int score;
}
````

---

## 4.Public Properties

A property provides controlled access to data inside a class.

Example:
````csharp
public int Score
{
    get
    {
        return score;
    }

    set
    {
        score = value;
    }
}
````
The property provides a controlled gateway to the private field.

---

## 5. Getter

The get accessor determines what happens when a property is read.

Example:
````csharp
get
{
    return score;
}
````
When we write:
```csharp
Console.WriteLine(student.Score);
```
The get accessor is called, and it returns the value of the private field `score`. The getter executes and returns the value stored in score.

---

## 6. Setter

The set accessor determines what happens when a property is assigned a value.

Example:
````csharp
set
{
    score = value;
}
````
The keyword value represents the value being assigned to the property.
Example:
```csharp 
student.Score = 50;
```
Here:
````csharp
value = 50
````

---

## 7. Backing Fields

A backing field is a private field used to store the actual value behind a property.

Example:
````csharp
private int score;

public int Score
{
    get
    {
        return score;
    }

    set
    {
        score = value;
    }
}
````

In this example:
- score is the backing field.
- Score is the public property.
- value is the value supplied to the setter.

---

## 8. Property Validation

One of the major benefits of encapsulation is that validation can be placed inside the property.

Example:
````csharp
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
````

This prevents invalid scores from being stored.

Example:
```csharp
student.Score = 50;
```

is valid.

But:
```csharp
student.Score = 150;
```
is invalid because a student score cannot be greater than 100.

---

## 9. Auto-Properties

An auto-property is useful when no custom validation or logic is required.

Example:
````csharp
public string? Name { get; set; }
````

C# automatically creates the required backing storage.

Auto-properties make simple properties shorter and easier to read.

---

## 10. Explicit Backing Field vs Auto-Property

Auto-property

Example:
````csharp
public string? Name { get; set; }
````

Use this when the property does not require special logic.

Backing field:
````csharp
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
    }
}
````

Use a backing field when the property requires custom behavior such as:
- Validation.
- Calculations.
- Notifications.
- Logging.
- Other business rules.

---

## 11. Private Setters

A property can have a private setter:

Example:
````csharp
public decimal Balance { get; private set; }
````

This means outside code can read the value but cannot directly change it.

The class itself can still modify the property.

This is useful when the class should control how its state changes.

---

## 12. Read-Only Properties

A property with only a getter can be used when outside code should only be able to read the value.

Example:
````csharp
public decimal Balance
{
    get
    {
        return balance;
    }
}
````

Outside code can read:

```
Console.WriteLine(account.Balance);
```

but cannot write:
```
account.Balance = 5000;
```

---

## 13. Encapsulation Through Methods

Sometimes state should be changed through methods rather than directly through a property.

Example:
````csharp
public void Deposit(decimal amount)
{
    if (amount > 0)
    {
        balance += amount;
    }
}
````

Instead of allowing outside code to directly modify the balance, the Deposit() method controls how the balance changes.

This allows the class to enforce its business rules.

---

## 14. Encapsulation Example — BankAccount

A bank account can contain:
```
private decimal balance;
```

The balance should not be freely modified by outside code.

Instead, methods such as:
```
Deposit()
Withdraw()
```

can control how the balance changes.

This helps prevent invalid states such as:
- Negative deposits.
- Withdrawals greater than the available balance.
- Uncontrolled balance modifications.

---

## Encapsulation Example — Student

The Student class can protect its score:

```
private int score;
```

The public property controls access:

````
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
````

This ensures that the Student object cannot contain an invalid score.

---

## 16. Information Hiding
Information hiding means hiding implementation details that other parts of the program do not need to know about.

For example, outside code does not need to know how GetGrade() determines the grade.

It only needs to call:
```csharp

student.GetGrade();
```
The internal grading logic remains inside the Student class.

---

## 17. Encapsulation vs Information Hiding
These concepts are related but not exactly the same.

Encapsulation
Focuses on:
- Bundling data and behavior together.
- Controlling access to object state.
- Protecting and managing object state.

Information Hiding
Focuses on:

- Hiding unnecessary implementation details.
- Exposing only what other parts of the program need to use.

---

## 18. Encapsulation vs Abstraction

Encapsulation
Controls access to an object's internal state.

Example:
```csharp   
private int score;
```

Abstraction
Focuses on exposing essential behavior while hiding implementation details.

Example:
```csharp
abstract class Shape
{
    public abstract double CalculateArea();
}
```

The user of the class knows that CalculateArea() exists without necessarily needing to know how every shape calculates its area.

---

## 19. Common Encapsulation Mistake

Incorrect:
```csharp
public int Score
{
    get
    {
        return score;
    }

    set
    {
        Score = value;
    }
}
```

The setter is assigning to Score again.

This causes the setter to call itself repeatedly, eventually resulting in a StackOverflowException.

Correct:
```csharp
set
{
    score = value;
}
```

The setter should update the backing field.

---

## 20. Lesson 18 Final Example

````csharp
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
````

---

## 21. Key Takeaways
- Encapsulation protects an object's internal state.
- private can hide internal fields.
- Properties provide controlled access to data.
- get reads a property.
- set changes a property.
- value represents the value supplied to a setter.
- A backing field stores the actual data.
- Auto-properties are useful for simple properties.
- Backing fields are useful when custom logic is required.
- Validation can be placed inside setters.
- Methods can provide controlled state-changing operations.
- private set prevents outside code from directly assigning a property.
- Read-only properties expose information without allowing direct modification.
- Encapsulation and abstraction are related but solve different problems.
- Information hiding focuses on hiding unnecessary implementation details.

---
