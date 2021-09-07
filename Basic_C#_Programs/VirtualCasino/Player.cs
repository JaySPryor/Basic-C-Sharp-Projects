using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasino
{
    public class Player
    {
        //Player constructor
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();//New list Hand to hold players cards
            Balance = beginningBalance;//beginning player balance
            Name = name;//player name
        }

        //Properties of Player class
        private List<Card> _hand = new List<Card>();//private instance of hand list

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }//Card List of cards named Hand
        public int Balance { get; set; }//money balance
        public string Name { get; set; }//player name
        public bool isActivePlayer { get; set; }//true/false is an active player
        public bool Stay { get; set; }//true/false if player stays

        //bet method
        public bool Bet(int amount)
        {
            //if bet is bigger than balance...
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough credits for that bet!");
                return false;
            }
            
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //overloaded + operator, takes Game object & Player object
        public static Game operator+ (Game game, Player player)
        {
            //adds a player to the Players list in game
            game.Players.Add(player);
            return game;//returns game with updated Players list
        }

        //overloaded - operator
        public static Game operator- (Game game, Player player)
        {
            //removes player from Players list in game
            game.Players.Remove(player);
            return game;//returns updated game
        }
    }
}
