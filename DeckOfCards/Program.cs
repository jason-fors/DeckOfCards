using System;


namespace DeckOfCards
{
    public class CardGame
    {
        static void Main()
        {

            Deck deck = new Deck();

            Console.WriteLine("I have created a deck.  These are the cards.");
            deck.seeDeck();

            deck.Shuffle();
            Console.WriteLine("Press enter to shuffle the deck.");
            Console.ReadLine();

            Console.WriteLine("Now I have shuffled the deck.  Here are the cards.");
            deck.seeDeck();

            string moreCards = "yes";

            while (moreCards == "yes" || moreCards == "y")                          // Allows the user to keep dealing sets of cards from the deck. 
            {
                Console.WriteLine("I'm going to deal you some cards.  How many cards would you like?");
                string numCards = Console.ReadLine();
                int numberCards = 0;
                try
                {
                    numberCards = Int32.Parse(numCards);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{numCards}'. Please enter a numeric value.");
                    continue;
                }
                Console.WriteLine("These are your cards:");

                for (int i = 0; i < numberCards; i++)
                {
                    // Normally, we would want to check to ensure there is another card in the deck here.  Leaving it this way to test the method.
                    Card nextCard = deck.deal_one_card();                           // In a game we can do something with nextCard, like add it to a player hand object, etc.
                }

                Console.WriteLine("Now those cards are gone from the deck. Press enter to see the cards left in the deck.");
                Console.ReadLine();
                deck.seeDeck();

                if (deck.Cards.Count > 0)
                { 
                    Console.WriteLine("Would you like for me to deal you some more cards? (If so, type 'y' or 'yes')");
                    moreCards = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("All the cards have been dealt. Thank you for trying out my deck of cards implementation!");
                    moreCards = "no";

                }

            };

            Console.WriteLine("Press enter to close program.");
            Console.ReadLine();

        }

    }
}






