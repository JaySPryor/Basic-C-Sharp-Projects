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

            try
            {
                List<int> numList = new List<int>() { 3, 6, 9 };

                Console.WriteLine("Number?");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numList)
                {
                    int quotient = num / userNum;
                    Console.WriteLine(num + " divided by " + userNum + " equals " + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("\nYou have exited the try/catch block.");
            Console.ReadLine();

        }
    }
}
