using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Operation
    {
        int a { get; set; }
        int quotient { get; set; }

        public void Divide(int a)
        {
            quotient = a / 2;
        }

    }
}
