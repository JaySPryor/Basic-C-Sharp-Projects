using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Class inherits from abstract Game class, IWalkAway interface 
    public class TwentyOneGame : Game, IWalkAway
    {
        //inherited abstract method
        public override void Play()
        {
            throw new NotImplementedException();
        }

        //inherited abstract method
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        //inherited interface
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
