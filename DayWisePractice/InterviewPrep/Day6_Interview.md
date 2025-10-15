## Day 6 – Interview Questions & Answers (Static, Inheritance & Encapsulation)

## 1. What is the static keyword in C#?

Answer:
The static keyword is used to define members that belong to the class itself, not to any specific instance.
All objects share the same static members. Static members are accessed using the class name, not an object.

Example:

class MathHelper
{
    public static double Pi = 3.14159;
    public static double Square(double x) => x * x;
}

// Usage:
Console.WriteLine(MathHelper.Pi);
Console.WriteLine(MathHelper.Square(5));

## 2. What is inheritance in C#?

Answer:
Inheritance allows one class to reuse the fields and methods of another class.
It promotes code reusability and helps maintain cleaner architecture.

Syntax:

class Parent { }
class Child : Parent { }


Example:

class Animal { public void Eat() => Console.WriteLine("Eating..."); }
class Dog : Animal { public void Bark() => Console.WriteLine("Barking..."); }

## 3. What is encapsulation and why is it important?

Answer:
Encapsulation means hiding the internal state (data) of an object and exposing it through controlled access (getters/setters).
It ensures data security, maintainability, and validation.

Example:

class Account
{
    private double balance;

    public double Balance => balance; // read-only

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }
}

## 4. What is the difference between public, private, and protected access modifiers?

Answer:

Modifier	Access Scope
public	Accessible anywhere
private	Accessible only within the same class
protected	Accessible in the same class and derived classes

Example:

class Base
{
    private int a = 10;
    protected int b = 20;
    public int c = 30;
}
class Derived : Base
{
    public void Show() => Console.WriteLine(b); // ✅ accessible
}

## 5. Can we access static members using an object?

Answer:
Yes, technically you can, but it’s not recommended.
Static members should be accessed using the class name for clarity and consistency.

Example:

MathHelper helper = new MathHelper();
Console.WriteLine(MathHelper.Pi); // ✅ Recommended

## 6. Can we inherit static classes in C#?

Answer:
❌ No. Static classes cannot be inherited, instantiated, or extended.
They are sealed by default and can contain only static members.

## 7. Can a derived class access private fields of its parent?

Answer:
No.
Private fields are only accessible inside the same class.
Derived classes can access protected fields, not private ones.

## 8. What is the purpose of the this keyword in C#?

Answer:
The this keyword refers to the current instance of the class.
It is mainly used to:

Differentiate between class fields and method parameters with the same name.

Pass the current object as a parameter to another method or constructor.

Example:

class Book
{
    private string title;

    public Book(string title)
    {
        this.title = title; // distinguishes between parameter and field
    }
}

## 9. What are the advantages of using inheritance?

Answer:

Promotes code reusability

Increases readability and maintainability

Allows extending existing functionality without modifying original code (Open/Closed Principle)

## 10. Real-time: How would you design a BankAccount class using encapsulation?

Answer:
We can create a secure class that hides sensitive data (like balance) and provides public methods for safe transactions.

class BankAccount
{
    private double balance;

    public double Balance => balance; // Read-only

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient funds!");
    }
}

## ✅ Extra / Code Snippet Example
// Example combining inheritance + encapsulation
class BaseAccount
{
    protected double Balance { get; set; }
}

class SavingsAccount : BaseAccount
{
    public double InterestRate { get; set; }

    public void ApplyInterest()
    {
        Balance += Balance * (InterestRate / 100);
        Console.WriteLine($"New Balance: {Balance}");
    }
}