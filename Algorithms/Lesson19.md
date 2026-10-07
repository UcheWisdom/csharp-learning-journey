
# 2. `Algorithms/Lesson19.md`

```markdown
# Lesson 19 — Exception Handling Algorithms

## Algorithm 1: Basic Exception Handling

### Purpose
Handle an operation that may produce an exception.

### Steps

1. Start the program.
2. Place the risky operation inside a `try` block.
3. Execute the operation.
4. If no exception occurs, continue normally.
5. If an exception occurs, identify its type.
6. Execute the matching `catch` block.
7. Execute the `finally` block if one exists.
8. End the program.

### Pseudocode

```text
START

TRY
    Perform operation

IF exception occurs
    CATCH exception
    Display error message

FINALLY
    Perform final operation

END
````


## Algorithm 2: Validate Age Using an Exception

### Purpose

Check whether an age is valid and throw an exception when the age is negative.

### Steps
- Start.
- Read the age.
- Convert the input to an integer.
- Check whether the age is less than zero.
- If the age is less than zero:
- Throw ArgumentOutOfRangeException.
- Otherwise:
- Display the age.
- Catch the exception if it occurs.
- Display the error message.
- Execute the finally block.
- End.

### Pseudocode
```
START

Read age

TRY
    Convert input to integer

    IF age < 0
        THROW ArgumentOutOfRangeException

    Display age

CATCH ArgumentOutOfRangeException
    Display error message

FINALLY
    Display "Program finished"

END
```

---

## Algorithm 3: Handle Multiple Exception Types

### Purpose

Handle different types of errors using separate catch blocks.

### Steps
- Start.
- Receive user input.
- Place the operation inside a try block.
- Attempt to convert the input.
- If the conversion format is invalid:
- Throw or receive FormatException.
- If the value is outside the permitted range:
- Throw or receive ArgumentOutOfRangeException.
- Handle each exception with its corresponding catch.
- Use a general Exception catch as a final fallback.
- Execute finally.
- End.

### Pseudocode
```
START

Read input

TRY
    Convert input

    IF value is outside allowed range
        THROW ArgumentOutOfRangeException

CATCH ArgumentOutOfRangeException
    Display range error

CATCH FormatException
    Display format error

CATCH Exception
    Display unexpected error

FINALLY
    Display completion message

END
```

---

## Algorithm 4: Validate Age with a Method

### Purpose

Use a separate method to validate an age and throw an exception when the age is below 18.

### Steps
- Start.
- Define a method named CheckAge.
- Pass the age to the method.
- Check whether the age is less than 18.
- If the age is less than 18:
  Throw ArgumentException.
- Otherwise:
  Display "You are eligible."
- In Main, call CheckAge() inside a try block.
- Catch ArgumentException.
- Display the exception message.
- Execute finally.
- End.

### Pseudocode
```
START

METHOD CheckAge(age)

    IF age < 18
        THROW ArgumentException

    ELSE
        Display "You are eligible."

END METHOD


MAIN

TRY
    Call CheckAge(age)

CATCH ArgumentException
    Display error message

FINALLY
    Display "Program finished"

END
```

---

## Algorithm 5: Validate a Bank Withdrawal

### Purpose

Validate a withdrawal operation using exceptions.

### Steps
- Start.
- Receive account balance.
- Receive withdrawal amount.
- Check whether the amount is less than or equal to zero.
- If true:
  Throw ArgumentException.
- Check whether the withdrawal amount is greater than the balance.
- If true:
  Throw InvalidOperationException.
- Otherwise:
  Perform the withdrawal.
- Display successful withdrawal.
- Catch the appropriate exception.
- Display the error message.
- Execute finally.
- End.


### Pseudocode
```
START

Set balance

Read withdrawal amount

TRY

    IF amount <= 0
        THROW ArgumentException

    IF amount > balance
        THROW InvalidOperationException

    balance = balance - amount

    Display "Withdrawal successful"

CATCH ArgumentException
    Display invalid amount message

CATCH InvalidOperationException
    Display insufficient balance message

FINALLY
    Display "Transaction completed"

END
```

---

## Algorithm 6: Student Registration Validation

### Purpose

Validate student information before creating a student object.

### Steps
- Start.
- Read the student's name.
- Read the student's age.
- Attempt to create a Student object.
- Check whether the name is empty.
- If the name is empty:
  Throw ArgumentException.
- Check whether the age is below 16.
- If the age is below 16:
  Throw ArgumentOutOfRangeException.
- If validation succeeds:
  Create the student object.
  Display the student's information.
- Catch ArgumentOutOfRangeException.
- Catch ArgumentException.
- Catch FormatException.
- Catch general Exception.
- Execute finally.
- End.

## Pseudocode
```
START

Read student name
Read student age

TRY

    IF name is empty
        THROW ArgumentException

    IF age < 16
        THROW ArgumentOutOfRangeException

    Create Student object

    Display student information

CATCH ArgumentOutOfRangeException
    Display age validation error

CATCH ArgumentException
    Display argument error

CATCH FormatException
    Display input format error

CATCH Exception
    Display unexpected error

FINALLY
    Display registration completion message

END
```

---

## Algorithm 7: Safe Number Conversion Using TryParse

### Purpose

Convert user input into an integer without throwing an exception for normal invalid input.

### Steps
- Start.
- Ask the user to enter a number.
- Use int.TryParse().
- If conversion succeeds:
  - Store the converted number.
  - Display the number.
- If conversion fails:
  - Display an invalid input message.
- End.

### Pseudocode
```
START

Read input

IF TryParse(input) succeeds
    Store number
    Display number
ELSE
    Display "Invalid number"

END
```

---

## Algorithm 8: Exception Handling Decision Process

### Purpose

Determine whether to use TryParse or exception handling.

### Steps
- Identify the possible problem.
- Determine whether the problem is expected during normal user interaction.
- If invalid user input is expected:
  - Prefer TryParse.
- If the problem represents an invalid operation or unexpected runtime condition:
    - Use an appropriate exception.
- Throw the appropriate exception when necessary.
- Handle the exception at the appropriate level.

### Pseudocode
```
START

Identify possible error

IF invalid user input is expected
    Use TryParse
ELSE IF operation is invalid
    Throw appropriate exception
ELSE
    Handle unexpected exception

END
```

---

## Algorithm 9: General Exception Handling Flow

### Pseudocode
```
START
    ↓
Execute risky operation
    ↓
Did an exception occur?
    ↓
 ┌───────────────┐
 │      NO       │
 └───────┬───────┘
         ↓
 Continue program

If YES
    ↓
Identify exception type
    ↓
Find matching catch block
    ↓
Handle exception
    ↓
Execute finally
    ↓
END
```
