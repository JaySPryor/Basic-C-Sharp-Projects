using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //VARIABLES//
            string next = "\nPress Enter to Continue...";

            //Request user input (string)
            Console.WriteLine("Type a number, and I'll multiply it by 50!");
            string user1 = Console.ReadLine();
                //Cast to int
                int num1 = Convert.ToInt32(user1);
                //Multiply by 50
                int total1 = num1 * 50;
            //Print int
            Console.WriteLine(num1 + " times 50 = " + total1 + next);
            Console.ReadLine();

            //Request user input (string)
            Console.WriteLine("Type a number, and I'll add 25 to it!");
            string user2 = Console.ReadLine();
                //Cast to int
                int num2 = Convert.ToInt32(user2);
                //Add 25
                int total2 = num2 + 25;
            //Print int
            Console.WriteLine(num2 + " plus 25 = " + total2 + next);
            Console.ReadLine();

            //Request user input (string)
            Console.WriteLine("Type a number and I'll divide it by 12.5!");
            string user3 = Console.ReadLine();
                //Cast to int
                int num3 = Convert.ToInt32(user3);
                //Divide by 12.5
                float total3 = num3 / 12.5f;
            //Print float
            Console.WriteLine(num3 + " divided by 12.5 = " + total3 + next);
            Console.ReadLine();

            //Request user input (string)
            Console.WriteLine("Type a number and I'll check if it's greater than 50!");
            string user4 = Console.ReadLine();
                //Cast to int
                int num4 = Convert.ToInt32(user4);
                //Check if > 50
                bool total4 = num4 > 50;
            //Print bool
            Console.WriteLine("Is " + num4 + " > 50? " + total4 + next);
            Console.ReadLine();

            //Request user input (string)
            Console.WriteLine("Type a number, I'll divide by 7, and give you the the remainder!");
            string user5 = Console.ReadLine();
                //Cast to int
                int num5 = Convert.ToInt32(user5);
                //Divide find modulus (divide by 7)
                double mod5 = num5 % 7;
            //Print modulus
            Console.WriteLine(num5 + " divided by 7 has remainder of " + mod5 + next);
            Console.ReadLine();

        }
    }
}
