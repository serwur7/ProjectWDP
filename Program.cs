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
                if (compareHands(player.handValue,dealer.handValue) == true)
                {

                }

                if (dealer.handValue < 17)
                {
                    dealer.addCard(deck.drawCard());
                }
                System.Threading.Thread.Sleep(1000);

            }
        }

        public static bool compareHands(int p, int d)
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
            return false;
        }
    }
}
