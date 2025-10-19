using System;

namespace DayWisePractice.Day8
{
    // ===============================================
    // 📘 DAY 8 – INHERITANCE (DEEP DIVE)
    // ===============================================
    // Concept: Inheritance allows a class (child/derived)
    // to reuse and extend functionality of another class (base/parent).
    // It helps achieve reusability, maintainability, and polymorphism.

    // ===============================================
    // 🧩 Task 1 – Single Inheritance Example
    // ===============================================
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    // Dog inherits from Animal
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking...");
        }
    }

    // ===============================================
    // 🧩 Task 2 – Multilevel Inheritance Example
    // ===============================================
    public class Vehicle
    {
        public string Brand;

        // Base constructor
        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle Created: {Brand}");
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} Vehicle Started");
        }
    }

    // Car inherits from Vehicle
    public class Car : Vehicle
    {
        public string Model;

        public Car(string brand, string model)
            : base(brand) // 👈 base constructor call (constructor chaining)
        {
            Model = model;
            Console.WriteLine($"Car Created: {Brand} {Model}");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving...");
        }
    }

    // ElectricCar inherits from Car
    public class ElectricCar : Car
    {
        public int BatteryCapacity;

        public ElectricCar(string brand, string model, int batteryCapacity)
            : base(brand, model)
        {
            BatteryCapacity = batteryCapacity;
            Console.WriteLine($"Electric Car Created with {BatteryCapacity} kWh battery");
        }

        public void Charge()
        {
            Console.WriteLine($"{Brand} {Model} is charging...");
        }
    }

    // ===============================================
    // 🧩 Task 3 – Method Overriding Example
    // ===============================================
    public class Employee
    {
        public string Name;
        public double BaseSalary;

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        // Virtual method allows derived classes to override
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {BaseSalary}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, double baseSalary, int teamSize)
            : base(name, baseSalary)
        {
            TeamSize = teamSize;
        }

        // Override base method
        public override void DisplayDetails()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {BaseSalary}, Team Size: {TeamSize}");
        }
    }

    // ===============================================
    // 🧩 Task 4 – Sealed Class Example
    // ===============================================
    // sealed prevents further inheritance
    public sealed class FinalReport
    {
        public void Generate()
        {
            Console.WriteLine("Final Report Generated Successfully!");
        }
    }

    // ❌ Below class would give compile-time error if uncommented
    // public class SubReport : FinalReport { }

    // ===============================================
    // 🧩 Task 5 – Interface Multiple Inheritance Example
    // ===============================================
    public interface IWorkable
    {
        void Work();
    }

    public interface IReportable
    {
        void Report();
    }

    public class Engineer : IWorkable, IReportable
    {
        public void Work()
        {
            Console.WriteLine("Engineer is working on a project...");
        }

        public void Report()
        {
            Console.WriteLine("Engineer submitted the daily report.");
        }
    }

    // ===============================================
    // 🚀 Run Method – Execute All Tasks
    // ===============================================
    public static class Day8_Inheritance
    {
        public static void Run()
        {
            Console.WriteLine("========== DAY 8: INHERITANCE DEEP DIVE ==========\n");

            // -------------------------
            // Task 1: Single Inheritance
            // -------------------------
            Console.WriteLine("Task 1: Single Inheritance Example");
            Dog dog = new Dog();
            dog.Eat(); // from base class
            dog.Bark(); // from derived class
            Console.WriteLine();

            // -------------------------
            // Task 2: Multilevel Inheritance
            // -------------------------
            Console.WriteLine("Task 2: Multilevel Inheritance Example");
            ElectricCar tesla = new ElectricCar("Tesla", "Model S", 100);
            tesla.Start();
            tesla.Drive();
            tesla.Charge();
            Console.WriteLine();

            // -------------------------
            // Task 3: Method Overriding
            // -------------------------
            Console.WriteLine("Task 3: Method Overriding Example");
            Employee emp = new Employee("Ravi", 40000);
            Manager mgr = new Manager("Anjali", 90000, 8);
            emp.DisplayDetails();  // base method
            mgr.DisplayDetails();  // overridden method
            Console.WriteLine();

            // -------------------------
            // Task 4: Sealed Class Example
            // -------------------------
            Console.WriteLine("Task 4: Sealed Class Example");
            FinalReport report = new FinalReport();
            report.Generate();
            Console.WriteLine();

            // -------------------------
            // Task 5: Interface Inheritance
            // -------------------------
            Console.WriteLine("Task 5: Interface Multiple Inheritance Example");
            Engineer eng = new Engineer();
            eng.Work();
            eng.Report();
            Console.WriteLine();

            Console.WriteLine("========== END OF DAY 8 ==========");
        }
    }
}
