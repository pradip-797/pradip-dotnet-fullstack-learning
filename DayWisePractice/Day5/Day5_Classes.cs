using System;

namespace DayWisePractice.Day5
{
    /// <summary>
    /// Day 5 – Classes & Objects in C#
    /// Contains all tasks: Student, Employee, BankAccount, Book
    /// </summary>
    public static class Day5_Classes
    {
        // ------------------ Task 1 – Student Class ------------------
        public class Student
        {
            public string Name;   // field
            public int RollNo;    // field
            public int Marks;     // field

            // Method to display student details
            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Student: {Name}, Roll No: {RollNo}, Marks: {Marks}");
            }
        }

        // ------------------ Task 2 – Employee with Constructor ------------------
        public class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            // Constructor initializes Name and Salary
            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
            }
        }

        // ------------------ Task 3 – Bank Account Example ------------------
        public class BankAccount
        {
            public string AccountNumber { get; set; }
            public double Balance { get; private set; } // private set ensures balance changes only via methods

            // Constructor
            public BankAccount(string accountNumber, double initialBalance)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
            }

            public void Withdraw(double amount)
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Insufficient balance. Transaction cancelled.");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
                }
            }

            public void GetBalance()
            {
                Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
            }
        }

        // ------------------ Task 4 – this Keyword Example ------------------
        public class Book
        {
            private string title;
            private string author;

            // Constructor uses 'this' to differentiate between parameters and fields
            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

            public void ShowBook()
            {
                Console.WriteLine($"Book: {title}, Author: {author}");
            }
        }

        // ------------------ Run Method to Test All Tasks ------------------
        public static void Run()
        {
            Console.WriteLine("=== Day 5 Tasks ===");

            // Task 1
            Console.WriteLine("\nTask 1: Student Class");
            Student s1 = new Student { Name = "Pradip", RollNo = 101, Marks = 90 };
            s1.DisplayStudentInfo();

            // Task 2
            Console.WriteLine("\nTask 2: Employee Constructor");
            Employee e1 = new Employee("Amit", 50000);
            e1.ShowDetails();

            // Task 3
            Console.WriteLine("\nTask 3: Bank Account");
            BankAccount account = new BankAccount("ACC123", 1000);
            account.GetBalance();
            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(2000); // test insufficient balance

            // Task 4
            Console.WriteLine("\nTask 4: Book with this keyword");
            Book b1 = new Book("C# in Depth", "Jon Skeet");
            b1.ShowBook();
        }
    }
}
