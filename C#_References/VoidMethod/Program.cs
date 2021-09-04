using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of Operation class
            Operation divide = new Operation();


            //Request for user to input a number
            Console.WriteLine("Type a number.");
            int userInt = Convert.ToInt32(Console.ReadLine());
            
            //void method called on user input (displays userInt divided by 2)
            divide.Divide(userInt);
            Console.ReadLine();

        }
    }
}
