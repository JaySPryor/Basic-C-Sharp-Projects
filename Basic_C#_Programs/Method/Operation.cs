using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Operation
    {
        int userInt1 { get; set; }
        int optionalInt { get; set; }

        public static int multiTool(int userInt, int optionalInt = 2)
        {
            return userInt * optionalInt;
        }
    }
}
