using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasino
{
    //Class used to catch any fraud attempts, inherits from Exception class
    public class FraudException : Exception
    {
        //Constructor
        public FraudException()
            : base() { }
        //overloaded constructor
        public FraudException(string message)
            : base(message) { }

    }
}
