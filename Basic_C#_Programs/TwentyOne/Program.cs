using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //First greeting
            Console.WriteLine("Welcom to the virtual casino. What's your name?");
            string playerName = Console.ReadLine();//saves player name

            //Request for player balance
            Console.WriteLine("How much credit are you playing with today?");
            int bank = Convert.ToInt32(Console.ReadLine());//saves player balance

            //Asks if user wants to play a game
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();//saves answer to lowercase
            
            //creates player using input data, and creates game
            if (answer == "yes" || answer == "y")
            {
                

                //player object
                Player player = new Player(playerName, bank);

                //new TwentyOneGame, uses polymorphism
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlayer = true;

                //while player is active & has a positive balance
                while(player.isActivePlayer && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;//removes player if they exit while loop
                Console.WriteLine("Thank you for playing!");
                
            }
            Console.WriteLine("Bye for now.");//goodbye message
            Console.ReadLine();

        }

        
        

    }
}
