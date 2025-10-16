## Day 7 – Interview Questions & Answers (Inheritance, Polymorphism, Abstract, Interface)

## 1. What is Inheritance in C#?

Answer:
Inheritance allows a class to acquire properties and methods of another class, promoting reusability and maintainability.

## 2. What are the types of inheritance in C#?

Answer:
Single, Multilevel, Hierarchical, and Hybrid (multiple is not directly supported in C#, but can be achieved via interfaces).

## 3. What is Polymorphism?

Answer:
Polymorphism allows methods to have different behaviors depending on the object. It can be compile-time (overloading) or run-time (overriding).

## 4. What is the difference between abstract class and interface?

Answer:
An abstract class can have both abstract and concrete methods, while an interface only defines method signatures.

5. Can an abstract class have a constructor?

Answer:
Yes, it can. The constructor runs when the derived class is instantiated.

## 6. Can a class inherit multiple classes?

Answer:
No, C# supports only single inheritance. But a class can implement multiple interfaces.

## 7. What is method overriding?

Answer:
When a derived class provides a specific implementation of a base class method marked as virtual.

## 8. How can you achieve multiple inheritance in C#?

Answer:
By implementing multiple interfaces.

9. Real-life Example: How would you use interfaces in an app?

Answer:
In an e-commerce system, you can define IPayment for classes like CreditCardPayment, PayPalPayment, UPIPayment.
All must implement ProcessPayment() differently.