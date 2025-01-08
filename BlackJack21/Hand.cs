using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    internal class Hand
    {
        public List<Card> cards {  get; set; }

        public Hand() { 
            cards = new List<Card>();
        }

        //Take card to hand
        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        //calculating value
        public int GetValue()
        {
            int value = 0;

            foreach (Card card in cards)
            {
                value += card.Value;
                if ((value > 10) && (card.Rank == "Ace"))
                {
                    value -= 10;
                }
            }
            return value;
        }
    }
}
