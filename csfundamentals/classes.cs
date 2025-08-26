// Define a class named 'Car'
public class Car
{
    // Property
    public string Model { get; set; }

    // Property
    public int Year { get; set; }

    // Constructor
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    // Method:
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Model: {Model}, Year: {Year}");
    }

    // Method: Another action the car can perform.
    public string Drive()
    {
        return $"{Model} is driving!";
    }
}
