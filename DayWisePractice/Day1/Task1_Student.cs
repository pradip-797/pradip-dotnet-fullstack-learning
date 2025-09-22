[200~using System;

namespace DayWisePractice.Day1
{
    internal class Task1_Student
    {
        public static void Run()
        {
            // basic input / output example for Day1
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter roll number: ");
            if (!int.TryParse(Console.ReadLine(), out int roll))
            {
                Console.WriteLine("Invalid roll number");
                return;
            }

            Console.Write("Enter marks: ");
            if (!float.TryParse(Console.ReadLine(), out float marks))
            {
                Console.WriteLine("Invalid marks");
                return;
            }

            bool passed = marks >= 40;
            Console.WriteLine($"\nName: {name}\nRoll: {roll}\nMarks: {marks}\nPassed: {passed}");
        }
    }

