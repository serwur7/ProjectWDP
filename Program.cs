using System;

namespace BlackJack
{
    enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }
 
    enum.ToString Wartosci
    {
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
        "A"
    }
    string deck = new List<string>();
    foreach (string symbol in Symbole)
        {
        foreach(string wartosc in Wartosci)
            {
            deck.Add(symbol+wartosc)
            }
        }
    Console.WriteLine(deck);
