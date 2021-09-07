using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainDemo
{
    class Person
    {
        //Chained constructor
        public Person(string name) : this(name, 100)
        {
        }

        //Original constructor
        public Person(string name, int wallet)
        {
            Name = name;
            Wallet = wallet;
        }

        //Person Properties
        public string Name { get; set; }
        public int Wallet { get; set; }
    }
}
