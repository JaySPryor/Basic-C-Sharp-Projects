using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorph Game object using twentyOneGame
            Game game = new TwentyOneGame();
            //list of players
            game.Players = new List<Player>();
            //instance of Player object
            Player player = new Player();
            player.Name = "Jay";//saved string as player Name
            //using overloaded operator + (shorthand +=)
            game += player;
            //overloaded - operator
            game -= player;

            //Instance of new Deck object
            Deck deck = new Deck();
            deck.Shuffle();//method that shuffles deck, can be shuffled multiple times if specified

            //loop that prints out each card in deck
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //displays number of cards in deck
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        
        

    }
}
