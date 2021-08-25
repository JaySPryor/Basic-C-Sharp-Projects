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
            //First game is a coin flip
            Console.WriteLine("I just flipped a coin! \n\nheads or tails?");
            string coin = Console.ReadLine();//users answer
            bool rightAnswer = coin == "tails";//Checks if coin is tails (true/false)

            //Executes if rightAnswer is false
            if (!rightAnswer)
            {
                while (!rightAnswer)//Loop that allows user to keep guessing if wrong answer
                {
                    switch (coin)//users initial answer
                    {
                        case "heads"://selected if "coin" is heads 
                            Console.WriteLine("Nope. Guess again.");
                            coin = Console.ReadLine();
                            break;
                        case "tails"://selected if "coin" is tails
                            Console.WriteLine("Youre good at this! \n\nLets try a new game!");
                            rightAnswer = true;//Changes rightAnswer to true, exits while loop
                            break;
                        default://selected if coin is anything besides heads or tails 
                            Console.WriteLine("uh... no. Guess again.");
                            coin = Console.ReadLine();
                            break;
                    }
                }
            }
            //Executes is rightAnswer is true
            else
            {
                Console.WriteLine("Youre good at this! \n\nLets try a new game!");
            }

            Console.ReadLine();
            //Executes if rightAnswer is true
            if (rightAnswer)
            {
                //Second game is a number guessing game
                Console.WriteLine("I'm thinking of a number between 1 and 3. \nCan you guess which one?");
                int number = Convert.ToInt32(Console.ReadLine());//user inputs number
                bool isGuessed = number == 3;//Checks if number is 3 (true/false)

                do
                {
                    switch (number)
                    {
                        case 1://Selected If user answer is 1
                            Console.WriteLine("Not quite. Try again.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2://Selected if user answer is 2
                            Console.WriteLine("So close! Try again.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3://Selected if user answer is 3, Ends game
                            Console.WriteLine("You guessed the number 3. That is correct! \n\nYOU WIN!");
                            isGuessed = true;//Sets  isGuessed to true, exits loop.
                            break;
                        default://Selected if user answer is not 1-3
                            Console.WriteLine("Not even close...");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);//Checks if isGuessed is not true

                Console.ReadLine();//Exit program
            }

            //In case rightAnswer is not true
            else
            {
                Console.ReadLine();//Exit Program
            }

        }
    }
}
