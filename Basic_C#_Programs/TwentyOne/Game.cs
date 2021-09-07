using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Base (Abstract) class
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();//private instance of players list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();//private instance of bets list

        public List<Player> Players { get { return _players; } set { _players = value; } }//List of Player objects called Players
        public string Name { get; set; }//Name of game
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }//Dictionary of player bets

        //Abstract method
        public abstract void Play();

        //Virtual method, displays all players to console
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
