using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 1 – Calculator (Arithmetic + Switch)

👉 Input two numbers and operator (+, -, *, /) → Output result.*/

namespace DayWisePractice.Day2
{
    internal class Task1_Calculator
    {
        public static void Run()
        {
            Console.WriteLine("Task 1 : Simple Calaculator");

            //Input First Number
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Input Second Number
            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Input Operator
            Console.Write("Enter Operator (+, -, *, /) : ");
            string op = Console.ReadLine();

            /*//Show all input details
            Console.WriteLine("All Enter details Summary: ");
            Console.WriteLine($"First Number : {num1}");
            Console.WriteLine($"Second Number : {num2}");
            Console.WriteLine($"Operator : {op}");*/

            double result = 0;

            // Switch case for operator
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result= num1 /num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                        break;
                default:
                    Console.WriteLine("Invalid operator, Please Enter valid operator(+, -, *, /)");
                    return;
            }
            Console.WriteLine($"Result = {result}");

        }

    }
}