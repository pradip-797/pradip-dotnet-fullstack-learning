## 📄 `InterviewPrep/Day2_Interview.md`

```markdown
# Day 2 – Interview Questions & Answers (Operators in C#)

## 1. What is the difference between `=` and `==` in C#?
- `=` → Assignment operator (used to assign values).
- `==` → Equality operator (used to compare values).

Example:
```csharp
int a = 5;   // assignment
bool isEqual = (a == 5); // comparison → true

2. What are arithmetic, relational, and logical operators in C#? Give examples.

Arithmetic → +, -, *, /, %
int sum = 5 + 3; // 8
Relational → >, <, >=, <=, ==, !=
bool check = 5 > 3; // true
Logical → && (AND), || (OR), ! (NOT)
bool result = (5 > 3 && 2 < 4); // true

3. What happens if we divide an integer by 0 in C#?

Throws DivideByZeroException at runtime.
int a = 10 / 0; // ❌ Runtime error

4. What is the difference between ++i and i++?

++i → Pre-increment (increment first, then use).
i++ → Post-increment (use first, then increment).

Example:

int i = 5;
Console.WriteLine(++i); // 6
Console.WriteLine(i++); // 6 (then i becomes 7)

5. How does operator precedence affect an expression?

Operator precedence decides the order of execution.
Multiplication/division has higher precedence than addition/subtraction.

Example:

int result = 2 + 3 * 4; // result = 14, not 20

6. Can we overload operators in C#? If yes, give an example.

✅ Yes, C# allows operator overloading for user-defined types.

Example:

public class Box
{
    public int Length { get; set; }

    public static Box operator +(Box b1, Box b2)
    {
        return new Box { Length = b1.Length + b2.Length };
    }
}

7. What is the difference between && and & operators?

&& → Logical AND (short-circuiting, stops evaluation if first condition is false).
& → Bitwise AND (compares bits). If used with booleans, it checks both conditions regardless.

8. Example Question: What will be the output?
int a = 5, b = 10;
Console.WriteLine(a > 2 && b < 20);
Output: True (both conditions are true).