
/*

1. Encapsulation
Encapsulation involves bundling data (fields) and methods that operate on that data within a single unit (a class) 
and restricting direct access to some of the class's components. 
This is achieved using access modifiers like private, public, protected.

public class BankAccount
{
    private decimal _balance; // Private field, not directly accessible from outside

    public BankAccount(decimal initialBalance)
    {
        _balance = initialBalance;
    }

    public void Deposit(decimal amount) // Public method to modify balance
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public decimal GetBalance() // Public method to access balance
    {
        return _balance;
    }
}


2. Inheritance
Inheritance allows a new class (derived class) to inherit properties and methods from 
an existing class (base class), promoting code reusability and establishing "is-a" relationships.
Kod

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public virtual void StartEngine() // Virtual method to allow overriding
    {
        Console.WriteLine("Vehicle engine starting...");
    }
}

public class Car : Vehicle // Car inherits from Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void StartEngine() // Overriding the base method
    {
        Console.WriteLine("Car engine starting quietly...");
    }
}



3. Polymorphism
Polymorphism means "many forms." In C#, it allows objects of different classes to be treated as objects of a common base class or interface, enabling a single interface to be used for different data types. This is often achieved through method overriding and virtual methods.
Kod

public class Animal
{
    public virtual void MakeSound() // Virtual method
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound() // Overriding MakeSound
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound() // Overriding MakeSound
    {
        Console.WriteLine("Meow!");
    }
}

// Usage demonstrating polymorphism
public void DemonstratePolymorphism()
{
    Animal myDog = new Dog();
    Animal myCat = new Cat();
    Animal genericAnimal = new Animal();

    myDog.MakeSound(); // Calls Dog's MakeSound
    myCat.MakeSound(); // Calls Cat's MakeSound
    genericAnimal.MakeSound(); // Calls Animal's MakeSound
}



4. Interfaces
Interfaces define a contract of methods, properties, events, or indexers that a class must implement. They specify "what" a class can do, without defining "how" it does it.
Kod

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle : IShape // Circle implements IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

*/