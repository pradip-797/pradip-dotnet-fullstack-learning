using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

/* Task 1 – Grade System (If-Else)
Input: Student marks.
Output: Grade (A / B / C / Fail).*/

/*namespace DayWisePractice.Day3
{
    internal class Task1_GradeSystem
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Task1 : Grade System");

            //Input : Student Marks
            Console.Write("Enter Student Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
                return;
            }


            if (marks >= 85)
                Console.WriteLine("Grade A");
            else if (marks >= 60)
                Console.WriteLine("Grade B");
            else if (marks >= 35)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Fail");

        }
    }
}*/

namespace DayWisePractice.Day3
{
    internal class Task1_GradeSystem
    {
        public static void Run()
        {
            Console.WriteLine("Enter Marks: ");

            // Instead of crashing, this will check input first
            if (int.TryParse(Console.ReadLine(), out int marks))
            {
                if (marks >= 90)
                {
                    Console.WriteLine("Grade A");
                }
                else if (marks >= 75)
                {
                    Console.WriteLine("Grade B");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("Grade C");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number.");
            }
        }
    }
}

