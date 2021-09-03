using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of new sum() named add
            Operation add = new Operation();

            //Request for user to input a number
            Console.WriteLine("Type a number.");
            int input1 = Convert.ToInt32(Console.ReadLine());//Converted and saved as int input1

            //Request for user to input a second number
            Console.WriteLine("Type a second number.");
            int input2 = Convert.ToInt32(Console.ReadLine());//Converted and saved as int input2

            Console.WriteLine("My numbers (1&2): ");
            //call method passing in two numbers
            add.sum(1, 2);

            Console.WriteLine("Your numbers: ");
            //call method specifyng named parameters
            add.sum(input1, input2);
            Console.ReadLine();
        }
    }
}
