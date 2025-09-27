# Day 4 – Interview Questions & Answers (Methods)

## 1. What is a method in C#? Why do we use it?
Answer: ...
👉 A method is a block of code that performs a specific task.
We use methods for:
Code reusability (avoid repetition)
Better readability and maintainability
Easier testing and debugging

---

## 2. What is the difference between void and return type methods?
Answer: ...
void methods → perform an action but don’t return any value.
Return type methods → perform an action and return a result (e.g., int, string, bool).

---

## 3. Explain value types vs reference types in methods.
Answer: ...
Value types (int, double, bool, struct) → copied by value. Changes in method do NOT affect the original variable.
Reference types (class, array, string, object) → copied by reference (address).
Changes in method DO affect the original object.

---

## 4. What is method overloading?
Answer: ...
👉 Method overloading means creating multiple methods with the same name but different parameter lists (number or type of parameters).
⚠️ We cannot overload by changing only the return type (compiler won’t differentiate).

---

## 5. Can we overload by changing return type only?
Answer: ...
No. Return type alone does not make methods unique. Parameters must differ.

---

## 6. What are access modifiers in C#?
Answer: ...
👉 Access modifiers define the visibility and scope of a class/member:
public → accessible everywhere
private → accessible only inside the class
protected → accessible in class + derived classes
internal → accessible only within the same assembly/project
protected internal → combination of protected + internal

---

## 7. Can we call a private method outside the class? Why/why not?
Answer: ...
👉 No. Private methods are accessible only within the same class.
This is for encapsulation — to hide internal implementation details.

---

## Extra / Code Snippet Example
Real-time example: How would you design a method to calculate employee salary after tax deduction?
```csharp
// Add example code here if needed
public static double CalculateNetSalary(double grossSalary, double taxPercentage)
{
    double taxAmount = grossSalary * (taxPercentage / 100);
    return grossSalary - taxAmount;
}

🔹 If gross salary = 50,000 and tax = 10%, method returns 45,000.
💡 This is useful in payroll software to separate salary calculation logic into reusable methods.