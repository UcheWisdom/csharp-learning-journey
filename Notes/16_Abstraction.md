# Lesson 16 - Abstraction

## Objective

Learn how abstraction allows us to define a general structure or contract while leaving specific implementation details to derived classes.

---

## Definition

Abstraction is an Object-Oriented Programming concept that hides unnecessary implementation details and exposes only the essential behavior of an object.

In C#, abstraction can be implemented using abstract classes and abstract methods.

---

## Abstract Class

An abstract class is a class declared with the `abstract` keyword.

It is designed to serve as a base class and cannot be instantiated directly.

Example:

```csharp
abstract class Shape
{
    public abstract double CalculateArea();
}
```
An abstract class can contain properties, fields, constructors, and implemented methods, but it can also contain abstract methods that derived classes must implement.


## Abstract Method

An abstract method is declared without an implementation body.

Example:
```csharp
public abstract double CalculateArea();
```

A non-abstract derived class must provide an implementation using the override keyword.


## Implementing an Abstract Method
Example:
```csharp
class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
```
The override keyword provides the implementation required by the abstract base class.

## Abstraction and Polymorphism
Abstraction and polymorphism work together.

Example:
```csharp
Shape shape = new Circle();
shape.CalculateArea();
```

- Declared type: Shape
- Actual type: Circle
- Executed method: Circle.CalculateArea()

The variable uses the general Shape abstraction, while runtime polymorphism selects the specific implementation.


## Abstract vs Virtual

| Feature | Abstract | Virtual |
| :--- | :--- | :--- |
| Implementation in parent | No | Yes |
| Child must override | Yes | No |
| Requires `override` in child | Yes | Only when overriding |
| Can exist in abstract class | Yes | Yes |
| Main purpose | Define a required contract | Provide default behavior |

### Example Hierarchy
```
Shape
  |
  ├── Circle
  |
  └── Rectangle
  ```
  Shape defines the requirement:
  ```
  CalculateArea()
  ```
Circle and Rectangle provide their own implementations.

## Benefits of Abstraction
- Hides unnecessary implementation details.
- Establishes a common structure for related classes.
- Forces derived classes to implement required behavior.
- Works naturally with polymorphism.
- Reduces unnecessary coupling.
- Makes applications easier to extend and maintain.

## Key Takeaways
- An abstract class cannot be instantiated directly.
- An abstract method has no implementation body.
- Concrete child classes must implement inherited abstract methods.
- `override` provides the implementation of an inherited abstract or virtual method.
- Abstract classes can contain both implemented and abstract members.
- Abstraction defines what an object must do while derived classes define how it does it.
- Abstraction and polymorphism are commonly used together.

