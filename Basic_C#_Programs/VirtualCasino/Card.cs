using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasino
{
    public struct Card
    {
        //Card Properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        //Custom ToString method
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);//when Card.ToString is called, returns card face & suit 
        }

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
