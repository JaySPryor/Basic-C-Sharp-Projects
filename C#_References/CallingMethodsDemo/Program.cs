using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requests a number from the user to use in Operation methods
            Console.WriteLine("What number would you like to perform some operations on?");
            int userNum = Convert.ToInt32(Console.ReadLine());//user input is converted/saved as int
            int defaultNum = 2;

            //First Operation() 
            int answerNum = Operation.timesTwo(userNum, defaultNum);//calls method and saves return value to answerNum
            Console.WriteLine(userNum + " multiplied by " + defaultNum + " equals " + answerNum);//Displays operation performed and result

            //Second Operation()
            answerNum = Operation.divideByTwo(userNum, defaultNum);
            Console.WriteLine(userNum + " divided by " + defaultNum + " equals " + answerNum);

            //Third Operation()
            answerNum = Operation.addTwo(userNum, defaultNum);
            Console.WriteLine(userNum + " plus " + defaultNum + " equals " + answerNum);

            Console.ReadLine();

        }
    }
}
