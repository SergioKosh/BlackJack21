using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    internal class Card
    {
        // properties of the Card
        public string Rank { get; }
        public string Suit { get; }
        public int Value { get; }

        //constructor
        public Card (string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            return ($"{Rank} of {Suit}");
        }
    }
}
