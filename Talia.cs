using System;
using System.Collections.Generic;

public class Cards
{
    public int Value { get; private set; }
    public enum SuitType
    {
        Trefl, Pik, Kier, Karo
    }
    public SuitType Suit { get; private set; }
    public Cards(int value, SuitType suit)
    {
        Suit = suit;
        Value = value;
    }
    public Cards(string input)
    {
        if (input == null || input.Length < 2 || input.Length > 2)
            throw new ArgumentException();
        switch (input[0])
        {
            case 'T':
            case 't':
                Suit = SuitType.Trefl;
                break;
            case 'P':
            case 'p':
                Suit = SuitType.Pik;
                break;
            case 'K':
            case 'k':
                Suit = SuitType.Kier;
                break;
            case 'R':
            case 'r':
                Suit = SuitType.Karo;
                break;
            default:
                throw new ArgumentException();
        }
        int uncheckedValue = (int)input[1];
        if (uncheckedValue > 14 || uncheckedValue < 1)
            throw new ArgumentException();
        Value = uncheckedValue;
    }
    public string encode()
    {
        string encodedCard = "";
        switch (Suit)
        {
            case SuitType.Trefl:
                encodedCard += 't';
                break;
            case SuitType.Pik:
                encodedCard += 'p';
                break;
            case SuitType.Kier:
                encodedCard += 'k';
                break;
            case SuitType.Karo:
                encodedCard += 'r';
                break;
        }
        encodedCard += (char)Value;
        return encodedCard;
    }
    public override string ToString()
    {
        string output = "";
        if (Value > 10)
        {
            switch (Value)
            {
                case 11:
                    output += "Walet";
                    break;
                case 12:
                    output += "Królowa";
                    break;
                case 13:
                    output += "Król";
                    break;
                case 14:
                    output += "As";
                    break;
            }
        }
        else
        {
            output += Value;
        }
        output += "  " + System.Enum.GetName(typeof(SuitType), Suit);
        return output;

    }
}

