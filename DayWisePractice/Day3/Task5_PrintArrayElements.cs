using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 5 – Print Array Elements (Foreach Loop)
Input: Array of 5 strings (names).
Output: Print each name. */

namespace DayWisePractice.Day3
{
    internal class Task5_PrintArrayElements
    {
        public static void Run()
        {
            Console.WriteLine("Task5 : Print Array elements : ");

            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNames in Array are :  ");

            foreach (string name in names)
            {
            Console.WriteLine(name);
            }

        }
    }
}
