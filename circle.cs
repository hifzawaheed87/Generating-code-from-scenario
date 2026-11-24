// Make following Class in C# for Circle.

// ● Two data members:
// 1. radius (of the type double)
// 2. color (of the type String).
// ● Make Three constructors:
// 1. One with default constructor with default value of 1.0 and "red", respectively.
// 2. One Constructor that takes only the radius as parameter
// 3. And Another constructor which takes radius and color

using System;

class Circle
{
    // Data members
    public double radius;
    public string color;

    // 1. Default Constructor
    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    // 2. Constructor with radius only
    public Circle(double radius)
    {
        this.radius = radius;
        color = "red";
    }

    // 3. Constructor with radius and color
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    // 4. Copy Constructor
    public Circle(Circle c)
    {
        radius = c.radius;
        color = c.color;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Color: " + color);
    }
}

class Program
{
    static void Main()
    {
        // Default constructor
        Circle c1 = new Circle();

        // Radius constructor
        Circle c2 = new Circle(5.0);

        // Radius and color constructor
        Circle c3 = new Circle(7.5, "Blue");

        // Copy constructor
        Circle c4 = new Circle(c3);

        Console.WriteLine("Circle 1:");
        c1.Display();

        Console.WriteLine("\nCircle 2:");
        c2.Display();

        Console.WriteLine("\nCircle 3:");
        c3.Display();

        Console.WriteLine("\nCircle 4 (Copy of Circle 3):");
        c4.Display();
    }
}