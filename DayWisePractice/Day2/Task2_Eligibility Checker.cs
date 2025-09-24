using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 2 – Eligibility Checker (Relational + Logical)

👉 Input age and nationality. If age >= 18 AND nationality == "Indian" → Print “Eligible to Vote”, else “Not Eligible”.*/

namespace DayWisePractice.Day2
{
    internal class Task2_Eligibility__Checker
    {
        public static void Run()
        {
            Console.WriteLine("== Task 2 : Check Eligibilty for Vote ==");

            /*Input Age
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());*/

            // Input Age with validation
            Console.Write("Enter your Age: ");
            string ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out int age))
            {
                Console.WriteLine("❌ Invalid input. Please enter a valid number for age.");
                return; // Exit early if input is invalid
            }

            //Input Nationality
            Console.Write("Enter your Nationality: ");
            string nationality = Console.ReadLine().Trim().ToLower();


            //checking Relational+ logical

            if (age >= 18 && nationality == "indian")
            {
                Console.WriteLine("Eligible for Vote");
            }
            else 
            {
                Console.WriteLine("Not Eligible for Vote");
            }

        }
    }
}
