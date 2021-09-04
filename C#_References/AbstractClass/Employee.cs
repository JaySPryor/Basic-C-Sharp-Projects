using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Inherits from Person class
    public class Employee : Person
    {
        //implementation of abstract method from Person class (use override keyword)
        public override void SayName()
        {
            //Prints first & last name to console
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}
