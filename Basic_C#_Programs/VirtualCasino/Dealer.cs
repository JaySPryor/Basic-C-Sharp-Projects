using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VirtualCasino
{
    public class Dealer
    {
        //dealer props
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //deal method
        public void Deal(List<Card> Hand)//takes card<list> Hand...
        {
            Hand.Add(Deck.Cards.First());//adds first card in deck to hand...
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);//displays card...
            //logs every time card is dealt to text file
            using (StreamWriter file = new StreamWriter(@"D:\School\GitHub\Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOne\Logs\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);//removes card from deck
        }

    }
}
