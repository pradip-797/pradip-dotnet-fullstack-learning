using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 3 – Print Multiplication Table (For Loop)
Input: Any number.
Output: Print multiplication table of that number. */

namespace DayWisePractice.Day3
{
    internal class Task3_MultiplicationTable
    {
        public static void Run()
        {
            //Input Any Number
            Console.Write("Enter any number for multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");

            }

        }
    }
}
