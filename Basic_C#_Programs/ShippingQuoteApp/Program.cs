using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Title & First question.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n\nHow much does your package way? (lbs)");
            int packageWeight = Convert.ToInt32(Console.ReadLine());//Converts user input to int

            //If packageWeight is >50, to heavy to ship, app closes.
            if (packageWeight < 50)
            {
                //Requests for package dimentions
                Console.WriteLine("What is the width of your package?");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());//Width

                Console.WriteLine("What is the Package Height?");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());//Height

                Console.WriteLine("What is the Package Length?");
                int pkgLength = Convert.ToInt32(Console.ReadLine());//Length

                //Variable used to determine if package is too big
                int pkgSize = pkgWidth + pkgHeight + pkgLength;
                
                //If total width/height/length is > 50, package is too big
                if (pkgSize > 50)
                {   //Display message if package is to big
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();//Pressing enter closes console
                }
                //If package is < 50, the program continues on to generate a quoted price.
                else
                {   //(width*height*length)
                    int dimentionsProduct = pkgWidth * pkgHeight * pkgLength;
                    //(*weight)
                    int dimeTimesWeight = dimentionsProduct * packageWeight;
                    //(/100 = final quote)
                    decimal quote = dimeTimesWeight / 100.00m;

                    //Final message & quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.ReadLine();//Pressing enter closes console
                }
            }
            //Display Message if package is too heavy
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();//Pressing enter closes console
            }
            

        }
    }
}
