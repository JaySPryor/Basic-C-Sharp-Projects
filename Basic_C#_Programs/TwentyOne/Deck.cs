using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor (builds an object Deck of 52 cards, 4 different suits of 13 different faces
        public Deck()
        {
            Cards = new List<Card>();

            //for every card face...
            for (int i = 0; i < 13; i++)
            {
                //& for every card suit...
                for (int j = 0; j < 4; j++)
                {
                    //Creates new card
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);//Adds new card to Cards list
                }
            }
        }

        //Properties of Deck object
        public List<Card> Cards { get; set; }
        
        //Shuffle method, shuffles deck, can be ran as many "times" as needed
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
