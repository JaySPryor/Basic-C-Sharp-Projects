using System;
using System.IO;
using VirtualCasino;
using VirtualCasino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set Casino name to a constant 
            const string casinoName = "The virtual casino";

            //First greeting
            Console.WriteLine("Welcom to {0}! What's your name?", casinoName);
            string playerName = Console.ReadLine();//saves player name

            //block used to catch any exceptions(format exceptions)
            bool validAnswer = false;
            int bank = 0;
            //while validAnswer is false...
            while (!validAnswer)
            {
                Console.WriteLine("How many credits are you playing with today?");//ask for player to input credit amount
                validAnswer = int.TryParse(Console.ReadLine(), out bank);//use TryParse to return bool, and out credit (bank) amount
                if (!validAnswer) Console.WriteLine("Please enter digits only and no decimals.");//if still !validAnswer, clarify and repeat loop
            }

            //Asks if user wants to play a game
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();//saves answer to lowercase
            
            //creates player using input data, and creates game
            if (answer == "yes" || answer == "y")
            {
                

                //player object
                Player player = new Player(playerName, bank);
                //Create GUID for new player
                player.Id = Guid.NewGuid();

                //Log GUID to text file
                using (StreamWriter file = new StreamWriter(@"D:\School\GitHub\Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOne\Logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }

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
