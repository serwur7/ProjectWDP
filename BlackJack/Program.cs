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

            while (true)
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
                string no_winner = "0";


                if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) != no_winner)
                {
                    Console.WriteLine("Krupier:");
                    showHand(dealer, false);
                    Console.WriteLine("\nGracz:");
                    showHand(player, true);
                    Console.WriteLine("");

                    check = false;
                    Console.WriteLine("Press any key to continue. . . ");
                    Console.ReadLine();
                    Console.Clear();
                }


                while (check)
                {
                    Console.WriteLine("Krupier:");
                    showHand(dealer, false);
                    Console.WriteLine("\nGracz:");
                    showHand(player, true);
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue. . . ");
                    Console.ReadLine();
                    Console.Clear();

                    if (dealer.handValue < 17)
                    {
                        dealer.addCard(deck.drawCard());
                        Console.Clear();
                        Console.WriteLine("Krupier:");
                        showHand(dealer, false);
                        Console.WriteLine("\nGracz:");
                        showHand(player, true);
                        Console.WriteLine("");
                        Console.WriteLine("Krupier dobrał kartę.");
                        Console.WriteLine("Press any key to continue. . . ");
                        Console.ReadLine();

                        if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) != no_winner)
                        {
                            Console.Clear();
                            Console.WriteLine("Krupier:");
                            showHand(dealer, false, true);
                            Console.WriteLine("\nGracz:");
                            Console.WriteLine("");
                            showHand(player, true, true);
                            Console.WriteLine("");
                            Console.WriteLine(compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd));
                            Console.WriteLine("Wciśnij dowolny klawisz by rozpocząć nową rozgrywkę.");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }
                    else
                    {
                        dealerEnd = true;
                        Console.Clear();
                        Console.WriteLine("Krupier:");
                        showHand(dealer, false);
                        Console.WriteLine("\nGracz:");
                        showHand(player, true);
                        Console.WriteLine("");
                        Console.WriteLine("Krupier nie dobiera.");
                    }

                    if (!playerEnd)
                    {
                        Console.WriteLine("Czy chciałbyś dobrać kartę?(t/n)");
                        if (Console.ReadLine() == "t")
                        {
                            Console.Clear();
                            player.addCard(deck.drawCard());
                            if (compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd) != no_winner)
                            {
                                Console.WriteLine("Krupier:");
                                showHand(dealer, false, true);
                                Console.WriteLine("\nGracz:");
                                showHand(player, true, true);
                                Console.WriteLine("");
                                Console.WriteLine(compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd));
                                Console.WriteLine("Wciśnij dowolny klawisz by rozpocząć nową rozgrywkę.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            playerEnd = true;
                            Console.Clear();
                        }

                    }


                    if (playerEnd == true && dealerEnd == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Krupier:");
                        showHand(dealer, false, true);
                        Console.WriteLine("\nGracz:");
                        showHand(player, true, true);
                        Console.WriteLine("");
                        Console.WriteLine(compareHands(player.handValue, dealer.handValue, dealerEnd, playerEnd));
                        Console.WriteLine("Wciśnij dowolny klawisz by rozpocząć nową rozgrywkę.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
        }



        public static string compareHands(int p, int d, bool de, bool pe)
        {
            if (p == 21)
            {
                if (d == 21)
                {
                    return "Remis....";
                }
                return "Gracz zwyciężył!";
            }
            else if (p > 21)
            {
                return "Gracz przekroczył 21 i przegrywa";
            }
            else if (d > 21)
            {
                return "DILER przekroczył 21 i przegrywa";
            }
            else if (d == 21)
            {
                return "Diler wygrał...";
            }
            else if (de && pe)
            {
                if (p > d)
                {
                    return "Gracz wygrał";
                }
                else if (d > p)
                {
                    return "DILER wygrał";
                }
                else
                {
                    return "REMIS!";
                }
            }
            return "0";
        }

        public static void showHand(Hand hand, bool isPlayer, bool endGame = false)
        {

            foreach (string karta in hand.cardsInHand)
            {
                if (isPlayer || endGame)
                {
                    Console.Write(karta + " ");

                }
                else
                {
                    Console.Write(" * ");
                }
            }
            if (isPlayer || endGame)
            {
                Console.WriteLine("\nWartosc ręki wynosi: " + hand.handValue);
            }
            else
            {
                Console.WriteLine("\nWartosc ręki wynosi: xXx");
            }
        }
    }
}
// zrobic exit
// karty mają być ładne
