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
        //Dealer specifit to TwentyOneGame
        public TwentyOneDealer Dealer { get; set; }

        //Main code for twentyone gameplay (inherited abstract method from Game class)
        public override void Play()
        {
            Dealer = new TwentyOneDealer();//current dealer 
            //for every player..
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();//new hand for player
                player.Stay = false;//automatically starts player.Stay to false
            }
            Dealer.Hand = new List<Card>();//new hand for dealer
            Dealer.Stay = false;//starts dealer.stay as false
            Dealer.Deck = new Deck();//new deck every round
            Dealer.Deck.Shuffle();//shuffle deck

            Console.WriteLine("Place your bet!");

            //loop that takes player bets
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());//takes each players bet
                bool successfullyBet = player.Bet(bet);//sets successfullyBet to true/false
                
                //if false
                if (!successfullyBet)
                {
                    return;//ends method
                }
                Bets[player] = bet;//stores player bet in dictionary
            }

            //loop that deals cards
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)//for each player...
                {
                    Console.Write("{0}: ", player.Name);//display player name...
                    Dealer.Deal(player.Hand);//calls Deal method, deals card to hand...
                    
                    //check for BLACKJACK
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);//gives player back their bet + winnings
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);//Dealer deals their own hand

                //Check dealers hand for blackjack
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)//if dealer has blackjack...
                    {
                        Console.WriteLine("Dealer has BlackJack. Everyone loses!");//display message...
                        foreach (KeyValuePair<Player, int> entry in Bets)//for every player...
                        {
                            Dealer.Balance += entry.Value;//Dealer balance is awarded their bet
                        }
                        return;
                    }
                }
            }
            //ask for players next action
            foreach (Player player in Players)
            {
                //loop that keeps asking player if they want to hit
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());//card.ToString() used to show player their cards
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();

                    //if player stays...
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;//ends while loop, checks while condition
                    }
                    //if player hits...
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);//player is dealt another card, prints card to console
                    }
                    //Check if player busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)//if player busted...
                    {
                        Dealer.Balance += Bets[player];//Dealer gets players bet...
                        //display bust message...
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        //ask if player wants to play again...
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine().ToLower();//save input as answer...
                        
                        //if yes...
                        if (answer == "yes" || answer == "y")
                        {
                            player.isActivePlayer = true;//player is still activePlayer
                            return;
                        }
                        //if not...
                        else
                        {
                            player.isActivePlayer = false;//player is !activePlayer, game is ended
                            return;
                        }
                    }
                }
            }
            //Check if dealer is busted
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            //Check if dealer must stay
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            //if dealer is !staying & !busted, get more cards
            while (!Dealer.Stay & !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);//Dealer is dealt another card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//check if dealer is busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//Check if dealer should stay
            }
            if (Dealer.Stay)//if dealer stays...
            {
                Console.WriteLine("Dealer is staying.");//display message
            }
            if (Dealer.isBusted)//if dealer is busted...
            {
                Console.WriteLine("Dealer Busted!");//display message..
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value * 2);//every player sees how much they won...
                    /*(using lambda expression) loop through each key/value pair in Players where name matches player name,
                     * take player & add to Where list, take players balance & add bet * 2. */
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;//subtract bets from dealer balance
                }
                return;
            }
            //if player & dealer stay, compare hands to see who wins
            foreach (Player player in Players)
            {
                //use nullable boolean(bool?) to find if: player>dealer/player<dealer/player=dealer
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);//call CompareHands method to see who won (true/false/null)
                //if push...
                if (playerWon == null)
                {
                    Console.WriteLine("Push! Nobody wins.");
                    player.Balance += Bets[player];//add player bet back to player balance
                }
                //if player wins...
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);//add player bet & winnings to balance
                    Dealer.Balance -= Bets[player];//subtract winnings from dealer balance
                }
                //if dealer wins...
                else
                {
                    Console.WriteLine("Dealer wins {0}.", Bets[player]);
                    Dealer.Balance += Bets[player];//add player bet to dealer balance
                }
                //ask each player if they want to play again
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                //if yes..
                if (answer == "yes" || answer == "y")
                {
                    player.isActivePlayer = true;//return true to isActivePlayer
                }
                //else...
                else
                {
                    player.isActivePlayer = false;//return false to isAcivePlayer
                }
            }
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
