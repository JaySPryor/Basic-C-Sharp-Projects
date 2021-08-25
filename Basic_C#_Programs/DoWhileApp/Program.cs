using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I just flipped a coin! \n\nheads or tails?");
            string coin = Console.ReadLine();
            bool rightAnswer = coin == "tails";

            while (!rightAnswer)
            {
                switch (coin)
                {
                    case "heads":
                        Console.WriteLine("Nope. Guess again.");
                        coin = Console.ReadLine();
                        break;
                    case "tails":
                        Console.WriteLine("Youre good at this! \n\nLets try a new game!");
                        rightAnswer = true;
                        break;
                    default:
                        Console.WriteLine("uh... no. Guess again.");
                        coin = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();

            if (rightAnswer)
            {

                Console.WriteLine("I'm thinking of a number between 1 and 3. \nCan you guess which one?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 3;

                do
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Not quite. Try again.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("So close! Try again.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("You guessed the number 3. That is correct! \n\nYOU WIN!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("Not even close...");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }

        }
    }
}
