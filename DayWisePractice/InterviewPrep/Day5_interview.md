# Day 4 – Interview Questions & Answers (Classes & Objects)

## 1 What is the difference between a class and an object?

✅ Answer:

Class: A blueprint or template that defines structure and behavior.
Example: Car class defines color, model, and speed.

Object: A real instance of the class created in memory.
Example: Car kia = new Car();

Example:

class Car
{
    public string Model;
}
Car kia = new Car(); // Object

## 2️ What are fields and properties in C#?

✅ Answer:

Fields: Variables declared inside a class (store data).

Properties: Special members that provide controlled access to fields using get and set.

Example:

class Student
{
    private int marks; // Field

    public int Marks   // Property
    {
        get { return marks; }
        set { marks = value; }
    }
}

## 3️ What is the purpose of a constructor? Can we overload constructors?

✅ Answer:

Constructor: A special method called automatically when an object is created.
It initializes fields or performs setup tasks.

Yes, we can overload constructors (define multiple constructors with different parameters).

Example:

class Employee
{
    public string Name;
    public double Salary;

    public Employee() { } // Default constructor
    public Employee(string name, double salary) // Overloaded
    {
        Name = name;
        Salary = salary;
    }
}

## 4️ What is a destructor? When is it called?

✅ Answer:

Destructor: Used to clean up resources before an object is destroyed.

Called automatically by the Garbage Collector — you can’t call it manually.

Example:

class Test
{
    ~Test()  // Destructor
    {
        Console.WriteLine("Destructor called.");
    }
}

## 5️ What is the use of the this keyword?

✅ Answer:

Used to refer to the current instance of a class.

Helps differentiate between class fields and local variables when they have the same name.

Example:

class Book
{
    string title;
    public Book(string title)
    {
        this.title = title; // 'this' refers to the class field
    }
}

## 6️ What is the difference between value type and reference type objects?

✅ Answer:

Type	Stored	Example	Behavior
Value Type	Stack	int, double, struct	Holds actual value
Reference Type	Heap	class, array, string	Holds memory reference (address)

Example:

int x = 10;     // Value type
int y = x;      // Copy value
y = 20;         // x is still 10

Person p1 = new Person(); // Reference type
Person p2 = p1;           // Both refer to same object

## 7️ Real-time: How would you design a BankAccount class?

✅ Answer:
Create a class with fields, methods, and validations to simulate a real bank account.

Example:

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient Balance");
    }

    public double GetBalance()
    {
        return balance;
    }
}


✅ Real-life analogy:

Deposit() → when you credit money

Withdraw() → when you debit money

GetBalance() → when you check your account balance