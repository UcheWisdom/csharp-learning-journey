# Lesson 15 - Polymorphism

## Objective
Learn how polymorphism builds on inheritance to allow a single variable type to hold different objects at runtime, and understand how C# determines which method to execute dynamically.

---

## Algorithm
 Start

    ↓

Create Person parent class

    ↓

Create Student and Teacher child classes

    ↓

Override DisplayInfo()

    ↓

Create List<Person>

    ↓

Add Student object

    ↓

Add Teacher objects

    ↓

Loop through List<Person>

    ↓

Call DisplayInfo()

    ↓

Runtime identifies actual object type

    ↓

Student → Student.DisplayInfo()
Teacher → Teacher.DisplayInfo()

    ↓

Display appropriate information

    ↓

End