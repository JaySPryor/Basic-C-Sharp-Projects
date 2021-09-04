using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsDemo
{
    //Equation class
    public class Operation
    {
        public int userNum { get; set; }//This is going to be assigned from user input
        public int defaultNum { get; set; }//This will be set to the int 2

        //timesTwo() takes user in and multiplies by 2
        public static int timesTwo(int userNum, int defaultNum)//sets userNum & default as parameters
        {
            return userNum * defaultNum;//returns result of operation
        }
        
        //divideByTwo() takes user input and divides by 2
        public static int divideByTwo(int userNum, int defaultNum)
        {
            return userNum / defaultNum;
        }

        //addTwo() takes user input and adds 2
        public static int addTwo(int userNum, int defaultNum)
        {
            return userNum + defaultNum;
        }

    }
}
