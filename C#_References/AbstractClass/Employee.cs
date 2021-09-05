using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Inherits from Person class
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; } 

        //implementation of abstract method from Person class (use override keyword)
        public override string SayName()
        {
            //Cocatenates first & last name and saves as fullName, Prints fullName to console, returns string fullName
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full name: " + fullName);
            return fullName;
        }

        //interface method
        public void Quit(string employee)
        {
            //display message to console
            Console.WriteLine(employee + " has terminated employment.");
        }

        //overloaded == operator
        public static bool operator== (Employee employee1, Employee employee2)//takes two Employee objects
        {
            bool sameId = employee1.ID == employee2.ID;//Compares ID property of each, saves true/false as sameId
            return sameId;//returns bool sameId
        }

        //overloaded != required for Employee== to exist
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool notSameId = employee1.ID != employee2.ID;
            return notSameId;
        }

    }
}
