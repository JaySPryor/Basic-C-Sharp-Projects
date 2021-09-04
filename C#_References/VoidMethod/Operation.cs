using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    //Operation class
    public class Operation
    {
        //attributes of Operation class
        public int a { get; set; }
        public int b { get; set; }
        public int quotient { get; set; }

        //Method that divides passed int by 2
        public void Divide(int a)
        {
            quotient = a / 2;
            Console.WriteLine(quotient);//Prints result
        }

        //Method with output parameters
        public int HalfSum(int a, int b, out string d, out int c)//Takes in two int values, outputs one string & one int value
        {
            
            c = a + b;//sum of two int values, saved as c
            int e = c / 2;//quotient of d / 2, saved as int e
            d = a + " plus " + b + " divided by 2 equals " + e;//string value, saved as d
            return e;//returns int value
        }

        //Overloaded Method
        public string HalfSum(int a, int b)//Takes two int values, returns one string value
        {
            int c = a + b;//sum of two int values, saved as int c
            int e = c / 2;//quotient of d / 2, saved as int e
            string d = a + " plus " + b + " divided by 2 equals " + e;//string value, saved as d
            return d;//returns string value
        }


    }
}
