using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Operation//Operation class
    {
        //Attributes of Operation class
        public int userInt { get; set; }
        public int defaultNum { get; set; }
        
        //Method that takes an int and multiplies by defaultNum
        public static int multiTool(int userInt, int defaultNum = 5)
        {
            return userInt * defaultNum;//Returns int result
        }

        //Method that takes a decimal value, converts defaultNum to decimal value and adds the two values together
        public static int multiTool(decimal userDec, int defaultNum = 20)
        {
            decimal decNum = Convert.ToDecimal(defaultNum);//Converts int defaultNum to decimal decNum
            decimal decTotal = userDec + decNum;
            int intTotal = Convert.ToInt32(decTotal);
            return intTotal;//Returns decimal(int) result
        }

        //Method that takes a string value, converts it to int stringNum and subtracts 10 from it
        public static int multiTool(string userString, int defaultNum = 10)
        {
            int stringNum = Convert.ToInt32(userString);//Converts string userString to int stringNum
            return stringNum - defaultNum;//Returns int result
        }

    }
}
