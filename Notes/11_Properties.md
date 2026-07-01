# Properties in C#

## Definition

A property provides controlled access to a field.

## Why use properties?

- Encapsulation
- Validation
- Readability
- Flexibility

## Syntax

```csharp
private int score;

public int Score
{
    get { return score; }
    set
    {
        if (value >= 0 && value <= 100)
        {
            score = value;
        }
    }
}
```

## Example

...

## Common Mistakes

❌ Calling the property inside its own setter:

```csharp
Score = value;
```

This causes infinite recursion.

✅ Correct:

```csharp
score = value;
```

## Real-world usage

Used in:

- ASP.NET Core Models
- Entity Framework
- JSON Serialization