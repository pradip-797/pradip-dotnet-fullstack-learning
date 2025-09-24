using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 3 – Discount Calculator (Ternary + Assignment)

👉 Input bill amount. If amount >= 1000 → Apply 10% discount, else no discount. Print final amount.*/

namespace DayWisePractice.Day2
{
    internal class Task3_Discount
    {
        public static void Run()
        {
            Console.WriteLine("Task 3 – Discount Calculator (Ternary + Assignment)");

            //Input Bill Amount
            Console.Write("Enter Bill Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double Discount = (amount >= 1000) ? amount * 0.10 : 0;

            double FinalAmount = amount - Discount;

            Console.WriteLine($"Final Amount : {FinalAmount} ");
        }
    }
}
