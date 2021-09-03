using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Operation
    {
        //Attributes
        int userInt1 { get; set; }
        int optionalInt { get; set; }

        //Method that takes two integers and multiplies them, OR one integer and multiplies by 2 
        public static int multiTool(int userInt, int optionalInt = 2)
        {
            return userInt * optionalInt;//returns int result
        }
    }
}
