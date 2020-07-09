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
                bool check = true;

                if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) == true)
                {
                    check = false;
                    
                    showHand(dealer, false, true);
                    showHand(player, true, true);
                    Console.WriteLine("Press any key to continue. . . ");
                    Console.ReadLine();
                    Console.Clear();
                }

                while (check)
                {
                    showHand(dealer, false, true);
                    showHand(player, true, true);
                    if (dealerEnd == false)
                    {
                        if (dealer.handValue < 17) ///diler dobiera karty dopoki nie skonczy grac
                        {
                            Console.WriteLine("Wcisnij dowolny klawisz zeby kontynuowac ");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("DILER dobrał karte.....");
                            dealer.addCard(deck.drawCard());
                            if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) == true)
                            {
                                showHand(dealer, false, true);
                                showHand(player, true, true);
                                Console.WriteLine("Press any key to continue. . . ");
                                Console.ReadLine();
                                Console.Clear();
                                if (dealer.handValue != 21)
                                {
                                    
                                    break;
                                }
                            }

                        }///jak diler dobiera karty jest ok a jak nie chce to wydupca duzo rzeczy na ekran
                        ///najs
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
                            Console.Clear();
                            player.addCard(deck.drawCard());
                            if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) == true)
                            {
                                showHand(dealer, false, true);
                                showHand(player, true, true);
                                Console.WriteLine("Press any key to continue. . . ");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Końcowa wartość kart w Twojej ręce to: " + player.handValue);
                            playerEnd = true;
                        }
                    }
                    if (dealerEnd && playerEnd)
                    {
                        compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd);
                        Console.WriteLine("Wcisnij dowolny klawisz zeby kontynuowac ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
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
            else if(p > 21)
            {
                Console.WriteLine("Gracz przekroczył 21 i przegrywa");
                return true;
            }
            else if(d > 21)
            {
                Console.WriteLine("DILER przekroczył 21 i przegrywa");
                return true;
            }
            else if(d == 21)
            {
               //Console.WriteLine("Diler wygrał...");
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
