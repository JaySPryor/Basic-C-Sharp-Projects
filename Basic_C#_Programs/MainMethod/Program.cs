using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays message requesting an integer
            Console.WriteLine("Type an integer to multiply by 5.");
            string userString = Console.ReadLine();//saves input as string userString
            int userInt = Convert.ToInt32(userString);//Converts userString to int userInt
            int intResult = Operation.multiTool(userInt);//instance of multiTool() with int userInt passed to it, returns int value
            Console.WriteLine(userString + " times 5 equals " + intResult);//displays result of multiTool()

            //Message requesting a decimal
            Console.WriteLine("\nType a decimal number to add 20 to, and round up.");
            userString = Console.ReadLine();
            decimal userDec = Convert.ToDecimal(userString);//Converts userString to decimal userDec
            int decResult = Operation.multiTool(userDec);//instance of second method with same name, takes decimal userDec, returns int value
            Console.WriteLine(userDec + " plus 20 equals " + decResult);

            //Message requesting a number (saved as string value)
            Console.WriteLine("\nType a number to subtract 10 from.");
            userString = Console.ReadLine();
            int stringResult = Operation.multiTool(userString);//instance of third method with same name, takes string userString, returns int value
            Console.WriteLine(userString + " minus 10 equals " + stringResult);

            Console.ReadLine();
        }
    }
}
