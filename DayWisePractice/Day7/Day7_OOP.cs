using System;

namespace DayWisePractice.Day7
{
    // =====================================================
    // 🔹 Day 7 - OOP Concepts: Inheritance, Polymorphism,
    //             Abstract Classes & Interfaces
    // =====================================================
    // 👉 We keep it "public static" because:
    // 1. It's used as a demo/runner utility.
    // 2. We access it directly from Program.cs without instantiation.
    // 3. It's not meant to be part of domain models.
    public static class Day7_OOP
    {
        // =====================================================
        // 🧩 TASK 1 – INHERITANCE EXAMPLE
        // Base class: Person
        // Derived class: Student inherits Person
        // =====================================================
        class Person
        {
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine($"Person Name: {Name}");
            }
        }

        class Student : Person
        {
            public int RollNo { get; set; }

            public void ShowStudentDetails()
            {
                // Using inherited Display() from Person
                Display();
                Console.WriteLine($"Roll No: {RollNo}");
            }
        }

        // =====================================================
        // 🧩 TASK 2 – POLYMORPHISM EXAMPLE
        // Base class: Shape
        // Derived classes: Circle, Rectangle
        // Demonstrates: Method overriding using virtual/override
        // =====================================================
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing Shape");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Circle");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Rectangle");
            }
        }

        // =====================================================
        // 🧩 TASK 3 – ABSTRACT CLASS EXAMPLE
        // Base Abstract Class: Employee
        // Derived Classes: FullTimeEmployee, PartTimeEmployee
        // Demonstrates: Abstract methods must be implemented by derived classes
        // =====================================================
        abstract class Employee
        {
            public string Name { get; set; }

            public abstract double CalculateSalary();
        }

        class FullTimeEmployee : Employee
        {
            public double MonthlySalary { get; set; }

            public override double CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        class PartTimeEmployee : Employee
        {
            public double HourlyRate { get; set; }
            public int HoursWorked { get; set; }

            public override double CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
        }

        // =====================================================
        // 🧩 TASK 4 – INTERFACE EXAMPLE
        // Interface: IPrintable
        // Classes: Book, Magazine implement interface
        // Demonstrates: Multiple classes sharing same contract
        // =====================================================
        interface IPrintable
        {
            void PrintDetails();
        }

        class Book : IPrintable
        {
            public string Title { get; set; }

            public void PrintDetails()
            {
                Console.WriteLine($"Book Title: {Title}");
            }
        }

        class Magazine : IPrintable
        {
            public string Name { get; set; }

            public void PrintDetails()
            {
                Console.WriteLine($"Magazine Name: {Name}");
            }
        }

        // =====================================================
        // 🧩 TASK 5 – REAL-WORLD COMBINED EXAMPLE
        // Interface: IEngine
        // Base Class: Vehicle
        // Derived Classes: Car, Bike implement IEngine
        // Demonstrates: Inheritance + Interface Implementation
        // =====================================================
        interface IEngine
        {
            void StartEngine();
        }

        class Vehicle
        {
            public string Model { get; set; }

            public void DisplayModel()
            {
                Console.WriteLine($"Model: {Model}");
            }
        }

        class Car : Vehicle, IEngine
        {
            public void StartEngine()
            {
                Console.WriteLine("Car engine started with key ignition");
            }
        }

        class Bike : Vehicle, IEngine
        {
            public void StartEngine()
            {
                Console.WriteLine("Bike engine started with self-start button");
            }
        }

        // =====================================================
        // 🚀 RUN METHOD – Executes all above examples sequentially
        // =====================================================
        public static void Run()
        {
            Console.WriteLine("========== DAY 7 - OOP CONCEPTS ==========\n");

            // ---------- Task 1 ----------
            Console.WriteLine("Task 1: Inheritance Example");
            Student s1 = new Student() { Name = "Pradip", RollNo = 101 };
            s1.ShowStudentDetails();
            Console.WriteLine("------------------------------------------\n");

            // ---------- Task 2 ----------
            Console.WriteLine("Task 2: Polymorphism Example");
            Shape shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();

            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
            Console.WriteLine("------------------------------------------\n");

            // ---------- Task 3 ----------
            Console.WriteLine("Task 3: Abstract Class Example");
            Employee e1 = new FullTimeEmployee() { Name = "John", MonthlySalary = 50000 };
            Employee e2 = new PartTimeEmployee() { Name = "Rahul", HourlyRate = 500, HoursWorked = 20 };

            Console.WriteLine($"{e1.Name} Salary: {e1.CalculateSalary()}");
            Console.WriteLine($"{e2.Name} Salary: {e2.CalculateSalary()}");
            Console.WriteLine("------------------------------------------\n");

            // ---------- Task 4 ----------
            Console.WriteLine("Task 4: Interface Example");
            IPrintable book = new Book() { Title = "Mastering C#" };
            IPrintable magazine = new Magazine() { Name = "Tech Today" };

            book.PrintDetails();
            magazine.PrintDetails();
            Console.WriteLine("------------------------------------------\n");

            // ---------- Task 5 ----------
            Console.WriteLine("Task 5: Real-World Combined Example");
            Car car = new Car() { Model = "Kia Seltos" };
            Bike bike = new Bike() { Model = "Yamaha R15" };

            car.DisplayModel();
            car.StartEngine();

            bike.DisplayModel();
            bike.StartEngine();
            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("✅ All Day 7 tasks executed successfully!");
        }
    }
}
