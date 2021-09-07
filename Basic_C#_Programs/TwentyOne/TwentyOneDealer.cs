using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        //properties specific to dealer of TwentyOne
        private List<Card> _hand = new List<Card>();//Private instance of hand list

        public List<Card> Hand { get { return _hand; } set { value = _hand; } }//list of cards called Hand
        public bool Stay { get; set; }//bool used to determine if dealer will stay/hit
        public bool isBusted { get; set; }//bool used to determine if dealer is busted
        

    }
}
