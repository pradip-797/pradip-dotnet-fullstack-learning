## Day 8 – Interview Questions & Answers (Inheritance, overloading, base, sealed class)

## 1. What is Inheritance in C#?

Answer:
Inheritance is an object-oriented programming concept that allows one class (child/derived) to acquire the properties and methods of another class (parent/base).
It promotes code reusability, scalability, and polymorphism in applications.

##  2. What are the types of inheritance supported in C#?

Answer:
C# supports the following inheritance types:

Single Inheritance – One class inherits from another.

Multilevel Inheritance – A class inherits from a derived class.

Hierarchical Inheritance – Multiple classes inherit from the same base.

Multiple Inheritance (via Interface) – A class implements multiple interfaces.

❌ Note: C# does not support multiple inheritance through classes to avoid ambiguity (Diamond Problem).

## 3. What is the difference between a base class and a derived class?

Answer:

Base Class → Parent class that defines common functionality.

Derived Class → Child class that inherits or extends base functionality.

Example:

class Animal { public void Eat() { } }  
class Dog : Animal { public void Bark() { } }


Here, Animal is the base class and Dog is the derived class.

## 4. What is the role of the base keyword in C#?

Answer:
The base keyword is used to:

Call the base class constructor from a derived class constructor.

Access base class members hidden by derived class members.

Example:

class Vehicle
{
    public Vehicle(string brand)
    {
        Console.WriteLine($"Vehicle brand: {brand}");
    }
}

class Car : Vehicle
{
    public Car(string brand, string model) : base(brand)
    {
        Console.WriteLine($"Car model: {model}");
    }
}

## 5. What is Method Overriding?

Answer:
Method overriding allows a derived class to modify or replace a base class method using override.

✅ Requirements:

Base method must be marked as virtual.

Derived method must use override.

Example:

class Employee
{
    public virtual void Display() => Console.WriteLine("Employee Details");
}

class Manager : Employee
{
    public override void Display() => Console.WriteLine("Manager Details");
}

## 6. What is the difference between new and override keywords?

Answer:

Keyword	Purpose	Behavior
new	Hides base method	Static decision
override	Replaces base method	Dynamic decision (runtime)

Example:

class A { public void Show() => Console.WriteLine("A"); }
class B : A { public new void Show() => Console.WriteLine("B"); } // hides base

## 7. What is a sealed class in C# and when should you use it?

Answer:
A sealed class cannot be inherited.
Used for:

Security or preventing misuse of base logic.

Performance optimization (no virtual table lookup).

Example:

sealed class Report
{
    public void Generate() => Console.WriteLine("Final Report Generated");
}

## 8. How does C# handle multiple inheritance?

Answer:
C# supports multiple inheritance using interfaces only, not classes, to avoid ambiguity.

Example:

interface IWorkable { void Work(); }
interface IReportable { void Report(); }

class Engineer : IWorkable, IReportable
{
    public void Work() => Console.WriteLine("Engineer Working...");
    public void Report() => Console.WriteLine("Engineer Reporting...");
}

## 9. Can constructors be inherited?

Answer:
No, constructors are not inherited, but they can be invoked using the base() keyword in a derived class.

## 10. Real-time Example: How would you design a class hierarchy for Vehicles?

Answer:
Scenario: You want to represent multiple vehicle types in a transport system.

class Vehicle
{
    public string Brand;
    public void Start() => Console.WriteLine($"{Brand} starting...");
}

class Car : Vehicle
{
    public string Model;
    public void Drive() => Console.WriteLine($"{Brand} {Model} is driving...");
}

class ElectricCar : Car
{
    public int Battery;
    public void Charge() => Console.WriteLine($"{Brand} {Model} charging...");
}


✅ Use Case:

Vehicle – base features shared by all vehicles.

Car – extends features for fuel cars.

ElectricCar – adds battery-specific logic.
This is multilevel inheritance in real systems.

Extra / Code Snippet Example
// ✅ Quick Example of Method Overriding
class BaseClass
{
    public virtual void Greet() => Console.WriteLine("Hello from Base!");
}

class DerivedClass : BaseClass
{
    public override void Greet() => Console.WriteLine("Hello from Derived!");
}

class Program
{
    static void Main()
    {
        BaseClass obj = new DerivedClass();
        obj.Greet(); // Output: Hello from Derived!
    }
}
