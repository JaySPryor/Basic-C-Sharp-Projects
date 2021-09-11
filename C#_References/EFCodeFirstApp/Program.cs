using System;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Jay" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
