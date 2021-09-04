using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of Eployee class employee
            Employee employee = new Employee();
            employee.firstName = "Sample";//saved to property firstName
            employee.lastName = "Student";//saved to property lastName

            //Calls SayName method from Employee class
            employee.SayName();
            Console.ReadLine();

        }
    }
}
