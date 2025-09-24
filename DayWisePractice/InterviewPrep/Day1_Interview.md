# Day 1 – Interview Questions & Answers (C# Basics)

## 1. What is C#?
C# is a modern, object-oriented, type-safe programming language developed by Microsoft as part of the .NET framework.  
It is widely used for building web apps, desktop apps, APIs, cloud solutions, and games (Unity).

---

## 2. What are the features of C#?
- Object-Oriented (supports OOP: classes, objects, inheritance, polymorphism).
- Type-Safe (reduces runtime errors).
- Rich Standard Library.
- Supports modern programming concepts (async/await, LINQ, delegates, etc.).
- Cross-platform via **.NET Core / .NET 5+**.

---

## 3. What is the difference between `Console.Write()` and `Console.WriteLine()`?
- `Console.Write()` → Prints text **without** moving to the next line.
- `Console.WriteLine()` → Prints text **and moves** to the next line.

Example:
```csharp
Console.Write("Hello ");
Console.Write("World");
// Output: Hello World

Console.WriteLine("Hello");
Console.WriteLine("World");
// Output:
// Hello
// World


4. What are value types and reference types in C#?

Value Types → Store data directly in memory (stack). Examples: int, float, char, struct.
Reference Types → Store a reference (address) pointing to data in memory (heap). Examples: class, object, string, array.

5. What is the difference between string and String in C#?

string → alias in C# for System.String.
Both are the same, but convention is:
string → used for variable declaration.
String → used for calling static methods (String.IsNullOrEmpty()).