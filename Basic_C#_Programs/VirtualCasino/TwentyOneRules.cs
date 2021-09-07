using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasino.TwentyOne
{
    //Class of static methods
    public class TwentyOneRules
    {
        //Dictionary of card values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        //Method that generates all possible hand values, returns int[] of values
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//Checks for aces
            int[] result = new int[aceCount + 1] ;//int array that will hold number of aces in array + 1
            int value = Hand.Sum(x => _cardValues[x.Face]);//Gets a sum of card values in hand
            result[0] = value;//stores sum of card values in hand in result[0]

            if (result.Length == 1) return result;//if there are no aces, return hand value
            
            for (int i = 1; i < result.Length; i++)//iterates through different values of ace
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        //Method that checks for BLACKJACK
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;//if true...
            else return false;//return false
        }

        //Method that checks if player has busted
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;//if true..
            else return false;//return false
        }

        //method that checks if dealer should stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);//gets all dealers hand values, assigns values to possibleHandValues[]
            foreach (int value in possibleHandValues)//for each value...
            {
                if (value > 16 && value < 22)//if value between 16 & 22, stay
                {
                    return true;
                }
            }
            return false;//if not, dealer does not stay
        }

        //Method that returns nullable boolean
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);//get player hand value
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);//get dealer hand value

            int playerScore = playerResults.Where(x => x < 22).Max();//use lambda expression to filter player results that are less than 22, get largest value, add to Where list
            int dealerScore = dealerResults.Where(x => x < 22).Max();//same for dealer
            //return true/false/null depending on who won
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
