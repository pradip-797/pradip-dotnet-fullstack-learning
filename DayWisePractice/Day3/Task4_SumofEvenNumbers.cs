using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Task 4 – Sum of Even Numbers (While Loop)
Input: Number limit.
Output: Sum of even numbers till limit */

namespace DayWisePractice.Day3
{
    internal class Task4_SumofEvenNumbers
    {
        public static void Run()
        {
            //Input Number Limit
            Console.Write("Enter the Number limit for sum of Even Numbers: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int j = 2;

            while ( j <= limit)
            {
                sum += j;
                j += 2;
            }
            Console.WriteLine($"Sum of all Even number till {limit} is : {sum}");
        }
    }
}
