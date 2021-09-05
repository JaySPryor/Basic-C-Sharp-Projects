using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        //Properties of Player class
        public List<Card> Hand { get; set; }//Card List of cards named Hand
        public int Balance { get; set; }//money balance
        public string Name { get; set; }//player name
        public bool isActivePlayer { get; set; }//true/false is an active player

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
