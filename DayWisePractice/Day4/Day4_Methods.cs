using System;

namespace DayWisePractice.Day4
{
    /// <summary>
    /// Day 4 Practice – Demonstrates methods in C# including:
    /// 1. Basic Calculator (Add, Subtract, Multiply, Divide)
    /// 2. Greeting a User
    /// 3. Finding Maximum of Three Numbers
    /// 4. Method Overloading
    /// 
    /// This class is static since all methods are utility-based
    /// and do not require object instantiation.
    /// </summary>
    public static class Day4_Methods
    {
        // -------------------------------
        // Task 1 – Calculator Methods
        // -------------------------------

        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second integer from the first.
        /// </summary>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two integers and returns the result.
        /// </summary>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides one integer by another.
        /// Returns NaN if division by zero is attempted.
        /// </summary>
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero (0).");
                return double.NaN; // Represents "Not a Number"
            }
            return (double)a / b;
        }

        // -------------------------------
        // Task 2 – Greeting Method
        // -------------------------------

        /// <summary>
        /// Prints a personalized greeting message for the given user.
        /// </summary>
        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to C# learning.");
        }

        // -------------------------------
        // Task 3 – Find Maximum
        // -------------------------------

        /// <summary>
        /// Finds the maximum number among three integers.
        /// Uses Math.Max internally for comparison.
        /// </summary>
        public static int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // -------------------------------
        // Task 4 – Method Overloading
        // -------------------------------

        /// <summary>
        /// Prints user details – only name.
        /// Demonstrates method overloading.
        /// </summary>
        public static void PrintDetails(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        /// <summary>
        /// Prints user details – name and age.
        /// </summary>
        public static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        /// <summary>
        /// Prints user details – name, age, and city.
        /// </summary>
        public static void PrintDetails(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }

        // -------------------------------
        // Run – Test Harness
        // -------------------------------

        /// <summary>
        /// Entry method to execute all Day 4 tasks
        /// in sequence and print results to the console.
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("========== Task 1 : Calculator ==========");

            Console.WriteLine($"Add (5 + 3): {Add(5, 3)}");
            Console.WriteLine($"Subtract (5 - 3): {Subtract(5, 3)}");
            Console.WriteLine($"Multiply (5 * 3): {Multiply(5, 3)}");
            Console.WriteLine($"Divide (5 / 0): {Divide(5, 0)}");

            Console.WriteLine("\n========== Task 2 : Greet User ==========");
            GreetUser("Pradip");

            Console.WriteLine("\n========== Task 3 : Find Max Number ==========");
            Console.WriteLine($"Maximum Number is : {FindMax(20, 5, 24)}");

            Console.WriteLine("\n========== Task 4 : Method Overloading ==========");
            PrintDetails("Pradip");
            PrintDetails("Pradip", 25);
            PrintDetails("Pradip", 25, "Mumbai");
        }
    }
}
