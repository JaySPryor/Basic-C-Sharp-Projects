using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //Card Properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

    }
    //enum class Suit
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    //enum class Face
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
