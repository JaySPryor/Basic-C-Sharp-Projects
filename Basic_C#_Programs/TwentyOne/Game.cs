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
        public List<string> Players { get; set; }//List of players
        public string Name { get; set; }//Name of game
        public string Dealer { get; set; }//Name of Dealer

        //Abstract method
        public abstract void Play();

        //Virtual method, displays all players to console
        public virtual void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
