using System;
using System.Collections.Generic;

public class Talia
{


    

    
    string deck = new List<string>();
    foreach (string symbol in Symbole)
        {
        foreach(string wartosc in Wartosci)
            {
            deck.Add(symbol+wartosc)
            }
        }
Console.WriteLine(deck);
}

