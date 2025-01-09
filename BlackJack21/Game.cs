using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
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

        public void PlayerTurn()
        {
            string answer = "hit";
            Console.WriteLine("It's your turn!");
            Console.WriteLine($"You've got {player.GetValue()}");
            Console.WriteLine("Choose your desteny! Stay or hit?");
            answer = Console.ReadLine().ToLower();
            while (answer == "hit")
            {
                Card card = deck.DrawCard();
                player.TakeCard(card);
                Console.WriteLine($"You took " + card.ToString());
                Console.WriteLine($"You've got {player.GetValue()}");

                if (player.GetValue() > 21)
                {
                    Console.WriteLine("You've lost!");
                }

                Console.WriteLine("Stay or hit?");
                answer = Console.ReadLine().ToLower();

                if (answer == "stay")
                {
                    break;
                }

            }
        }

        public void DealerTurn()
        {
            Console.WriteLine("Dealer's turn!");

            // Each game has a rule about whether the dealer must hit or stand on soft 17
            while (dealer.GetValue() > 17)
            {
                Card card = deck.DrawCard();
                dealer.TakeCard(card);
                Console.WriteLine($"The dealer's got " + card.ToString() );
                Console.WriteLine($"The dealer's hand value {dealer.GetValue()}");

                if (dealer.GetValue() > 21)
                {
                    Console.WriteLine($"{you.Name}, you are lucky today! You win!");
                }
            }
        }


    }
}
