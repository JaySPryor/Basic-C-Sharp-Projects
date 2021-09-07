using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Request for user to input a number
            Console.WriteLine("Type a number to predict the future!");
            int x = Convert.ToInt32(Console.ReadLine());//saves input as x(int)
            //saves current time
            DateTime currentTime = DateTime.Now;
            //adds the user input (as hours) to the current time, saves as futureTime
            DateTime futureTime = currentTime.AddHours(x);
            //displays futurTime
            Console.WriteLine("In {0} hours, the date & time will be {1}!", x, futureTime);
            Console.ReadLine();

        }
    }
}
