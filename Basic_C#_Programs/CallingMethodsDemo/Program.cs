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
            //Requests a number from the user to use in Equation methods
            Console.WriteLine("What number would you like to perform some operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());//user input is converted/saved as int

            //First Equation() 
            Equation timesTwo = new Equation();//name/instance of Equation()
            timesTwo.userNum = userInput;//assigned value of userInput
            timesTwo.answerNum = timesTwo.defaultNum * timesTwo.userNum;//Mulitplies userNum by defaultNum, saves answer as answerNum
            //displays userInput, equation performed using it, and answer
            Console.WriteLine(userInput + " multiplied by " + timesTwo.defaultNum + " equals " + timesTwo.answerNum);

            //Second Equation()
            Equation divideByTwo = new Equation();
            divideByTwo.userNum = userInput;
            divideByTwo.answerNum = divideByTwo.userNum / divideByTwo.defaultNum;//Divides userNum by defaultNum, saves answer as answerNum

            Console.WriteLine(userInput + " divided by " + divideByTwo.defaultNum + " equals " + divideByTwo.answerNum);

            //Third Equation()
            Equation addTwo = new Equation();
            addTwo.userNum = userInput;
            addTwo.answerNum = addTwo.userNum + addTwo.defaultNum;//Adds userNum to defaultNum, saves answer as answerNum

            Console.WriteLine(userInput + " plus " + addTwo.defaultNum + " equals " + addTwo.answerNum);

            Console.ReadLine();

        }
    }
}
