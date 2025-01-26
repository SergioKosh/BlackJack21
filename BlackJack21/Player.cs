using System;

namespace BlackJack21
{
    internal class Player
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public void GetInformation()
        {
            //if a player doesn't know the rules
            string answer = "no";

            // collecting information
            Console.WriteLine("Hey hey hey! Let's have fun! But first of all what's your name?");
            Name = Console.ReadLine();
            Console.WriteLine($"Welcom, dear {Name}!");
            Console.WriteLine("I won't check your ID, but tell me how old you are!");
            Age = Convert.ToInt32( Console.ReadLine() );

            // not for kids
            if (Age < 18)
            {
                Console.WriteLine("You are not allowed to play. See you next time!");
                Console.ReadLine();
                Environment.Exit(48);
            }
            else
            {
                Console.WriteLine("You are old enough to make your own mistakes");
            }

            Console.WriteLine("Just one more question... Do you know rules of the game? " +
                "Don't worry I will explain you, but answer simple yes or no");
            answer = Console.ReadLine();

            //explain rules


            while (answer == "no")
            {
                // explanation of the rules I took from https://www.setfor.net/blog-639d5899302.html

                Console.WriteLine("Blackjack is a card game where players aim to get a hand that is closer to " +
                    "21 than the dealer’s hand, without going over 21. Each card is worth its face value, with " +
                    "face cards (Jack, Queen, King) worth 10 and Aces worth either 1 or 11. ");
                Console.WriteLine("The goal of blackjack is simple.  All one needs to do to win is have a higher " +
                    "hand value than the dealer, without going over 21. Players are dealt two cards and can then" +
                    " choose to “hit” (receive additional cards) or “stand” (keep their current hand). The dealer" +
                    " also receives two cards, but only one is face up.\r\n\r\nIf a player’s hand exceeds 21, " +
                    "they “bust” and lose the game. If the dealer busts, all remaining players win. " +
                    "If neither the player nor the dealer busts, the player with the highest hand value wins.");
                Console.WriteLine("Do you understand the rules?");
               
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    break;
                }

                while ((answer != "no") || (answer != "yes"))  {
                    Console.WriteLine($"It's not what I asked you... Do you know the rules of the Game?" +
                        $" Seriosly, {Name}, yes or no.");
                }
            }
            Console.Clear();
            Console.WriteLine("Alright, we are done, let's start!");


        }
    }
}
