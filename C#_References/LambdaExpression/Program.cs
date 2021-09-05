using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 different employees
            Employee employee1 = new Employee();
            employee1.FirstName = "Jay";
            employee1.LastName = "P";
            employee1.ID = 0;

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "A";
            employee2.ID = 1;

            Employee employee3 = new Employee();
            employee3.FirstName = "Abe";
            employee3.LastName = "R";
            employee3.ID = 2;
            Employee employee4 = new Employee();
            employee4.FirstName = "Tim";
            employee4.LastName = "U";
            employee4.ID = 3;

            Employee employee5 = new Employee();
            employee5.FirstName = "Bob";
            employee5.LastName = "C";
            employee5.ID = 4;

            Employee employee6 = new Employee();
            employee6.FirstName = "Tom";
            employee6.LastName = "I";
            employee6.ID = 5;

            Employee employee7 = new Employee();
            employee7.FirstName = "Mat";
            employee7.LastName = "E";
            employee7.ID = 6;

            Employee employee8 = new Employee();
            employee8.FirstName = "Joe";
            employee8.LastName = "B";
            employee8.ID = 7;

            Employee employee9 = new Employee();
            employee9.FirstName = "Kim";
            employee9.LastName = "H";
            employee9.ID = 8;

            Employee employee10 = new Employee();
            employee10.FirstName = "Cid";
            employee10.LastName = "G";
            employee10.ID = 9;

            //Add each employee to employees list
            List<Employee> employees = new List<Employee>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };

            //create new list using lambda expression
            List<Employee> Joes = employees.Where(x => x.FirstName == "Joe").ToList();

            ////create new list using foreach loop
            //foreach(Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        Joes.Add(employee);
            //    }
            //}

            //display new list contents
            foreach(Employee joe in Joes)
            {
                Console.WriteLine(joe.FirstName);
            }

            Console.ReadLine();

        }
    }
}
