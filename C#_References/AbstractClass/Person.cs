using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Abstract class Person
    public abstract class Person
    {
        //Properties, first & last name of person
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Abstract method
        public abstract void SayName();
    }
}
