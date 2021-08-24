using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title & First question
            Console.WriteLine("Find out if you qualify for insurance! \nWhat is your age?");
            string userAge = Console.ReadLine();
            int age = Convert.ToInt32(userAge);//Converts user input to int
            bool oldEnough = age > 15;//True if older than 15

            //Second Question
            Console.WriteLine("Have you ever had a DUI? \n(true or false)");
            string anyDui = Console.ReadLine();
            bool noDui = Convert.ToBoolean(anyDui);//Converts user input to bool

            //Third Question
            Console.WriteLine("How many Speeding Tickets have you had?");
            string speedTickets = Console.ReadLine();
            int numOfTickets = Convert.ToInt32(speedTickets);//Converts user input to int
            bool notTooManyTickets = numOfTickets < 4;//True if less than 4

            //Checks all booleans & prints true/false
            Console.WriteLine("Qualified?");
            Console.WriteLine(oldEnough == true && noDui == false && notTooManyTickets == true);


            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();

        }
    }
}
