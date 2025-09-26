# Day 3 – Interview Questions & Answers (Topic Name)

## 1. What is the difference between if-else and switch in C#?
Answer: ...
if-else is used for complex conditions, ranges, or logical expressions (e.g., marks >= 90).
switch is used for exact matches on a single value (e.g., matching integer, enum, or string).
switch improves readability when there are many options.

---

## 2.Can switch work with strings in C#? Give an example.
Answer: ...
Yes. Since C# 7, switch works with strings, patterns, and even constants.

Example:

string day = "Monday";
switch (day)
{
    case "Monday":
        Console.WriteLine("Start of the week");
        break;
    case "Friday":
        Console.WriteLine("Weekend is near!");
        break;
    default:
        Console.WriteLine("Midweek day");
        break;
}

---

## 3. Difference between for, while, and do-while loops?
Answer: ...
for → best when the number of iterations is known.
while → best when you don’t know iterations but run until a condition is true.
do-while → ensures the loop runs at least once, even if condition is false.

---

## 4. What happens if we forget to increment a variable in a while loop?
Answer: ...
Yes → it causes an infinite loop because the condition never changes. This can hang the application or consume CPU unnecessarily.

---

## 5. Difference between break, continue, and return?
Answer: ...
break → exits the loop/switch immediately.
continue → skips the current iteration and jumps to the next loop cycle.
return → exits the entire method, not just the loop.

---

## 6. How do you validate user input in C# console apps?
Answer: ...
Use int.TryParse() for numeric input to prevent runtime exceptions.
Optionally, wrap in try-catch for more complex input parsing

---

## 7. Difference between foreach and for loops in arrays?
Answer: ...
foreach → simpler syntax for iterating over arrays/collections, but cannot modify collection structure while iterating.
for → gives index access, allows modifying elements, and more control (like skipping).

---

## 8. Can we modify elements inside a foreach loop in C#?
Answer: ...
No, In foreach, the iteration variable is read-only, so you cannot reassign it. However,
if the collection contains reference types, you can modify the object’s properties.
Example:

foreach (var student in students)
{
    student.Name = "Updated"; // ✅ allowed (property update)
    // student = new Student(); // ❌ not allowed
}

---

## 9. How do you handle exceptions if input parsing fails?
Answer: ...
int.TryParse() → safe, preferred for console input.
try-catch → for cases where exceptions must be caught explicitly (e.g., file I/O, DB operations).

---

## 10. Output of:
int i = 0;
while (i < 3)
{
    Console.WriteLine(i);
    i++;
}
Answer: ...
0
1
2

---

## Extra / Code Snippet Example
```csharp
// Add example code here if needed
