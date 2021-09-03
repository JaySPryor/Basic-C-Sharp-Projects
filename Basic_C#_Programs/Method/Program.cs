using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Type a number.");
            int userInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a second number to multiply by the first, OR type 0 to automatically double the first number.");
            string userString = Console.ReadLine();

            if (userString == "0")
            {
                int result = Operation.multiTool(userInt);
                Console.WriteLine(userInt + " times 2 equals " + result);
            }
            else
            {
                int optionalInt = Convert.ToInt32(userString);
                int result = Operation.multiTool(userInt, optionalInt);
                Console.WriteLine(userInt + " times " + optionalInt + " equals " + result);
            }

            Console.ReadLine();


        }
    }
}
