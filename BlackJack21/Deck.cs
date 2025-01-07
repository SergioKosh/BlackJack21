﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    internal class Deck

    {
        //using List instead of arrays because List objects can shrink, arrays have fix size 
        private List<Card> cards;
        public Deck()
        {
            string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    cards.Add(new Card(suits[i], ranks[j], values[j]));
                }
            }

        }

        public Card DrawCard()
        {
            // Draw a random card from the deck
            Random rnd = new Random();
            int cardNumber = rnd.Next(0, cards.Count());
            Card card = cards[cardNumber];

            // RemoveAt removes element from a collection at specific position
            cards.RemoveAt(cardNumber);

            return card;
        }

    }

    }
    

    




