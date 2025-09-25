using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 2 – Role Based Login (Switch)
Input: Role (Admin, User, Guest).
Output: Display permissions.*/

namespace DayWisePractice.Day3
{
    internal class Task2_RoleBasedLogin
    {
        public static void Run()
        {
            Console.WriteLine("Day3 Task2: Role Based Login");

            //Input: Role (Admin, User, Guest).
            Console.Write("Enter your Role (Admin, User, Guest): ");
            string role = Console.ReadLine().ToLower().Trim();

            switch (role)
            {
                case "admin":
                    Console.WriteLine("You have full Access");
                    break;
                case "user":
                    Console.WriteLine("You have Limited Access");
                    break;
                case "guest":
                    Console.WriteLine("You have view only Access");
                    break;
                default:
                    Console.WriteLine("Invalid Role");
                    break;
            }
        }
    }
}
