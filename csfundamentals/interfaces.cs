/*

// Define an interface
public interface IShape
{
    // Method signature (no implementation)
    double CalculateArea();

    // Property signature (no implementation)
    string Name { get; set; }
}

// Implement the interface in a class
public class Circle : IShape
{
    public double Radius { get; set; }

    // Constructor
    public Circle(double radius, string name)
    {
        Radius = radius;
        Name = name;
    }

    // Implementation of the CalculateArea method
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Implementation of the Name property
    public string Name { get; set; }
}

// Implement the interface in another class
public class Square : IShape
{
    public double SideLength { get; set; }

    // Constructor
    public Square(double sideLength, string name)
    {
        SideLength = sideLength;
        Name = name;
    }

    // Implementation of the CalculateArea method
    public double CalculateArea()
    {
        return SideLength * SideLength;
    }

    // Implementation of the Name property
    public string Name { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of classes implementing the interface
        IShape circle = new Circle(5, "My Circle");
        IShape square = new Square(4, "My Square");

        // Call interface methods and access properties
        Console.WriteLine($"Shape: {circle.Name}, Area: {circle.CalculateArea()}");
        Console.WriteLine($"Shape: {square.Name}, Area: {square.CalculateArea()}");
    }
}

*/