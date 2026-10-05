# Lesson 18 Algorithms — Encapsulation

## Algorithm 1: Encapsulate Object Data

1. Start.
2. Create a class.
3. Identify data that should be protected.
4. Declare the data as a private field.
5. Create a public property when controlled access is required.
6. Use a getter to read the private field.
7. Use a setter to control how the field can be changed.
8. Add validation where necessary.
9. Use the class from the program.
10. End.

---

## Algorithm 2: Validate Data Using a Property

1. Start.
2. Create a private backing field.
3. Create a public property.
4. Add a getter that returns the backing field.
5. Add a setter.
6. Receive the new value through the `value` keyword.
7. Check whether the value satisfies the required condition.
8. If the value is valid, assign it to the backing field.
9. If the value is invalid, reject it or throw an appropriate exception.
10. End.

---

## Algorithm 3: Control State Changes Using a Method

1. Start.
2. Create a private field to store the object's state.
3. Prevent direct external modification of the field.
4. Create a public method for the required operation.
5. Receive the required value as a parameter.
6. Validate the supplied value.
7. If the value is valid, update the private field.
8. If the value is invalid, reject the operation.
9. Return the appropriate result if necessary.
10. End.

---

## Algorithm 4: Create a Read-Only Property

1. Start.
2. Create a private field.
3. Create a public property.
4. Provide only a getter.
5. Return the private field from the getter.
6. Do not provide a public setter.
7. Allow other parts of the program to read the value.
8. Prevent direct external modification.
9. End.

---

## Algorithm 5: Implement Student Score Encapsulation

1. Start.
2. Create a `Student` class.
3. Create a `Name` property.
4. Create a private `score` field.
5. Create a public `Score` property.
6. Return `score` from the getter.
7. Receive the new score through `value`.
8. Check whether the score is between 0 and 100.
9. If valid, store the value in `score`.
10. If invalid, throw an `ArgumentOutOfRangeException`.
11. Create a `GetGrade()` method.
12. If the score is 70 or higher, return Grade A.
13. Otherwise, if the score is 50 or higher, return Grade B.
14. Otherwise, return Grade F.
15. Display the student's name, score, and grade.
16. End.

---

## Algorithm 6: Avoid Recursive Property Setters

1. Start.
2. Create a property with a getter and setter.
3. Identify the backing field.
4. In the setter, receive the new value through `value`.
5. Assign `value` to the backing field.
6. Do not assign `value` back to the same property.
7. Build and run the program.
8. End.