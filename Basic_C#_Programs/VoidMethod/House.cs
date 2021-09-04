using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    //Static class
    public static class House
    {
        //Static string values
        public static string Name = "Jay p";
        public static string Address = "4500 s State st";
        
        //Method MyHouse that prints values Name & Address to console
        public static void MyHouse()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
        } 

    }
}
