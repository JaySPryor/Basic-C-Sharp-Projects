using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            //STRING VARIABLE(S)//

            string next = "\nPress Enter to Continue";//Continue to next step
            string q1 = "\nHourly Rate?";//First Question
            string q2 = "Hours per week?";//Second Question
            string totalSalary = "Annual salary of Person ";//Header for total salary

            //Program start
            Console.WriteLine("Anonymous Income Comparison Program" + next);
            Console.ReadLine();

            //Person 1 input information
            Console.WriteLine("Person 1: " + q1);//First Question
                string rate1 = Console.ReadLine();
                //Casts user input to float
                float wage1 = Convert.ToSingle(rate1);
            Console.WriteLine(q2);//Second Question
                string hours1 = Console.ReadLine();
                //Casts user input to int
                int time1 = Convert.ToInt32(hours1);
                    //Equations for Person 1 Salary
                    float weekly1 = wage1 * time1;//Pay rate * hours = weekly
                    float monthly1 = weekly1 * 4;//weekly * 4(weeks) = monthly
                    float salary1 = monthly1 * 12;//monthly * 12(months) = salary

            //Person 2 input information
            Console.WriteLine("Person 2: " + q1);
                string rate2 = Console.ReadLine();
                float wage2 = Convert.ToSingle(rate2);
            Console.WriteLine(q2);
                string hours2 = Console.ReadLine();
                int time2 = Convert.ToInt32(hours2);
                    //Equations for Person 2 Salary
                    float weekly2 = wage2 * time2;
                    float monthly2 = weekly2 * 4;
                    float salary2 = monthly2 * 12;

            //Equation comparing salaries
            bool rate3 = salary1 > salary2;

            //Prints Person 1 salary to console
            Console.WriteLine(totalSalary + "1: " + salary1 + next);
            Console.ReadLine();

            //Prints Person 2 salary
            Console.WriteLine(totalSalary + "2: " + salary2 + next);
            Console.ReadLine();

            //Checks if Person one makes more & prints true/false to console.
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + rate3 + next);
            Console.ReadLine();//Press enter to close console







        }
    }
}
