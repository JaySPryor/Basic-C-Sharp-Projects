using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //***VARIABLES***
            //Messages/Questions (in order of appearance)
            string reportTitle = "The Tech Academy \nStudent Daily Report\n";
            string questionA = "What is your name?";
            string questionB = "What course are you on?";
            string questionC = "What page number?";
            string questionD = "Do you need help with anything? \nPlease answer \"true\" or \"false.\"";
            string questionE = "Were there any positive experiences you'd like to share? \nPlease give specifics.";
            string questionF = "Is there any other feedback you'd like to provide? \nPlease be specific.";
            string questionG = "How many hours did you study today?";
            string reportGoodbye = "Thank you for you answers. An Instructor will respond to this shortly. \nHave a great day! \n(Press \"enter\" to close window)";

            ////User input
            //string userName;
            //string userCourse;
            //int userPage;
            //bool userHelp;
            //string userExp;
            //string userFeedBack;
            //float userHours;

            //***METHODS***
            //Title message & 1st question printed to console.
            Console.WriteLine(reportTitle + questionA);
            Console.ReadLine();
            //2nd question
            Console.WriteLine(questionB);
            Console.ReadLine();
            //3rd question
            Console.WriteLine(questionC);
            Console.ReadLine();
            //4th question
            Console.WriteLine(questionD);
            Console.ReadLine();
            //5th question
            Console.WriteLine(questionE);
            Console.ReadLine();
            //6th question
            Console.WriteLine(questionF);
            Console.ReadLine();
            //7th question
            Console.WriteLine(questionG);
            Console.ReadLine();
            //End of program.
            Console.WriteLine(reportGoodbye);
            Console.ReadLine();

        }
    }
}
