// File: DayWisePractice/Day1/Task1_Student.cs
using System;

namespace DayWisePractice.Day1
{
    /// <summary>
    /// Day 1 - Student details task
    /// This file demonstrates reading user input safely, simple validation,
    /// and printing a formatted output. Good for learning basics and CLI UX.
    /// </summary>
    internal class Task1_Student
    {
        // Public entry method called from Program.cs
        public static void Run()
        {
            Console.WriteLine("=== Day 1: Student Details (Task) ===");

            // Read name (non-empty)
            string studentName = ReadString("Enter student name: ");

            // Read roll number (integer) with validation
            int rollNo = ReadInt("Enter roll number (integer): ");

            // Read marks (float) with validation (0 - 100)
            float marks = ReadFloatInRange("Enter marks (0-100): ", 0f, 100f);

            // Determine pass/fail using business rule (>=40)
            bool isPassed = marks >= 40.0f;

            // Nicely formatted output section
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Name     : {studentName}");
            Console.WriteLine($"Roll No  : {rollNo}");
            Console.WriteLine($"Marks    : {marks:0.##}");
            Console.WriteLine($"Passed   : {(isPassed ? "Yes" : "No")}");
            Console.WriteLine("------------------------");

            // Pause so console doesn't close immediately when run outside debugger
            Console.WriteLine("\nPress any key to return to menu/exit...");
            Console.ReadKey();
        }

        // ---------------------
        // Helper input methods
        // ---------------------

        // Read a non-empty string from console
        private static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? string.Empty;
                if (!string.IsNullOrEmpty(input))
                    return input;

                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        }

        // Read an integer (with retry)
        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? raw = Console.ReadLine();
                if (int.TryParse(raw, out int value))
                    return value;

                Console.WriteLine("Invalid integer. Please enter a valid number.");
            }
        }

        // Read float in a given inclusive range (with retry)
        private static float ReadFloatInRange(string prompt, float min, float max)
        {
            while (true)
            {
                Console.Write(prompt);
                string? raw = Console.ReadLine();
                if (float.TryParse(raw, out float value))
                {
                    if (value >= min && value <= max)
                        return value;
                    Console.WriteLine($"Please enter a value between {min} and {max}.");
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a numeric value (e.g., 85.5).");
                }
            }
        }
    }
}
