using System;

//abstract class Animal
//{
//    public string Name { get; set; }

//    public Animal(string name)
//    {
//        Name = name;
//    }

//    public abstract void MakeSound();
//}

//class Dog : Animal
//{
//    public Dog(string name) : base(name)
//    {
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} says: Woof!");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name) : base(name)
//    {
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name} says: Meow!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal dog = new Dog("Rocky");
//        Animal cat = new Cat("Mimi");

//        dog.MakeSound();
//        cat.MakeSound();
//    }
//}


abstract class Shape
{
    public abstract double CalculateArea();

}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle { Radius = 5 },
            new Rectangle { Width = 4, Height = 6 }
        };



        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}