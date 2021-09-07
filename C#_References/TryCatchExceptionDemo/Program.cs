using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");

            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                DateTime currentDate = DateTime.Now;
                DateTime userBirthDate = currentDate.AddYears(-userAge);
                Console.WriteLine("You were born on {0}", userBirthDate);
                Console.ReadLine();
            }
            
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a whole number, with no decimals.");
                Console.ReadLine();
                throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number, not letters.");
                Console.ReadLine();
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                Console.ReadLine();
                throw;
            }
        }
    }
}
