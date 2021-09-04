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

            Operation divide = new Operation();

            Console.WriteLine("Type a number.");
            int userInt = Convert.ToInt32(Console.ReadLine());

            int result = divide.Divider(userInt);

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
