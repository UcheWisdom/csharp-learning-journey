# Lesson 15 - Abstraction


## Objective
Learn how abstraction allows us to define a general structure or contract while leaving specific implementation details to derived classes.

---

### Algorithm

Save this separately as your Lesson 16 algorithm:

```markdown
# Lesson 16 - Abstraction Algorithm

Create an abstract Shape class
        ↓
Declare CalculateArea() as an abstract method
        ↓
Create Circle class that inherits from Shape
        ↓
Add Radius property to Circle
        ↓
Override CalculateArea() in Circle
        ↓
Create Rectangle class that inherits from Shape
        ↓
Add Width and Height properties to Rectangle
        ↓
Override CalculateArea() in Rectangle
        ↓
Create a List<Shape>
        ↓
Add Circle and Rectangle objects to the collection
        ↓
Loop through the Shape collection
        ↓
Call CalculateArea() for each object
        ↓
Runtime selects the appropriate overridden implementation
        ↓
Display each calculated area
        ↓
Program ends