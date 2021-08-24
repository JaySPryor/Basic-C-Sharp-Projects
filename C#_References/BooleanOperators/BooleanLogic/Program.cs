using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //// && (and)
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //// || (or)
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //// == (is equal too)
            //Console.WriteLine(true == false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //// != (not equal)
            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            // ^ (xor (true if one of the arguments is true, but not both) )
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
