using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            //Save user input & create new Person as yourName (uses chained constructor in Person class)
            Person yourName = new Person(Console.ReadLine());

            //Displays user name and preset wallet ammount
            Console.WriteLine("Hello {0}! You have {1} credits in your wallet.", yourName.Name, yourName.Wallet);

            const string myName = "Jay P";//saves my name as a const string
            var myWallet = 200;//use of var do declare int variable

            Console.WriteLine("My name is {0}, and I have {1} credits in my wallet!", myName, myWallet);
            Console.ReadLine();



            

        }
    }
}
