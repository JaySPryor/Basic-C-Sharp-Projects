using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //start of try/catch block
            try
            {
                //List of integers
                List<int> numList = new List<int>() { 3, 6, 9 };
                //request for user to input a number
                Console.WriteLine("Number?");
                int userNum = Convert.ToInt32(Console.ReadLine());//Convert input to int
                //loop that checks each element(num) in numList
                foreach (int num in numList)
                {
                    int quotient = num / userNum;//variable to hold quotient of list element divided by user input
                    Console.WriteLine(num + " divided by " + userNum + " equals " + quotient);
                }
            }
            catch (FormatException ex)//first catch block, selected if user inputs anything besides whole number
            {
                Console.WriteLine(ex);//displays Format Exception error message
            }
            catch (DivideByZeroException ex)//secomd catch block, selected if user inputs 0
            {
                Console.WriteLine(ex);//displays Divide By Zero Exception error message
            }

            //message displayed after exiting the try/catch block
            Console.WriteLine("\nYou have exited the try/catch block.");
            Console.ReadLine();

        }
    }
}
