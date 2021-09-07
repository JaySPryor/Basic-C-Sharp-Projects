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
                List<Card> TempList = new List<Card>();//creates new temp list to store shuffled cards in
                Random random = new Random();//instance of random class object

                //while there are cards in the deck...
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);//pick a random card...
                    TempList.Add(Cards[randomIndex]);//add it to temp list...
                    Cards.RemoveAt(randomIndex);//remove it from the deck...
                }
                Cards = TempList;//save temp list as cards
            }
        }
    }
}
