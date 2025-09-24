using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 4 – BMI Calculator (Mix of all)

👉 Input weight (kg) and height (m).
Formula: BMI = weight / (height * height)

If BMI < 18.5 → Underweight

18.5–24.9 → Normal

25–29.9 → Overweight

≥30 → Obese */

namespace DayWisePractice.Day2
{
    internal class Task4_BMI
    {
        public static void Run()
        {
            Console.WriteLine("Task 4 – Calculate BMI");

            //Input Weight
            Console.Write("Enter your Weight(in Kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //Input Height
            Console.Write("Enter your Height(in m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Validate height to avoid division by zero
            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return;
            }

            //Calculate BMI 
            double BMI = weight / (height * height);

            // Display BMI value formatted to 2 decimal places
            Console.WriteLine($"Your BMI is: {BMI:F2}");

            if (BMI < 18.5)
                Console.WriteLine("Category: Underweight");
            else if (BMI >= 18.5 && BMI <= 24.9)
                Console.WriteLine("Category: Normal");
            else if (BMI >= 25 && BMI <= 29.9)
                Console.WriteLine("Category: Overweight");
            else
                Console.WriteLine("Category: Obese");
        }
    }
}
