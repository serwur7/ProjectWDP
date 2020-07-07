using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{

    public class Deck
    {
        List<string> figures = new List<string> { "T", "K", "R", "P" };
        List<string> values = new List<string> {
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "J",
        "Q",
        "K",
        "A"};
        List<string> deck = new List<string>();

        public Deck()
        {
            shuffle();
        }

        public void shuffle()
        {
            deck.Clear();
            foreach (string figure in figures)
            {
                foreach (string value in values)
                {
                    deck.Add(value + figure);
                }
            }

            
        }

        public string drawCard()
        {
            Random rnd = new Random();
            int limit = deck.Count-1;
            int index = rnd.Next(0, limit);
            limit--;
            string card = deck[index];
            deck.RemoveAt(index);
            return card;
            }
        public void show()
        {
            foreach (string card in deck)
            {
                Console.WriteLine(card);
            }
        }
    }
   

}
