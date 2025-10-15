using System;

namespace DayWisePractice.Day6
{
    public static class Day6_Static_Inheritance_Encapsulation
    {
        // Task 1 – Static Example
        public static class MathHelper
        {
            public static double Pi = 3.14159; //static filed

            public static double CalculateCircleArea(double radius) //static method
                => Pi * radius * radius;

            public static double CalculateSquareArea(double side)
                => side * side;
        }

        // Task 2 – Inheritance Example
        public class Person
        {
            public string Name { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
            }
        }

        public class Employee : Person
        {
            public double Salary { get; set; }

            public void ShowEmployeeDetails()
            {
                DisplayInfo();
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        // Task 3 – Encapsulation Example
        public class Account
        {
            private double _balance;

            public double Balance => _balance; // Read-only property

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    _balance += amount;
                    Console.WriteLine($"Deposited: {amount}");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount <= _balance)
                {
                    _balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!");
                }
            }
        }

        // Task 4 – Inheritance + Encapsulation
        public class BaseAccount
        {
            public string AccountNumber { get; set; }
            protected double Balance { get; set; }

            public void ShowBalance() => Console.WriteLine($"Balance: {Balance}");
        }

        public class SavingsAccount : BaseAccount
        {
            public double InterestRate { get; set; }

            public void ApplyInterest()
            {
                Balance += Balance * (InterestRate / 100);
                Console.WriteLine($"Interest Applied. New Balance: {Balance}");
            }
        }

        // Run all examples
        public static void Run()
        {
            Console.WriteLine("=== Task 1: Static Example ===");
            Console.WriteLine($"Circle Area: {MathHelper.CalculateCircleArea(5)}");
            Console.WriteLine($"Square Area: {MathHelper.CalculateSquareArea(4)}");

            Console.WriteLine("\n=== Task 2: Inheritance Example ===");
            Employee emp = new Employee { Name = "Pradip", Salary = 50000 };
            emp.ShowEmployeeDetails();

            Console.WriteLine("\n=== Task 3: Encapsulation Example ===");
            Account acc = new Account();
            acc.Deposit(1000);
            acc.Withdraw(300);
            acc.Withdraw(1000);
            Console.WriteLine($"Balance: {acc.Balance}");

            Console.WriteLine("\n=== Task 4: Inheritance + Encapsulation ===");
            SavingsAccount sa = new SavingsAccount { AccountNumber = "SAV123", InterestRate = 5 };
            sa.ApplyInterest(); // Will apply on default 0
        }
    }
}
