using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validDay = false;//boolean set for while loop
            string userDay;//declare userDay string

            while (!validDay)//while validDay is false, loop
            {
                try//code block to try to execute
                {
                    Console.WriteLine("What day of the week is it?");
                    userDay = Console.ReadLine();//user input saved as userDay
                    //string userDay parsed to data type of enum, saved as weekDay
                    DayOfWeek weekDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userDay);
                    validDay = true;//bool validDay set to true to exit while loop
                    Console.WriteLine("\nToday is " + weekDay + "!");//Displays current weekday according to user
                }
                catch (Exception e)//if user input wrong data, catch
                {
                    //display exception & custom message
                    Console.WriteLine(e.Message + "\nPlease enter an actual day of the week.\n");
                }
            }
            Console.ReadLine();
        }
    }
}
