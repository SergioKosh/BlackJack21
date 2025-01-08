using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack21
{
    internal class Game
    {
        private Deck deck;
        private Hand player;
        private Hand dealer;

        private Player you;

        public Game()
        {
            deck = new Deck();
            player = new Hand();
            dealer = new Hand();

            you.GetInformation();
            //take cards

            player.TakeCard(deck.DrawCard());
            player.TakeCard(deck.DrawCard());
            dealer.TakeCard(deck.DrawCard());
            dealer.TakeCard(deck.DrawCard());
             
        }
    }
}
