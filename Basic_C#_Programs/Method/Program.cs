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
            int userInt = Convert.ToInt32(Console.ReadLine());//converted from string and saved as int userInt 

            //Request for second number, or to use default
            Console.WriteLine("Type a second number to multiply by the first, OR press enter to double the first number.");
            string userString = Console.ReadLine();//string saved 

            
            
            int optionalInt = Convert.ToInt32(userString);//converts user input to int, saves as optionalInt
            int result = Operation.multiTool(userInt, optionalInt);//Passes userInt & optionalInt to multiTool(), returns result
            Console.WriteLine(userInt + " times " + optionalInt + " equals " + result);
            

            Console.ReadLine();


        }
    }
}
