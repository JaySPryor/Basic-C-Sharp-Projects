using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////excape Characters in strings
            //string name = "Jesse";
            //string quote = "The man said \"Hello\", Jesse. \nNew line \n\ttab";
            //string file1 = "\nC:\\Double\\Backslash\n";
            //string file2 = @"C:\At\Symbol";

            //bool trueOrFalse = name.Contains("s");//Checks name if it contains 's', true/false
            //trueOrFalse = name.EndsWith("s");//Ends with 's'?

            //int length = name.Length;//checks length of string

            //name = name.ToUpper();//Changes all letters to upper case

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");
            sb.Append("\nNow my name is Jaymes.");
            

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
