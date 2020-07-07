using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Deck deck = new Deck();
            //deck.shuffle();

            Hand hand = new Hand();
            hand.addCard(deck.drawCard());
            Console.WriteLine(hand.cardsInHand[0]);
            Console.WriteLine(hand.handValue);*/

            while(true)
            {
                Deck deck = new Deck();
                Hand player = new Hand();
                Hand dealer = new Hand();
                dealer.addCard(deck.drawCard());
                dealer.addCard(deck.drawCard());
                player.addCard(deck.drawCard());
                player.addCard(deck.drawCard());
                bool dealerEnd = false;
                bool playerEnd = false;

                compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd);
               
                while (true)
                {
                    if (dealerEnd == false)
                    {
                        if (dealer.handValue < 17) ///diler dobiera karty dopoki nie skonczy grac
                        {
                            dealer.addCard(deck.drawCard());
                            Console.WriteLine("DILER dobiera karte.....");
                        }
                        else
                        {
                            Console.WriteLine("DILER zakonczyl dobieranie kart");
                            dealerEnd = true;
                        }
                    }
                    showHand(dealer, false);
                    showHand(player, true);
                    if (playerEnd == false)
                    {
                        Console.WriteLine("Czy chciałbyś dobrać kartę?(t/n)");
                        if (Console.ReadLine() == "t")
                        {
                            player.addCard(deck.drawCard());
                        }
                        else
                        {
                            Console.WriteLine("Końcowa wartość kart w Twojej ręce to: " + player.handValue);
                            playerEnd = true;
                        }
                       /// gracza trzeba ukrócić
                    }
                    if (dealerEnd && playerEnd)
                    {

                       break;
                    }
                    
                    Console.Clear();

                }
            }
        }

        public static bool compareHands(int p, int d,bool de, bool pe)
        {
            if(p == 21)
            {
                if(d == 21)
                {
                    Console.WriteLine("Remis....");
                    return true;
                }
                Console.WriteLine("Gracz zwyciężył!");
                return true;
            }
            else if(d == 21)
            {
                Console.WriteLine("Diler wygrał...");
                return true;
            }
            else if(de && pe)
            {
                if(p > d)
                {
                    Console.WriteLine("Gracz wygrał");
                }
                else if (d > p)
                {
                    Console.WriteLine("DILER wygrał");
                }
                else
                {
                    Console.WriteLine("REMIS!");
                }
                return true;
            }
            return false;
        }

        public static void showHand(Hand hand, bool isPlayer, bool endGame=false)
        {

            foreach (string karta in hand.cardsInHand)
            {
                if (isPlayer || endGame)
                {
                    Console.Write(karta + " ");

                }
                else
                {
                    Console.WriteLine(" * ");
                }
            }
            Console.WriteLine("Wartosc ręki wynosi: " + hand.handValue);
        }
    }
}
