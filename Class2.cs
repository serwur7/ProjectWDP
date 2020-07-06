using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Hand
    {
        public List<string> cardsInHand = new List<string> { };
        public int handValue = 0;

        public void addCard(string card)
        {
            cardsInHand.Add(card);
            card = card.Remove(card.Length - 1);
            switch (card)
            {
                case "2":
                    {
                        handValue += 2;
                        break;
                    }
                case "3":
                    {
                        handValue += 3;
                        break;
                    }
                case "4":
                    {
                        handValue += 4;
                        break;
                    }
                case "5":
                    {
                        handValue += 5;
                        break;
                    }
                case "6":
                    {
                        handValue += 6;
                        break;
                    }
                case "7":
                    {
                        handValue += 7;
                        break;
                    }
                case "8":
                    {
                        handValue += 8;
                        break;
                    }
                case "9":
                    {
                        handValue += 9;
                        break;
                    }
                case "A":
                    {
                        if(handValue > 10)
                        {
                            handValue += 1;
                        }
                        else
                        {
                            handValue += 11;
                        }
                        

                        break;
                    }
                default:
                    {
                        handValue += 10;
                        break;
                    }
            }

        }
    }
}
