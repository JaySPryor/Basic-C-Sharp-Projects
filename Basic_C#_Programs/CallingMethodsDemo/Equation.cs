using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsDemo
{
    //Equation class
    public class Equation
    {
        public Equation()
        {   
            //The default value for all Equation() methods
            defaultNum = 2;
        }
        //3 properties
        public int userNum { get; set; }//This is going to be assigned from user input
        public int defaultNum { get; set; }//This is pre-set above
        public int answerNum { get; set; }//This will be the answer of each equation depending on the user input

    }
}
