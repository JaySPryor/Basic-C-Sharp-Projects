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
            /*
             *-------------!ATTENTION!---------------
             *If user types a non integer or enters a blank 
             *answer, a format exception is thrown. 
             */

            //Request for first number
            Console.WriteLine("Type a number.");
            int userInt1 = Convert.ToInt32(Console.ReadLine());//converted from string and saved as int userInt1

            //Request for second number, or to use default
            Console.WriteLine("Type a second number to multiply by the first, OR press enter to double the first number.");
            //empty vars
            int userInt2;
            int result;
            if (int.TryParse(Console.ReadLine(), out userInt2))
            {
                //if int, Takes user input, out & saves as userInt2, saves multiTool() answer as result
                result = Operation.multiTool(userInt1, userInt2);
                Console.WriteLine(userInt1 + " multiplied by " + userInt2 + " is: ");
            }
            else
            {
                //Passes userInt to multiTool() & uses defualt value, saves answer as result
                result = Operation.multiTool(userInt1);
                Console.WriteLine(userInt1 + " doubled is: ");
            }

            Console.WriteLine(result);//Result of multiTool()
            Console.ReadLine();


        }
    }
}
