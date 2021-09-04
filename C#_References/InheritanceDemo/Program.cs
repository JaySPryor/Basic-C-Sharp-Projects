using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of Employee class object employee
            Employee employee = new Employee();
            employee.FirstName = "Sample";//saves string Sample as FirstName
            employee.LastName = "Student";//saves string Student as LastName

            //Super-class method, prints full name to console
            employee.SayName();

            Console.ReadLine();

        }
    }
}
