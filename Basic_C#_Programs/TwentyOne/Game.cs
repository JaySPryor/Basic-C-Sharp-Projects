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
        public List<Player> Players { get; set; }//List of Player objects called Players
        public string Name { get; set; }//Name of game
        public string Dealer { get; set; }//Name of Dealer

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
